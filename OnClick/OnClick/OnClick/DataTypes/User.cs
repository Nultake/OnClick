using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class User : AuthorizedAccount
    {
        public User() : base()
        {
        }

        public bool isBanned { get; set; }
        public List<Advert> adverts { get; set; }
        public void AddAdvert(Advert advert)

        {
            Console.WriteLine("Enter title: ");
            Console.WriteLine("Enter phone number: ");
            //release date
            Console.WriteLine("Is this property tradable?");
            Console.WriteLine("Enter price for the property.");
            int choice;
            while (true) {

                Console.WriteLine("Enter property type.");
                Console.WriteLine("Type 1 for 'Real-Estate'.");
                Console.WriteLine("Type 2 for 'Vehicle'.");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("You can only enter numbers");
                    continue;
                }
                break;
            }
            if (choice == 1)    //switch case yap
            {
                Console.WriteLine("Enter address: ");
                Console.WriteLine("Enter area: ");
                Console.WriteLine("Enter heating system (Natural gas,stove,floorheater,centric,air conditioning,solar energy,geothermak,fireplace,heat pump)");
                Console.WriteLine("Enter number of room: ");
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter brand: ");
                Console.WriteLine("Enter color: ");
                Console.WriteLine("Enter engine volume: ");
                Console.WriteLine("Enter fuel consumption: ");
                Console.WriteLine("Enter fuel type: ");
                Console.WriteLine("Enter kilometers: ");
                Console.WriteLine("Enter model year");
                Console.WriteLine("Enter type of shifter (automatic,half automatic,manual)");
                Console.WriteLine("Enter type of the vehicle: (SUV, sedan, hatchback, pick-up).");
            }          
        }     
        public void UpdateAdvert(Advert advert)
        {
            
        }
    }
}
