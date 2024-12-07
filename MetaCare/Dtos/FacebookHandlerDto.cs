using Leaf.xNet;

namespace MetaCare.Dtos
{
    public class FacebookHandlerDto
    {
        public int TypeLogin { get; set; }

        public AccountDto Account { get; set; }

        public ApiClient ApiClient { get; set; }
    }
}
