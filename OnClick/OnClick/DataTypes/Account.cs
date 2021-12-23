using OnClick.Exceptions;
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
            if (Advert.adverts == null)
            {
                throw new AdvertListEmptyException("There are no adverts to display.");
            }
            List<int> indexes = new List<int>();
            foreach(Advert advert in Advert.adverts)
            {
                if (advert.isAvailable && !advert.isWarned)
                {
                    indexes.Add(Advert.adverts.IndexOf(advert));
                    Console.WriteLine(indexes.Count + "." + advert.title);
                }
            }
            Console.Write("Enter the index of the advert you want to view the details of : ");

        }
        public void reportAdvert()
        {
            
        }
        public void viewAdvert(int index)
        {                       
            

        }

    }
}
