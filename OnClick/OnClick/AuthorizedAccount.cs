using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    internal class AuthorizedAccount : Account
    {
        public string userName { get; set; }
        public string password { get; set; }
        public static List<AuthorizedAccount> authorizedUsers = new List<AuthorizedAccount>();

        public AuthorizedAccount(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
