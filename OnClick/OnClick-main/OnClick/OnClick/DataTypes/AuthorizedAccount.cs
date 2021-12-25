using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class AuthorizedAccount : Account
    {
        //message classına isreport diye bir özellik ekledim. Mesaj bir advertü rapor etmekle ilgiliyse About kısmına report ya da message yazıyor(checkMailbox'ta).
        //checkMailbox'da düzenli görünsün diye designı düzenlemeye çalıştım.
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
            Console.WriteLine("------------Mail Box------------");
            
            foreach (Message message in messages)       
            {

                Console.WriteLine(messages.IndexOf(message)+"."+" From: "+Program.account.name+" About: ");
                if (message.isReport)
                {
                    Console.Write("Reporting an advert");
                }
                Console.WriteLine("Private message.");
                //Console.WriteLine(message.ToString());
            }                                                             
            Console.WriteLine("Enter the index of the message that you want to view in detail. ");
            int index = Convert.ToInt32(Console.ReadLine());
            ViewMessage(index);
            
        }                                                   //burda kaldım. Bitirdim sanki
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
        public void ViewMessage(int index)      //? Reply gibi özellik olacak mı

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
