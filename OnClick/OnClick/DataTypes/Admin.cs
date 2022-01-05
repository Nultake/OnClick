using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Admin : AuthorizedAccount
    {
        public Admin() : base()
        {
        }

        public void ApproveWarnAdvert(Advert advert,Report report)
        {
            Console.WriteLine("1.Approve changes!\n" +
                "2.Decline changes");
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
                ApproveWarnAdvert(advert,report);
                return;
            }
            if (choice == 1)
            {
                advert.isWarned = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Advert has been added");
                Console.ResetColor();
                Program.printSecondMenu();
                return;
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Report has been declined and message will be sent to owner of advert");
                Console.ResetColor();
                Message message = new Message();
                message.Report = report;
                message.isRead = false;
                message.from = ((Admin)Program.account).userName;
                advert.user.messages.Add(message);
                Program.printSecondMenu();
                return;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an input");
                Console.ResetColor();
                return;
            }
        }  
        public void Ban(User user)
        {
            user.isBanned = true;
        }
        public void PromoteToAdmin(User account)
        {
            Admin admin = new Admin();
            admin.userName = account.userName;
            admin.password = account.password;
            admin.messages = account.messages;
            AuthorizedAccount.accounts.Remove(account);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Promotion procces successful!");
            Console.ResetColor();
            Program.printSecondMenu();
        }

        public override void removeAdvert()
        {
            Console.Clear();
            int counter = 1;
            foreach (Advert x in Advert.adverts)
                Console.WriteLine("" + counter++ + ". " + x.title);
            Console.Write("Enter index you want to remove(to go back type 'back') :");
            string answer = Console.ReadLine();
            if (answer.Equals("back"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You have successfully gone back!");
                Console.ResetColor();
                Program.printSecondMenu();
                return;
            }
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(answer);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can only enter numbers");
                Console.ResetColor();
                removeAdvert();
                return;
            }
            if (choice <= 0 || choice > Advert.adverts.Count)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an index");
                Console.ResetColor();
                removeAdvert();
                return;
            }
            Advert advert = Advert.adverts[choice - 1];
            Advert.adverts.Remove(advert);
            advert.user.adverts.Remove(advert);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have successfully removed advert!");
            Console.ResetColor();
            Program.printSecondMenu();
            return;
        }

        public void WarnAdvert(Advert advert,Report report)      
        {
            Console.WriteLine("1. Accept report!\n" +
                "2.Decline report");
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
                WarnAdvert(advert,report);
                return;
            }
            if (choice == 1)
            {
                advert.isWarned = true;
                Message message = new Message();
                message.Report = report;
                message.isRead = false;
                message.from = ((Admin)Program.account).userName;
                advert.user.messages.Add(message);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Advert has been removed and message will be sent to owner of advert to edit");
                Console.ResetColor();
                Program.printSecondMenu();
                return;
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Report has been declined");
                Console.ResetColor();
                Program.printSecondMenu();
                return;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an input");
                Console.ResetColor();
                WarnAdvert(advert,report);
                return;
            }
        }
    }
}
