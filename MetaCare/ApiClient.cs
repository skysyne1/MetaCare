using MetaCare.Commons;
using MetaCare.Contants;
using MetaCare.Dtos;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetaCare
{
    public class ApiClient
    {
        public CookieContainer _cookieContainer;
        private HttpClient _apiClient;
        private AccountDto _accountDto;
        private string _cookies;
        private string _userAgent;
        private bool _isUseCookie;

        public ApiClient(AccountDto accountDto, bool isUseCookie = false, string userAgent = "")
        {
            _accountDto = accountDto;
            _cookies = accountDto.Cookies;
            _userAgent = userAgent;
            _isUseCookie = isUseCookie;
            Init();
        }

        private void Init()
        {
            if (_cookieContainer == null)
            {
                _cookieContainer = new CookieContainer();
            }

            if (!string.IsNullOrEmpty(_cookies) && _isUseCookie)
            {
                var cookieJar = _cookies.Split(';');
                foreach (var cookie in cookieJar)
                {
                    var cookieItem = cookie.Split('=');
                    if (cookieItem.Length < 2)
                        continue;

                    if (cookieItem[0].Trim().Equals("c_user") || cookieItem[0].Trim().Equals("xs") || cookieItem[0].Trim().Equals("datr"))
                    {
                        _cookieContainer.Add(new Cookie(cookieItem[0].Trim(), cookieItem[1].Trim(), "/", "facebook.com"));
                    }
                }
            }

            var httpClientHandler = new HttpClientHandler
            {
                CookieContainer = _cookieContainer,
                UseCookies = true,
                UseDefaultCredentials = false,
                SslProtocols = System.Security.Authentication.SslProtocols.Tls12
            };

            _apiClient = new HttpClient(httpClientHandler);
            if (!string.IsNullOrEmpty(_userAgent))
            {
                _apiClient.DefaultRequestHeaders.UserAgent.ParseAdd(_userAgent);
            }
            else
            {
                _apiClient.DefaultRequestHeaders.UserAgent.ParseAdd(FacebookContant.UserAgent);
            }

            _apiClient.SetDefaultHeader();
        }

        private async Task<T> ExecuteWithRetry<T>(
            Func<Task<T>> action,
            int maxRetries = 3,
            int delayMilliseconds = 1000,
            Action<Exception, int> onRetry = null)
        {
            int attempt = 0;
            Exception lastException = null;

            while (attempt < maxRetries)
            {
                try
                {
                    return await action(); // Thực hiện hành động
                }
                catch (Exception ex)
                {
                    lastException = ex;
                    attempt++;

                    // Gọi hàm onRetry nếu được cung cấp
                    onRetry?.Invoke(ex, attempt);

                    // Nếu vượt quá số lần retry, ném ngoại lệ
                    if (attempt >= maxRetries)
                        throw new InvalidOperationException($"Thử lại thất bại sau {maxRetries} lần.", ex);

                    // Chờ trước khi thử lại
                    await Task.Delay(delayMilliseconds);
                }
            }

            // Không bao giờ đến đây, nhưng cần cho trình biên dịch
            throw lastException;
        }


        public async Task ResolveCheckpointAutomate(string responseStr)
        {
            var dtsgToken = Regex.Match(responseStr, "DTSGInitialData\",\\[],{\"token\":\"(.*?)\"").Groups[1].Value;
            var payload = new Dictionary<string, string>
            {
                { "av", _accountDto.Uid },
                { "dpr", "1" },
                { "fb_dtsg", dtsgToken },
                { "jazoest", "25401" },
                { "lsd", "_SUj0S8K_WcCtiwQFwev4Y" },
                { "fb_api_caller_class", "RelayModern" },
                { "fb_api_req_friendly_name", "FBScrapingWarningMutation" },
                { "variables", "{}" },
                { "server_timestamps", "true" },
                { "doc_id", "6339492849481770" }
            };

            var response = await _apiClient.PostAsync("https://www.facebook.com/api/graphql/", new FormUrlEncodedContent(payload));
        }

        public async Task<HttpResponseMessage> GetWithRetry(string url, int maxRetry = 3)
        {
            return await ExecuteWithRetry(async () =>
            {
                var response = await FetchResponseWithUtf8Check(url);

                if (!response.IsSuccessStatusCode)
                {
                    response = await HandleCheckpoint("https://www.facebook.com/me");
                    if (response == null) return null;

                    return await FetchResponseWithUtf8Check(url);
                }

                if (response.IsAutomationCheckpoint())
                {
                    response = await HandleCheckpoint(url);
                }

                return response;
            },
            maxRetry,
            delayMilliseconds: 200,
            onRetry: (ex, attempt) =>
            {
                Console.WriteLine($"Attempt {attempt} failed. Error: {ex.Message}");
            });
        }

        public async Task<HttpResponseMessage> PostWithRetry(string url, HttpContent content, int maxRetry = 3)
        {
            return await ExecuteWithRetry(async () =>
            {
                var response = await FetchResponseWithUtf8Check(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    response = await HandleCheckpoint("https://www.facebook.com/me");
                    if (response == null) return null;

                    return await FetchResponseWithUtf8Check(url);
                }

                if (response.IsAutomationCheckpoint())
                {
                    response = await HandleCheckpoint(url);
                }

                return response;
            },
            maxRetry,
            delayMilliseconds: 200,
            onRetry: (ex, attempt) =>
            {
                Console.WriteLine($"Attempt {attempt} failed. Error: {ex.Message}");
            });
        }

        public async Task<HttpResponseMessage> SendRequest(HttpRequestMessage httpRequestMessage, int maxRetry = 3)
        {
            return await ExecuteWithRetry(async () =>
            {
                var response = await _apiClient.SendRequest(httpRequestMessage);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var contentType = response.Content.Headers.ContentType?.CharSet;
                if (!string.IsNullOrEmpty(contentType) && contentType.Contains("\"utf-8\""))
                {
                    response.Content.Headers.ContentType.CharSet = "utf-8";
                }

                return response;
            },
            maxRetry,
            delayMilliseconds: 200,
            onRetry: (ex, attempt) =>
            {
                Console.WriteLine($"Attempt {attempt} failed. Error: {ex.Message}");
            });
        }

        private async Task<HttpResponseMessage> FetchResponseWithUtf8Check(string url)
        {
            var response = await _apiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var contentType = response.Content.Headers.ContentType?.CharSet;
                if (!string.IsNullOrEmpty(contentType) && contentType.Contains("\"utf-8\""))
                {
                    response.Content.Headers.ContentType.CharSet = "utf-8";
                }
            }

            return response;
        }

        private async Task<HttpResponseMessage> FetchResponseWithUtf8Check(string url, HttpContent content)
        {
            var response = await _apiClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var contentType = response.Content.Headers.ContentType?.CharSet;
                if (!string.IsNullOrEmpty(contentType) && contentType.Contains("\"utf-8\""))
                {
                    response.Content.Headers.ContentType.CharSet = "utf-8";
                }
            }

            return response;
        }

        private async Task<HttpResponseMessage> HandleCheckpoint(string url)
        {
            var response = await _apiClient.GetAsync(url);

            if (response.IsAutomationCheckpoint())
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                await ResolveCheckpointAutomate(responseContent);

                return await _apiClient.GetAsync(url);
            }

            return response;
        }
    }
}
