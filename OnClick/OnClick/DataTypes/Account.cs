
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Account
    {
        public static int counter = 0;
        public string name { get; set; }

        public Account()
        {

        }
        public void listAdvert()
        {
            if (Advert.adverts.Count == 0)
            {
                throw new AdvertListEmptyException("There are no adverts to display.");
            }
            List<int> indexes = new List<int>();             //List to give indexes to adverts.
            foreach(Advert advert in Advert.adverts)
            {
                if (advert.isAvailable && !advert.isWarned)
                {
                    indexes.Add(Advert.adverts.IndexOf(advert));
                    Console.WriteLine(indexes.Count + "." + advert.title);
                }
            }
            Console.Write("Enter the index of the advert you want to view the details of : (To go back press -1) ");
            int choiceIndex = Convert.ToInt32(Console.ReadLine());
            if (choiceIndex == -1)
            {
                Program.printSecondMenu();
                return;
            }
            if (choiceIndex > indexes.Count)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an index in list");
                Console.ResetColor();
                listAdvert();
                return;
            }
            viewAdvert(choiceIndex-1,indexes);
        }

        public void reportAdvert(Advert advert)
        {
            Message message = new Message();
            Report report = new Report();

            Console.Clear();
            Console.WriteLine("Enter the report cause: ");
            string reportInfo = Console.ReadLine();
            Console.WriteLine("This report will be sent to admins to check.");
            report.info = reportInfo;
            report.Advert = advert;
            message.Report = report;
            message.isRead = false;
            foreach(Admin admin in AuthorizedAccount.getAllAdmins())
            {
                admin.messages.Add(message);
            }
            listAdvert();
            return;
        }

        public void viewAdvert(int index,List<int> indexes)
        {
            Advert advert = Advert.adverts[indexes[index]];
            Console.WriteLine(advert.ToString());         
            Console.WriteLine("1.Report Advert");
            Console.WriteLine("2.Go back");
            int choiceIndex = Convert.ToInt32(Console.ReadLine());

            if(choiceIndex == 1)
            {
                reportAdvert(advert);
                return;
            }
            else if(choiceIndex == 2)
            {
                Program.printSecondMenu();
                return;
            }
            else
            {
                throw new IndexNotFoundException("Please enter a valid number.(1/2)");
            }

        }
    }
}
