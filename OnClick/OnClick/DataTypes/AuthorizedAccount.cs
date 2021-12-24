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
            this.messages = new List<Message>();
            accounts.Add(this);
        }

        public AuthorizedAccount()
        {
            this.messages = new List<Message>();
            accounts.Add(this);
        }

        public void checkMailBox()
        {
            if (messages.Count == 0)
            {
                Console.WriteLine("You have no messages to display.");
            }
            foreach (Message message in messages)       //burda kaldım.
            {
                Console.WriteLine(message.ToString());
            }

        }
        public void logOut()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("successfully logged out!");
            Program.account = new NonAuthorizedAccount();
            Console.ResetColor();
            Program.printFirstMenu();

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

        public static AuthorizedAccount GetAuthorizedAccountByUsername(string username)
        {

            foreach (AuthorizedAccount account in accounts)
            {
                if (account.userName == username)
                    return account;
            }
            throw new UsernameDoesNotExistException(username + " does not exist!");
        }

        public static List<Admin> getAllAdmins()
        {
            List<Admin> list = new List<Admin>();
            foreach(AuthorizedAccount account in accounts)
            {
                if (account is Admin)
                {
                    list.Add((Admin)account);
                }
            }
            return list;
        }

    }
}
