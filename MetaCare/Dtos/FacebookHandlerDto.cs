using Leaf.xNet;

namespace MetaCare.Dtos
{
    public class FacebookHandlerDto
    {
        public int TypeLogin { get; set; }

        public bool IsLoggedIn { get; set; } = false;

        public AccountDto Account { get; set; }

        public ApiClient ApiClient { get; set; }
    }
}
