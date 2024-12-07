using MetaCare.Dtos;
using System.Collections.Generic;

namespace MetaCare.Containers
{
    public class FacebookContainer
    {
        private static FacebookContainer _instance;

        private static readonly object _instanceLock = new object();

        public List<FacebookHandlerDto> FacebookHandlers { get; private set; }

        private FacebookContainer()
        {
            FacebookHandlers = new List<FacebookHandlerDto>();
        }

        public static FacebookContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new FacebookContainer();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
