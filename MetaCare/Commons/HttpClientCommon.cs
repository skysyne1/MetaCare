using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MetaCare.Commons
{
    public static class HttpClientCommon
    {
        public static void SetDefaultHeader(this HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
            client.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            client.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
            client.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            client.DefaultRequestHeaders.Add("sec-fetch-mobile", "?0");
            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "1");
            client.DefaultRequestHeaders.Add("upgrade-insecure-requests", "\"Windows\"");
            client.DefaultRequestHeaders.Add("cache-control", "max-age=0");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-GB,en;q=0.9,en-US;q=0.8");
        }

        public static Task<string> CookieToString(this CookieContainer cookieContainer, string website)
        {
            return Task.Run(() =>
            {
                var cookies = cookieContainer.GetCookies(new System.Uri(website));
                var cookieString = string.Empty;
                foreach (Cookie cookie in cookies)
                {
                    cookieString += $"{cookie.Name}={cookie.Value}; ";
                }
                return cookieString;
            });
        }

        public static bool IsAutomationCheckpoint(this HttpResponseMessage response)
        {
            if (response.RequestMessage.RequestUri.AbsolutePath == "/checkpoint/601051028565049/")
            {
                return true;
            }
            return false;
        }

        public static async Task<HttpResponseMessage> SendRequest(this HttpClient httpClient, HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await httpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
        }

    }
}
