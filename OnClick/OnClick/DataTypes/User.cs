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
            adverts = new List<Advert>();
        }

        public bool isBanned { get; set; }
        public List<Advert> adverts { get; set; }

        public void AddAdvert()
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            string phoneNumber = Console.ReadLine();
            bool isTradable = false;

            while (true)
            {
                Console.Write("Is the property tradable? Type 'yes' or 'no '. (to exit type 'exit')");
                string answer = Console.ReadLine();
                if (answer.Equals("exit", StringComparison.OrdinalIgnoreCase))
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
                break;
            }
            double price;
            while (true)
            {
                Console.Write("Enter price for the property.(to exit type'exit')");
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
                Console.Write("Enter product info:(to exit type'exit')");
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
                break;
            }
            PropertyType propertyType;
            int propertyInfo;
            while (true)
            {
                Console.WriteLine("Enter property type.");
                Console.WriteLine("1.For Renting.");
                Console.WriteLine("2.For sale");
                Console.WriteLine("3.To exit.");
                try
                {
                     propertyInfo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("You can only enter numbers 1-2-3.");
                    continue;
                }               
                switch (propertyInfo)
                {
                    case 1:
                        propertyType = PropertyType.FORRENT;
                        break;
                    case 2:
                        propertyType = PropertyType.FORSALE;
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have successfully gone back!");
                        Console.ResetColor();
                        Program.printSecondMenu();
                        return;
                    default:
                        Console.WriteLine("Enter numbers between 1-3.");
                        continue;
                }
                break;        
            }
            int propertyChoice, area;
            string address;
            
            while (true)
            {
                Console.WriteLine("Enter property type.");
                Console.WriteLine("Type 1 for 'Real-Estate'.");
                Console.WriteLine("Type 2 for 'Vehicle'.");
                Console.WriteLine("Type 3 to exit.");
                try
                {
                    propertyChoice = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("You can only enter numbers 1-2-3.");
                    continue;
                }
                break;
            }
            while (true)
            {
                switch (propertyChoice)
                {
                    case 1:
                        Console.Write("Enter address: (To exit type exit)");
                        address = Console.ReadLine();
                        if (address.Equals("exit"))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You have successfully exited.");
                            Console.ResetColor();
                            Program.printSecondMenu();
                            return;
                        }
                        while (true)
                        {
                            Console.Write("Enter area: (To exit type exit)");
                            string infoArea = Console.ReadLine();
                            if (infoArea.Equals("exit"))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You have successfully exited.");
                                Console.ResetColor();
                                Program.printSecondMenu();
                                return;
                            }
                            try
                            {
                                area = Convert.ToInt32(infoArea);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input.");
                                continue;
                            }
                            break;
                        }
                        int heatingChoice;
                        HeatingSystem heatingSystem;
                        while (true)
                        {
                            Console.WriteLine("Enter heating system numbers between 1-9");
                            Console.WriteLine("1.Natural Gas");
                            Console.WriteLine("2.Stove");
                            Console.WriteLine("3.Floorheater");
                            Console.WriteLine("4.Centric");
                            Console.WriteLine("5.Air conditioning");
                            Console.WriteLine("6.Solar Energy");
                            Console.WriteLine("7.Geothermal");
                            Console.WriteLine("8.Fire Place");
                            Console.WriteLine("9.Heat Pump");
                            Console.WriteLine("10.Exit to adding advert process.");
                            try
                            {
                                heatingChoice = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input.");
                                continue;
                            }
                            switch (heatingChoice)
                            {
                                case 1:
                                    heatingSystem = HeatingSystem.NATURALGAS;
                                    break;
                                case 2:
                                    heatingSystem = HeatingSystem.STOVE;
                                    break;
                                case 3:
                                    heatingSystem = HeatingSystem.FLOORHEATER;
                                    break;
                                case 4:
                                    heatingSystem = HeatingSystem.CENTRIC;
                                    break;
                                case 5:
                                    heatingSystem = HeatingSystem.AIRCONDITIONING;
                                    break;
                                case 6:
                                    heatingSystem = HeatingSystem.SOLARENERGY;
                                    break;
                                case 7:
                                    heatingSystem = HeatingSystem.GEOTHERMAL;
                                    break;
                                case 8:
                                    heatingSystem = HeatingSystem.FIREPLACE;
                                    break;
                                case 9:
                                    heatingSystem = HeatingSystem.HEATPUMP;
                                    break;
                                case 10:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("You have successfully exited.");
                                    Console.ResetColor();
                                    Program.printSecondMenu();
                                    return;
                                default:
                                    Console.WriteLine("Please enter numbers between 1-10.");
                                    continue;
                            }
                            break;
                        }

                        string input;
                        int numberOfRooms;
                        while (true)
                        {

                            Console.Write("Enter number of rooms: (To exit type exit) ");
                            input = Console.ReadLine();
                            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You have successfully exited.");
                                Console.ResetColor();
                                Program.printSecondMenu();
                                return;
                            }
                            try
                            {
                                numberOfRooms = Convert.ToInt32(input);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input");
                                continue;
                            }
                            break;
                        }

                        Advert advert = new Advert();
                        advert.title = title;
                        advert.isWarned = false;
                        advert.isAvailable = true;
                        advert.phoneNumber = phoneNumber;
                        advert.releaseDate = DateTime.Now;
                        advert.user = (User)Program.account;
                        RealEstateProperty product = new RealEstateProperty();
                        product.address = address;
                        product.roomNumber = numberOfRooms;
                        product.price = price;
                        product.isTradable = isTradable;
                        product.info = info;
                        product.area = area;
                        product.propertyType = propertyType;
                        product.heatingSystem = heatingSystem;
                        advert.product = product;
                        adverts.Add(advert);
                        break;
                    case 2:
                        string brand;
                        Console.Write("Enter brand: (To exit type exit) ");
                        brand = Console.ReadLine();
                        if (brand.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You have successfully exited.");
                            Console.ResetColor();
                            Program.printSecondMenu();
                            return;
                        }
                        Console.Write("Enter color: (To exit type exit)");
                        string color = Console.ReadLine();
                        if (brand.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You have successfully exited.");
                            Console.ResetColor();
                            Program.printSecondMenu();
                            return;
                        }
                        int engineVolume;
                        while (true)
                        {
                            string answer;
                            Console.Write("Enter engine volume: (To exit type exit) ");
                            answer = Console.ReadLine();
                            if (answer.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You have successfully exited.");
                                Console.ResetColor();
                                Program.printSecondMenu();
                                return;
                            }
                            try
                            {
                                engineVolume = Convert.ToInt32(answer);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input.");
                                continue;
                            }
                            break;
                        }
                        double fuelConsumption;
                        while (true)
                        {
                            Console.Write("Enter fuel consumption.(To exit type exit)");
                            string answer = Console.ReadLine();

                            if (answer.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You have successfully exited.");
                                Console.ResetColor();
                                Program.printSecondMenu();
                                return;
                            }
                            try
                            {
                                fuelConsumption = Convert.ToDouble(answer);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input.");
                                continue;
                            }
                            break;
                        }
                        FuelType fuelType;
                        int fuelChoice;
                        while (true)
                        {
                            Console.WriteLine("Enter fuel type: ");
                            Console.WriteLine("1.Electricity");
                            Console.WriteLine("2.Diesel");
                            Console.WriteLine("3.Gasoline");
                            Console.WriteLine("4.LPG");
                            Console.WriteLine("5.To exit");
                            try
                            {
                                fuelChoice = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input.");
                                continue;
                            }
                            switch (fuelChoice)
                            {
                                case 1:
                                    fuelType = FuelType.ELECTRICITY;
                                    break;
                                case 2:
                                    fuelType = FuelType.DIESEL;
                                    break;
                                case 3:
                                    fuelType = FuelType.GASOLINE;
                                    break;
                                case 4:
                                    fuelType = FuelType.LPG;
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("You have successfully gone back!");
                                    Console.ResetColor();
                                    Program.printSecondMenu();
                                    return;
                                default:
                                    Console.WriteLine("Please enter a valid input.");
                                    continue;
                            }
                            break;
                        }
                        int kilometers;
                        while (true)
                        {
                            Console.Write("Enter kilometers: (To exit type exit)");
                            string answer = Console.ReadLine();

                            if (answer.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You have successfully exited.");
                                Console.ResetColor();
                                Program.printSecondMenu();
                                return;
                            }

                            try
                            {
                                kilometers = Convert.ToInt32(answer);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input");
                                continue;
                            }
                            break;
                        }
                        int modelYear;
                        while (true)
                        {
                            Console.Write("Enter model year: (To exit type 'exit')");
                            string answer = Console.ReadLine();
                            if (answer.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You have successfully exited.");
                                Console.ResetColor();
                                Program.printSecondMenu();
                                return;
                            }
                            try
                            {
                                modelYear = Convert.ToInt32(answer);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid input");
                                continue;
                            }
                            break;
                        }
                        Shifter shifter;
                        while (true)
                        {
                            Console.WriteLine("Enter shifter type:");
                            Console.WriteLine("1.Automatic.");
                            Console.WriteLine("2.Half Automatic.");
                            Console.WriteLine("3.Manual.");
                            Console.WriteLine("4.To exit.");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    shifter = Shifter.AUTOMATIC;
                                    break;
                                case 2:
                                    shifter = Shifter.HALFAUTOMATIC;
                                    break;
                                case 3:
                                    shifter = Shifter.MANUAL;
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("You have successfully gone back!");
                                    Console.ResetColor();
                                    Program.printSecondMenu();
                                    return;
                                default:
                                    Console.WriteLine("Enter a valid input");
                                    continue;
                            }
                            break;
                        }
                        VehicleType vehicleType;
                        while (true)
                        {
                            Console.WriteLine("Enter vehicle type: ");
                            Console.WriteLine("1.SUV");
                            Console.WriteLine("2.Sedan");
                            Console.WriteLine("3.Hatchback");
                            Console.WriteLine("4.Pick-up");
                            Console.WriteLine("5.To exit");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    vehicleType = VehicleType.SUV;
                                    break;
                                case 2:
                                    vehicleType = VehicleType.SEDAN;
                                    break;
                                case 3:
                                    vehicleType = VehicleType.HATCHBACK;
                                    break;
                                case 4:
                                    vehicleType = VehicleType.PICKUP;
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("You have successfully gone back!");
                                    Console.ResetColor();
                                    Program.printSecondMenu();
                                    return;
                                default:
                                    Console.WriteLine("Enter a valid input");
                                    continue;
                            }
                            break;
                        }
                        Advert advert1 = new Advert();
                        advert1.title = title;
                        advert1.isWarned = false;
                        advert1.isAvailable = true;
                        advert1.phoneNumber = phoneNumber;
                        advert1.releaseDate = DateTime.Now;
                        advert1.user = (User)Program.account;
                        Vehicle product1 = new Vehicle();
                        product1.info = info;
                        product1.isTradable = isTradable;
                        product1.price = price;
                        product1.propertyType = propertyType;

                        product1.brand = brand;
                        product1.color = color;
                        product1.engineVolume = engineVolume;
                        product1.fuelConsumption = fuelConsumption;
                        product1.fuelType = fuelType;
                        product1.kilometers = kilometers;
                        product1.modelYear = modelYear;
                        product1.shifter = shifter;
                        product1.type = vehicleType;
                        advert1.product = product1;
                        adverts.Add(advert1);
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have successfully exit!");
                        Console.ResetColor();
                        Program.printSecondMenu();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter numbers between 1-3.");
                        continue;
                }
                break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have successfully added advert!");
            Console.ResetColor();
            Program.printSecondMenu();
            return;

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
            Advert.adverts.Remove(adverts[choice - 1]);
            adverts.Remove(adverts[choice - 1]);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have successfully removed advert!");
            Console.ResetColor();
            Program.printSecondMenu();
            return;
        }

        public void UpdateAdvert()
        {
            Console.Clear();
            int counter = 1;
            foreach (Advert x in adverts)
                Console.WriteLine("" + counter++ + ". " + x.title);
            Console.Write("Enter index you want to update(to go back type 'back') :");
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
            if (choice <= 0 || choice > adverts.Count)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such an index");
                Console.ResetColor();
                removeAdvert();
                return;
            }
            Advert advert = adverts[choice - 1];
            Console.WriteLine("1.Change title\n" +
                "2.Change price\n" +
                "3.Change information");
            Console.ReadLine();
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
                UpdateAdvert();
                return;
            }
            switch (choice){
                case 1:
                    Console.Write("Enter the new title : ");
                    string title = Console.ReadLine();
                    advert.title = title;
                    break;
                case 2:
                    Console.Write("Enter the new price : ");
                    int price = 0;
                    try
                    {
                       price = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can only enter numbers");
                        Console.ResetColor();
                        UpdateAdvert();
                        return;
                    }
                    advert.product.price = price;
                    break;
                case 3:
                    Console.Write("Enter the new information : ");
                    string info = Console.ReadLine();
                    advert.product.info = info;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter numbers between 1-3.");
                    UpdateAdvert();
                    return;
            }
            Console.Clear();
            if (advert.isWarned)
            {
                Message message = new Message();
                Report report = new Report();
                string reportInfo = "I updated my advert";
                report.info = reportInfo;
                report.Advert = advert;
                message.Report = report;
                message.isRead = false;
                message.isReport = false;
                Console.WriteLine("This report will be sent to admins to check.");
                foreach (Admin x in getAllAdmins())
                {
                    x.messages.Add(message);
                }
            }
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have successfully updated advert!");
            Console.ResetColor();
            Program.printSecondMenu();
            return;
        }
    }
}
