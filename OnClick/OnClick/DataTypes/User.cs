using OnClick.DataTypes;
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

        public void AddAdvert()
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            bool isTradable = false;
            while (true)
            {
                Console.WriteLine("Is this property tradable? Type 'yes' or 'no'.(to exit type'exit')");
                string answer = Console.ReadLine();
                if (answer.Equals("exit"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have successfully gone back!");
                    Console.ResetColor();
                    Program.printSecondMenu();
                    return;
                }
                else if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    isTradable = true;
                else if (answer.Equals("no", StringComparison.OrdinalIgnoreCase))
                    isTradable = false;
                else
                {
                    Console.WriteLine("Please type a valid answer");
                    continue;
                }
            }
            double price;
            while (true)
            {
                Console.WriteLine("Enter price for the property.(to exit type'exit')");
                string answer = Console.ReadLine();
                if (answer.Equals("exit"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have successfully gone back!");
                    Console.ResetColor();
                    Program.printSecondMenu();
                    return;
                }
                try
                {
                    price = Convert.ToDouble(answer);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only enter numbers");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            string info;
            while (true)
            {
                Console.WriteLine("Enter product info:(to exit type'exit')");
                info = Console.ReadLine();
                if (info.Equals("exit"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have successfully gone back!");
                    Console.ResetColor();
                    Program.printSecondMenu();
                    return;
                }       
            }
            
            FuelType fuelType;
            HeatingSystem heatingSystem;
            Shifter shifterType;
            VehicleType vehicleType;
            string address, brand, color;
            int area, numberOfRoom, engineVolume, kilometer, modelYear;
            double fuelConsumption;

            while (true)
            {
                Console.WriteLine("Enter property type.");
                Console.WriteLine("Type 1 for 'Real-Estate'.");
                Console.WriteLine("Type 2 for 'Vehicle'.");
                Console.WriteLine("Type 3 to exit.");
                try
                {
                    int propertyChoice = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("You can only enter numbers 1-2-3.");
                    continue;
                }
                break;
            }                     
            switch (propertyChoice)
            {  
                case 1:
                    while (true)
                    {
                        Console.WriteLine("Enter address:(to exit type'exit')");
                        address = Console.ReadLine();
                        if (info.Equals("exit"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You have successfully gone back!");
                            Console.ResetColor();
                            Program.printSecondMenu();
                            return;
                        }                                        
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter area: ");
                        try
                        {
                            area = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter heating system (Natural gas,stove,floorheater,centric,air conditioning,solar energy,geothermak,fireplace,heat pump)");
                        Console.WriteLine("1.Natural Gas");
                        Console.WriteLine("2.Stove");
                        Console.WriteLine("3.Floorheater");
                        Console.WriteLine("4.Centric");
                        Console.WriteLine("5.Air conditioning");
                        Console.WriteLine("6.Solar Energy");
                        Console.WriteLine("7.Geothermal");
                        Console.WriteLine("8.Fire Place");
                        Console.WriteLine("9.Heat Pump");



                        try
                        {
                            heatingSystem = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter number of room: ");
                        try
                        {
                            numberOfRoom = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    break;
                case 2:
                    while (true)
                    {

                        Console.WriteLine("Enter brand: ");
                        try
                        {
                            brand = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter color: ");
                        try
                        {
                            color = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter engine volume: ");
                        try
                        {
                            engineVolume = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter fuel consumption: ");
                        try
                        {
                            fuelConsumption = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {
                        
                        Console.WriteLine("Enter fuel type: ");
                        Console.WriteLine("1.Electricity");
                        Console.WriteLine("2.Diesel");
                        Console.WriteLine("3.Gasoline");
                        Console.WriteLine("4.LPG");
                        Console.WriteLine("Enter ");

                        switch ()

                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter kilometers: ");
                        try
                        {
                            kilometer = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter model year");
                        try
                        {
                            modelYear = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter type of shifter (automatic,half automatic,manual)");
                        try
                        {
                            shifterType = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {

                        Console.WriteLine("Enter type of the vehicle: (SUV, sedan, hatchback, pick-up).");
                        try
                        {
                            vehicleType = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            continue;
                        }
                        break;
                    }
                    Advert advert = new Advert();
                    Vehicle product = new Vehicle();
                    advert.title = title;
                    advert.isWarned = false;
                    advert.isAvailable = true;
                    advert.phoneNumber = phoneNumber;
                    advert.releaseDate = DateTime.Now;
                    advert.product = product;
                    advert.product.info=product.info;
                    advert.product.isTradable = isTradable;
                    advert.product.price = price;
                    advert.product.propertyType = PropertyType;
                    ((Vehicle)advert.product).brand = brand;
                    ((Vehicle)advert.product).color = color;
                    ((Vehicle)advert.product).engineVolume = engineVolume;
                    ((Vehicle)advert.product).fuelConsumption = fuelConsumption;
                    ((Vehicle)advert.product).fueltype



                    
                    adverts.Add(advert);
                    break;
            }     
        }
        public override void removeAdvert()
        {
            Console.Clear();
            int counter=1;
            foreach(Advert x in adverts)
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
            if (choice <=0 || choice > adverts.Count)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an index");
                Console.ResetColor();
                removeAdvert();
                return;
            }
            adverts.Remove(adverts[choice - 1]);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have successfully removed advert!");
            Console.ResetColor();
            Program.printSecondMenu();
            return;
        }

        public void UpdateAdvert(Advert advert)
        {
            throw new NotImplementedException();
        }
    }
}
