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
            else
            {
                Console.WriteLine("------------Mail Box------------");

                foreach (Message message in messages)
                {
                    Console.WriteLine((messages.IndexOf(message) + 1) + "." + " From: " + Program.account.name + " About: "
                        + message.Report.Advert.title);
                }
                Console.WriteLine("Enter the index of the message that you want to view in detail. ");
                int index = Convert.ToInt32(Console.ReadLine());
                ViewMessage(index);
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
        public void ViewMessage(int index)      //? Warn kısmına bağlancak.
        {
            Message message1 = messages.ElementAt(index);
            Console.WriteLine(message1.ToString());
            Program.printSecondMenu();                      //hangi menüyü bastırcağından tam emin değilim yanlış olabilir
            return;
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
