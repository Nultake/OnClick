using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class AuthorizedAccount : Account
    {
        public string userName { get; set; }
        public string password { get; set; }
        public List<Message> messages { get; set; }

        public static List<AuthorizedAccount> accounts = new List<AuthorizedAccount>();

        public AuthorizedAccount(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            accounts.Add(this);
        }

        public AuthorizedAccount()
        {
            accounts.Add(this);
        }

        public void checkMailBox()
        {

        }
        public void logOut()
        {

        }
        public void removeAdvert()
        {

        }
        public void updateProfile()
        {

        }
        public void ViewMessage(int index)
        {

        }

    }
}
