using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public abstract class AuthorizedAccount : Account
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
        abstract public void removeAdvert();
        public void updateProfile()
        {
            Console.Clear();
            Console.Write("Enter your passord to continue changing password : ");
            string password = Console.ReadLine();
            if (!(((AuthorizedAccount)Program.account).password.Equals(password)))
            {
                throw new PasswordDoesNotMatchException("Your password is incorrect");
            }
            else
            {
                Console.Write("Enter new password : ");
                string newPassword = Console.ReadLine();
                Console.Write("Enter new password again :");
                string repeatPassword = Console.ReadLine();
                if (repeatPassword.Equals(newPassword))
                {
                    ((AuthorizedAccount)Program.account).password = newPassword;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Password successfully changed!");
                    Console.ResetColor();
                    Program.printSecondMenu();
                    return;
                }else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Passwords do not match!");
                    Console.ResetColor();
                    Program.printSecondMenu();
                    return;
                }
            }


        }
        public void ViewMessage(int index)
        {
            Message message = messages[index];
            Console.WriteLine(message.ToString());
            message.isRead = true;
            if (this is Admin)
            {
                Admin admin = (Admin)this;
                if (message.isReport)
                {
                    admin.WarnAdvert(message.Report.Advert,message.Report);
                    return;
                }
                admin.ApproveWarnAdvert(message.Report.Advert,message.Report);
                return;
            }
            Console.WriteLine("Your advert has been removed from list beacuse of mentioned reason\n" +
                "To make it available again edit your advert properly\n" +
                "1.Update Advert\n" +
                "2.Exit");
            Console.Write("You choice : ");
            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can only enter numbers");
                Console.ResetColor();
                ViewMessage(index);
                return;
            }
            if (choice == 1)
            {
            ((User)Program.account).UpdateAdvert(message.Report.Advert);
                return;
            }else if (choice == 2)
            {
                Program.printSecondMenu();
                return;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an input");
                Console.ResetColor();
                ViewMessage(index);
                return;
            }
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
