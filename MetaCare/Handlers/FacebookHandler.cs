using HtmlAgilityPack;
using MetaCare.Commons;
using MetaCare.Contants;
using MetaCare.Dtos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetaCare.Handlers
{
    public class FacebookHandler
    {
        private FacebookHandlerDto _entity;

        public FacebookHandler(FacebookHandlerDto entity)
        {
            _entity = entity;
        }

        public enum Status
        {
            [EnumMember(Value = "Live")]
            Success,
            Fail,
            WrongPassword,
            CheckpointCaptcha,
            Checkpoint681,
            Checkpoint,
            Error2FA,
            Error
        }

        public async Task<Status> LoginFacebook()
        {
            InitializeHttpClient();

            if (_entity.TypeLogin == 0)
            {
                if (!await CheckCookieStatus(_entity.Account.Uid))
                {
                    return Status.Checkpoint;
                }
                return Status.Success;
            }

            return await LoginFacebookUidPass();
        }

        public void InitializeHttpClient()
        {
            if (_entity.ApiClient == null)
            {
                if (_entity.TypeLogin == 0 && !string.IsNullOrEmpty(_entity.Account.Cookies))
                {
                    _entity.ApiClient = new ApiClient(_entity.Account, true, FacebookContant.UserAgent);
                }
                else
                {
                    _entity.ApiClient = new ApiClient(_entity.Account, userAgent: FacebookContant.UserAgent);
                }
            }
        }

        public async Task<Status> LoginFacebookUidPass()
        {
            var response = await _entity.ApiClient.GetWithRetry("https://www.facebook.com/");
            if (!response.IsSuccessStatusCode)
            {
                return Status.Fail;
            }

            var responseStr = await response.Content.ReadAsStringAsync();
            var publicKey = Regex.Match(responseStr, "\"publicKey\":\"(.*?)\"").Groups[1].Value;
            var keyId = Regex.Match(responseStr, "\"keyId\":(.*?)}").Groups[1].Value;
            var action = Regex.Match(responseStr, "action=\"(.*?)\"").Groups[1].Value.Replace("amp;", "");
            var datr = Regex.Match(responseStr, "\"_js_datr\",\"(.*?)\"").Groups[1].Value;
            string lsd = Regex.Match(responseStr, "LSD\"(.*?){\"token\":\"(.*?)\"").Groups[2].Value;
            string jazoest = Regex.Match(responseStr, "name=\"jazoest\" value=\"(\\d+)\"").Groups[1].Value;
            string originUri = $"https://www.facebook.com{action}";

            var passwordEncrypt = PasswordEncrypt.FacebookEncryptHelper.GenerateEncPassword(_entity.Account.Password, publicKey, keyId, "5");

            var httpRequestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Post, originUri);
            _entity.ApiClient._cookieContainer.Add(new System.Net.Cookie
            {
                Name = "datr",
                Value = datr,
                Path = "/",
                Domain = "facebook.com",
                Expired = false,
                Secure = true,
                Expires = DateTime.Now.AddDays(10)
            });
            httpRequestMessage.Headers.Add("Cookie", $"datr={datr}");
            httpRequestMessage.Content = new System.Net.Http.FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("jazoest", jazoest),
                    new KeyValuePair<string, string>("lsd", lsd),
                    new KeyValuePair<string, string>("email", _entity.Account.Uid),
                    new KeyValuePair<string, string>("login_source", "comet_headerless_login"),
                    new KeyValuePair<string, string>("next", ""),
                    new KeyValuePair<string, string>("encpass", passwordEncrypt),
                });

            var responseLogin = await _entity.ApiClient.SendRequest(httpRequestMessage);
            if (!responseLogin.IsSuccessStatusCode)
            {
                return Status.Fail;
            }

            if (responseLogin.RequestMessage.RequestUri.AbsoluteUri == "https://www.facebook.com/?lsrc=lb" || responseLogin.RequestMessage.RequestUri.AbsoluteUri == "https://www.facebook.com/")
            {
                return Status.Success;
            }

            if (responseLogin.RequestMessage.RequestUri.AbsolutePath == "/two_step_verification/authentication/")
            {
                return Status.CheckpointCaptcha;
            }

            if (responseLogin.RequestMessage.RequestUri.AbsolutePath == "681")
            {
                return Status.Checkpoint681;
            }

            var contentLogin = await responseLogin.Content.ReadAsStringAsync();

            var encryptContext = Regex.Match(contentLogin, "encrypted_context=(.*?)&").Groups[1].Value;
            if (string.IsNullOrEmpty(encryptContext))
                return Status.WrongPassword;

            if (responseLogin.RequestMessage.RequestUri.AbsolutePath == "/two_step_verification/two_factor/")
            {
                if (string.IsNullOrEmpty(_entity.Account.Key2Fa))
                {
                    return Status.Error2FA;
                }

                var responseVerification = await _entity.ApiClient.GetWithRetry("https://www.facebook.com/checkpoint");
                if (!responseVerification.IsSuccessStatusCode)
                {
                    return Status.Fail;
                }

                responseStr = await responseVerification.Content.ReadAsStringAsync();
                var document = new HtmlDocument();
                document.LoadHtml(responseStr);

                var fbdtsg = document.DocumentNode.SelectNodes("//input[@name='fb_dtsg']").FirstOrDefault().Attributes["value"].Value;
                lsd = Regex.Match(responseStr, "LSD\",\\[],{\"token\":\"(.*?)\"").Groups[1].Value;
                jazoest = document.DocumentNode.SelectNodes("//input[@name='jazoest']").FirstOrDefault().Attributes["value"].Value;
                var nh = document.DocumentNode.SelectNodes("//input[@name='nh']").FirstOrDefault().Attributes["value"].Value;
                var buttonName = document.DocumentNode.SelectSingleNode("//button[@id='checkpointSubmitButton']").Attributes["value"].Value;

                var code2Fa = Common.GetCode(_entity.Account.Key2Fa);

                var payload = new Dictionary<string, string>
                {
                    { "jazoest", jazoest },
                    { "fb_dtsg", fbdtsg },
                    { "nh", nh },
                    { "approvals_code", code2Fa },
                    { "submit[Continue]", buttonName },
                };

                response = await _entity.ApiClient.PostWithRetry("https://www.facebook.com/checkpoint/", new FormUrlEncodedContent(payload));
                responseStr = await response.Content.ReadAsStringAsync();
                while (response.RequestMessage.RequestUri.AbsolutePath == "/checkpoint/")
                {
                    response = await _entity.ApiClient.GetWithRetry("https://www.facebook.com/checkpoint");
                    responseStr = await response.Content.ReadAsStringAsync();

                    document = new HtmlDocument();
                    document.LoadHtml(responseStr);

                    var tbApproval = document.DocumentNode.SelectNodes("//input[@id='approvals_code']");
                    if (tbApproval != null && tbApproval.Count > 0)
                    {
                        return Status.Error2FA;
                    }

                    var nameDontSave = document.DocumentNode.SelectNodes("//input[@name='name_action_selected']")?.LastOrDefault()?.Attributes["value"]?.Value;
                    if (responseStr.Contains("submit[This was me]"))
                    {
                        buttonName = document.DocumentNode.SelectSingleNode("//button[@id='checkpointSubmitButton']").Attributes["value"]?.Value;
                        payload = new Dictionary<string, string>
                        {
                            { "jazoest", jazoest },
                            { "fb_dtsg", fbdtsg },
                            { "nh", nh },
                            { "name_action_selected", nameDontSave },
                            { "submit[This was me]", buttonName },
                        };
                        response = await _entity.ApiClient.PostWithRetry("https://www.facebook.com/checkpoint/", new FormUrlEncodedContent(payload));
                        responseStr = await response.Content.ReadAsStringAsync();
                    }
                    else if (!string.IsNullOrEmpty(nameDontSave))
                    {
                        payload = new Dictionary<string, string>
                        {
                            { "jazoest", jazoest },
                            { "fb_dtsg", fbdtsg },
                            { "nh", nh },
                            { "name_action_selected", nameDontSave },
                            { "submit[Continue]", buttonName },
                        };
                        response = await _entity.ApiClient.PostWithRetry("https://www.facebook.com/checkpoint/", new FormUrlEncodedContent(payload));
                        responseStr = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        payload = new Dictionary<string, string>
                        {
                            { "jazoest", jazoest },
                            { "fb_dtsg", fbdtsg },
                            { "nh", nh },
                            { "submit[Continue]", buttonName },
                        };
                        response = await _entity.ApiClient.PostWithRetry("https://www.facebook.com/checkpoint/", new FormUrlEncodedContent(payload));
                        responseStr = await response.Content.ReadAsStringAsync();
                    }
                }

                if (!await CheckCookieStatus(_entity.Account.Uid))
                {
                    return Status.Checkpoint;
                }
                return Status.Success;
            }
            return Status.Success;
        }

        public async Task<(string, string)> GetTokenAsync()
        {
            var token = string.Empty;
            var cookie = string.Empty;
            try
            {
                var response = await _entity.ApiClient.GetWithRetry("https://business.facebook.com/billing_hub/payment_activity?asset_id=");
                if (response.IsSuccessStatusCode)
                {
                    var responseStr = await response.Content.ReadAsStringAsync();
                    token = Regex.Match(responseStr, "EAAG(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
                    cookie = await GetCookie();
                }
            }
            catch { }
            return (cookie, token);
        }

        public async Task<List<AdAccountDto>> LoadAllAdAccount()
        {
            if (string.IsNullOrEmpty(_entity.Account.TokenEAAG))
            {
                var (cookies, token) = await GetTokenAsync();
                _entity.Account.TokenEAAG = token;
                _entity.Account.Cookies = cookies;
            }

            var adAccounts = new List<AdAccountDto>();
            var tasks = new List<Task>();
            var nextUrl = $"https://graph.facebook.com/v14.0/me/adaccounts?fields=business_country_code,business,spend_cap,created_time,funding_source_details,campaigns{{boosted_object_id}},account_status,adspaymentcycle,id,currency,amount_spent,balance,name,timezone_name,adtrust_dsl,disable_reason,min_billing_threshold,limit{{2000}}&summary=total_count&access_token={_entity.Account.TokenEAAG}";

            do
            {
                try
                {
                    var response = await _entity.ApiClient.GetWithRetry(nextUrl);
                    if (!response.IsSuccessStatusCode)
                    {
                        return adAccounts;
                    }

                    var responseStr = await response.Content.ReadAsStringAsync();
                    JObject adAccountObjects = JObject.Parse(responseStr);
                    var adAccountObjectsData = adAccountObjects["data"].ToObject<JArray>();

                    foreach (JObject adAccountObjectData in adAccountObjectsData)
                    {
                        tasks.Add(Task.Run(() =>
                        {
                            var adAccountObject = adAccountObjectData;
                            var adAccountId = adAccountObject["id"].ToString();
                            var adAccountName = adAccountObject["name"].ToString();
                            var adAccountCurrency = adAccountObject["currency"].ToString();
                            var adtrust = adAccountObject["adtrust_dsl"].ToString();
                            var statusAdTrust = adtrust == "-1" ? "Nolimit" : adtrust;
                            var threshold = adAccountObject["min_billing_threshold"]["amount"].ToString();
                            var balance = adAccountObject["balance"].ToString();
                            var accountSpent = adAccountObject["amount_spent"].ToString();
                            var paymentMethod = string.Empty;
                            if (adAccountObject.ContainsKey("funding_source_details"))
                            {
                                paymentMethod = string.IsNullOrEmpty(adAccountObject["funding_source_details"]?["display_string"]?.ToString()) ? "N/A" : adAccountObject["funding_source_details"]?["display_string"]?.ToString();
                            }
                            var timeZones = adAccountObject["timezone_name"].ToString();
                            var campaignCount = adAccountObject["campaigns"]?["summary"]?["total_count"].ToString();
                            var businessId = adAccountObject["business"]?["id"].ToString();
                            var timecreated = string.Empty;
                            if (Common.IsDateTimeOffset(adAccountObject["created_time"].ToString()))
                            {
                                timecreated = Convert.ToDateTime(adAccountObject["created_time"].ToString()).ToString("dd/MM/yyyy");
                            }
                            else if (Common.IsUnixTimestamp(adAccountObject["created_time"].ToString()))
                            {
                                timecreated = DateTimeOffset.FromUnixTimeSeconds(long.Parse(adAccountObject["created_time"].ToString())).DateTime.ToString("dd/MM/yyyy");
                            }
                            var businessCountryCode = string.Empty;
                            if (adAccountObject.ContainsKey("business_country_code"))
                            {
                                businessCountryCode = adAccountObject["business_country_code"].ToString();
                            }
                            var accountStatus = adAccountObject["account_status"].ToString();
                            if (accountStatus == "1")
                            {
                                accountStatus = "Active";
                            }
                            else if (accountStatus == "2")
                            {
                                accountStatus = "Disabled";
                                var disableReason = adAccountObject["disable_reason"].ToString();
                                var statusReason = string.Empty;
                                switch (disableReason)
                                {
                                    case "0":
                                        statusReason = "NONE";
                                        break;
                                    case "1":
                                        statusReason = "ADS_INTEGRITY_POLICY";
                                        break;
                                    case "2":
                                        statusReason = "ADS_IP_REVIEW";
                                        break;
                                    case "3":
                                        statusReason = "RISK_PAYMENT";
                                        break;
                                    case "4":
                                        statusReason = "GRAY_ACCOUNT_SHUT_DOWN";
                                        break;
                                    case "5":
                                        statusReason = "ADS_AFC_REVIEW";
                                        break;
                                    case "6":
                                        statusReason = "BUSINESS_INTEGRITY_RAR";
                                        break;
                                    case "7":
                                        statusReason = "PERMANENT_CLOSE";
                                        break;
                                    case "8":
                                        statusReason = "UNUSED_RESELLER_ACCOUNT";
                                        break;
                                    case "9":
                                        statusReason = "UNUSED_ACCOUNT";
                                        break;
                                    case "10":
                                        statusReason = "UMBRELLA_AD_ACCOUNT";
                                        break;
                                    case "11":
                                        statusReason = "BUSINESS_MANAGER_INTEGRITY_POLICY";
                                        break;
                                    case "12":
                                        statusReason = "MISREPRESENTED_AD_ACCOUNT";
                                        break;
                                    case "13":
                                        statusReason = "AOAB_DESHARE_LEGAL_ENTITY";
                                        break;
                                    case "14":
                                        statusReason = "CTX_THREAD_REVIEW";
                                        break;
                                    case "15":
                                        statusReason = "COMPROMISED_AD_ACCOUNT";
                                        break;
                                }
                                accountStatus += $"=>({statusReason})";
                            }
                            else if (accountStatus == "3")
                            {
                                accountStatus = "Unsettled";
                            }
                            else if (accountStatus == "7")
                            {
                                accountStatus = "Pending Risk Review";
                            }
                            else if (accountStatus == "8")
                            {
                                accountStatus = "Pending Settled";
                            }
                            else if (accountStatus == "9")
                            {
                                accountStatus = "In Grace Period";
                            }
                            else if (accountStatus == "100")
                            {
                                accountStatus = "Pending Closure";
                            }
                            else if (accountStatus == "101")
                            {
                                accountStatus = "Closed";
                            }
                            else if (accountStatus == "201")
                            {
                                accountStatus = "Any Active";
                            }
                            else if (accountStatus == "202")
                            {
                                accountStatus = "Any Closed";
                            }

                            var adAccount = new AdAccountDto()
                            {
                                Id = adAccountId,
                                Name = adAccountName,
                                Currency = adAccountCurrency,
                                Status = accountStatus,
                                Spent = accountSpent,
                                Balance = balance,
                                Payment = paymentMethod,
                                TimeZone = timeZones,
                                CampaignCount = campaignCount,
                                BusinessId = businessId,
                                CreatedTime = timecreated,
                                BusinessCountryCode = businessCountryCode,
                                Threshold = threshold,
                                Limit = statusAdTrust
                            };

                            adAccounts.Add(adAccount);
                        }));
                    }
                    nextUrl = adAccountObjects["paging"]?["next"]?.ToString();
                }
                catch { }
            } while (!string.IsNullOrEmpty(nextUrl));

            Task.WaitAll(tasks.ToArray());

            if (adAccounts.Count < _entity.Account.AdAccounts?.Count)
            {
                return _entity.Account.AdAccounts;
            }

            _entity.Account.AdAccounts = adAccounts;
            return adAccounts;
        }

        public async Task<string> GetCookie()
        {
            return await _entity.ApiClient._cookieContainer.CookieToString("https://www.facebook.com/");
        }

        public async Task<bool> CheckCookieStatus(string uid)
        {
            var response = await _entity.ApiClient.GetWithRetry("https://www.facebook.com/me");
            var responseStr = await response.Content.ReadAsStringAsync();
            if (Regex.Match(responseStr, "\"USER_ID\":\"(.*?)\"").Groups[1].Value.Trim() == uid.Trim() && !response.RequestMessage.RequestUri.AbsolutePath.Contains("1501092823525282") && !response.RequestMessage.RequestUri.AbsolutePath.Contains("828281030927956"))
            {
                return true;
            }
            return false;
        }
    }
}
