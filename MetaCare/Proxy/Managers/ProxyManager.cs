using MetaCare.Proxy.Services;
using System.Collections.Generic;
using System.Linq;

namespace MetaCare.Proxy.Managers
{
    public class ProxyManager
    {
        private List<ProxyService> proxyServices;
        private readonly object lock_StartProxy = new object();

        public ProxyManager(List<ProxyService> proxies)
        {
            proxyServices = proxies;
        }

        public ProxyService GetAvailableProxy()
        {
            lock (lock_StartProxy)
            {
                return proxyServices
                    .Where(p => p.TryAcquireProxy())
                    .FirstOrDefault();
            }
        }

        public void ReleaseProxy(ProxyService proxyService)
        {
            proxyService.ReleaseProxy();
        }
    }
}
