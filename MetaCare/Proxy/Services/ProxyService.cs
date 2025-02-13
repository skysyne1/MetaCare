using Leaf.xNet;
using Newtonsoft.Json.Linq;
using System;

namespace MetaCare.Proxy.Services
{
    public class ProxyService
    {
        public string Proxy { get; set; }
        public string ApiKey { get; set; }
        public int TypeProxy { get; set; }
        public int LimitThreadUse { get; private set; }

        private int currentUsage = 0;
        private DateTime? firstExecutionTime = null;
        private readonly object lockObj = new object();

        public ProxyService(string proxy, string apiKey, int typeProxy, int limitThreadUse = 3)
        {
            Proxy = proxy;
            ApiKey = apiKey;
            TypeProxy = typeProxy;
            LimitThreadUse = limitThreadUse;
        }

        public bool TryAcquireProxy()
        {
            lock (lockObj)
            {
                if (currentUsage < LimitThreadUse)
                {
                    currentUsage++;
                    return true;
                }
                return false;
            }
        }

        public void ReleaseProxy()
        {
            lock (lockObj)
            {
                if (currentUsage > 0)
                {
                    currentUsage--;
                }
            }
        }

        public bool ResetProxy()
        {
            lock (lockObj)
            {
                if (firstExecutionTime == null || (DateTime.Now - firstExecutionTime.Value).TotalMinutes >= 1)
                {
                    firstExecutionTime = DateTime.Now;
                    if (TypeProxy == 1) // TypeProxy == 1: ProxyMKVN
                    {
                        return ResetProxyWWProxy();
                    }
                    else if (TypeProxy == 2) // TypeProxy == 2: ProxyV6
                    {
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private bool ResetProxyWWProxy()
        {
            var result = false;
            var httpRequest = new HttpRequest();
            try
            {
                var response = httpRequest.Get($"https://wwproxy.com/api/client/proxy/available?key={ApiKey}&provinceId=-1");
                var responseStr = response?.ToString();
                Proxy = JObject.Parse(responseStr)["data"]["proxy"].ToString();
                result = true;
            }
            catch
            {
                // Xử lý ngoại lệ nếu cần
            }
            return result;
        }
    }
}
