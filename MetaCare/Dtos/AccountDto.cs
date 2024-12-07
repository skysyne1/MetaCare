using System.Collections.Generic;

namespace MetaCare.Dtos
{
    public class AccountDto
    {
        public string Uid { get; set; }

        public string Password { get; set; }

        public string Key2Fa {  get; set; }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set => _name = value ?? string.Empty;
        }

        public string Cookies { get; set; }

        public string TokenEAAG { get; set; }

        public string DTSGToken { get; set; }

        public List<AdAccountDto> AdAccounts { get; set; }
    }
}
