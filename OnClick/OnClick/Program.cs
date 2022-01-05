using System;

namespace OnClick
{
    public class Program
    {
        public static Account account;
        static void Main(string[] args)
        {
            Admin baseAdmin = new Admin();
            baseAdmin.userName = "admin";
            baseAdmin.password = "admin";
            account = new NonAuthorizedAccount();
            printFirstMenu();
            return;    
        }
        public static void printSecondMenu()
        {
            println("1.List Adverts");
            if (account is not Guest)
            {
                println("2.Check Mailbox");
                println("3.Remove Advert");
                println("4.Update Profile");
                println("5.Log Out");
            }else
            {
                println("2.Go To Main Menu");
            }
            if (account is User)
            {
                println("6.Add Advert");
                println("7.Update Advert");
            }
            if (account is Admin)
            {
                println("6.Ban Player");
                println("7.Promote Player To Admin");
            }
            print("Enter Your Choice : ");
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(read());
            }catch(Exception)
            {
                clear();
                println("You can only enter numbers");
                printSecondMenu();
                return;
            }
            {
                switch (choice)
                {
                    case 1:
                        try
                        {
                            account.listAdvert();
                        }catch(AdvertListEmptyException e)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            println("Listing advert procces failed reasoned by : " + e.Message);
                            Console.ResetColor();
                            printSecondMenu();
                            return;
                        }
                        break;
                    default:
                        if (account is not Guest)
                        {
                            switch (choice)
                            {
                                case 2:
                                    ((AuthorizedAccount) account).checkMailBox();
                                    return;
                                case 3:
                                    ((AuthorizedAccount) account).removeAdvert();
                                    return;
                                case 4:
                                    try
                                    {
                                        ((AuthorizedAccount)account).updateProfile();
                                    }
                                    catch (PasswordDoesNotMatchException e)
                                    {
                                        clear();
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        println("You could not login reasoned by : " + e.Message);
                                        Console.ResetColor();
                                        printFirstMenu();
                                    }
                                    break;
                                case 5:
                                    ((AuthorizedAccount) account).logOut();
                                    break;
                                case 6:
                                    if (account is User)
                                        printAddAdvertMenu();
                                    else
                                        printBanPlayerMenu();
                                    return;
                                case 7:
                                    if (account is Admin)
                                        printPromoteMenu();
                                    if (account is User)
                                        ((User)account).UpdateAdvert();
                                    return;
                                default:
                                    clear();
                                    println("You can only enter (1-2-3-4-5-6-7)");
                                    printSecondMenu();
                                    return;
                            }
                        }
                        else
                        {
                            switch (choice)
                            {
                                case 2:
                                    account = new NonAuthorizedAccount();
                                    Console.Clear();
                                    printFirstMenu();
                                    return;
                                default:
                                    clear();
                                    println("You can only enter (1-2)");
                                    printSecondMenu();
                                    return;

                            }
                        }
                        clear();
                        println("You can only enter 1");
                        printSecondMenu();
                        return;
                }
            }
        }
        public static void printAddAdvertMenu()
        {
            ((User)account).AddAdvert();
        }
        public static void printBanPlayerMenu()
        {
            clear();
            print("Enter username that you want to ban :");
            string username = read();
            AuthorizedAccount accountt = null;
            try
            {
                accountt = AuthorizedAccount.GetAuthorizedAccountByUsername(username);
            }
            catch (UsernameDoesNotExistException e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                println("Banning procces failed reasoned by : " + e.Message);
                Console.ResetColor();
                printSecondMenu();
                return;
            }
            if (accountt is Admin)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                println("Banning procces failed reasoned by : Account is an admin account");
                Console.ResetColor();
                printSecondMenu();
                return;
            }
            ((Admin)account).Ban((User)accountt);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            println("Banning procces successful!");
            Console.ResetColor();
            printSecondMenu();
        }
        public static void printPromoteMenu()
        {
            clear();
            print("Enter username that you want to promote admin : ");
            string username = read();
            AuthorizedAccount targetAccount = null;
            try
            {
                targetAccount = AuthorizedAccount.GetAuthorizedAccountByUsername(username);
            }catch(UsernameDoesNotExistException e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                println("Promotion procces failed reasoned by : " + e.Message);
                Console.ResetColor();
                printSecondMenu();
                return;
            }
            if (targetAccount is Admin)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                println("Promotion procces failed reasoned by : Account is already admin" );
                Console.ResetColor();
                printSecondMenu();
                return;
            }
            ((Admin) account).PromoteToAdmin((User)targetAccount);
        }
        public static void printFirstMenu()
        {
            println("1.Login");
            println("2.Register");
            println("3.Continue as a guest");
            print("What is Your Choice : ");
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(read());
            }catch(Exception)
            {
                clear();
                println("You can only enter numbers");
                printFirstMenu();
            }
            switch (choice)
            {
                case 1:
                    printLoginMenu();
                    break;
                case 2:
                    printRegisterMenu();
                    break;
                case 3:
                    ((NonAuthorizedAccount)account).continueAsGuest();
                    break;
                default:
                    clear();
                    println("You can only enter numbers which are (1-2-3)");
                    printFirstMenu();
                    break;
            }
        }

        private static void printRegisterMenu()
        {
            clear();
            println("Enter your username");
            string username = read();
            println("Enter your password");
            string password = read();
            try
            {
                ((NonAuthorizedAccount)account).register(username, password);
            }
            catch (UsernameIsNotUniqueException e)
            {
                clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                println("You could not register reasoned by : " + e.Message);
                Console.ResetColor();
                printFirstMenu();
            }
        }

        public static void printLoginMenu()
        {
            clear();
            println("Enter your username");
            string username = read();
            println("Enter your password");
            string password = read();
            try
            {
                ((NonAuthorizedAccount)account).login(username, password);
                printSecondMenu();
            }
            catch(UsernameDoesNotExistException e)
            {
                clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                println("You could not login reasoned by : " + e.Message);
                Console.ResetColor();
                printFirstMenu();
            }
            catch(PasswordDoesNotMatchException e)
            {
                clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                println("You could not login reasoned by : " + e.Message);
                Console.ResetColor();
                printFirstMenu();
            }
            catch(BannedException e)
            {
                clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                println("You could not login reasoned by : " + e.Message);
                Console.ResetColor();
                printFirstMenu();
            }
        }
        
        public static void println(string message)
        {
            Console.WriteLine(message);
        }
        public static void print(string message)
        {
            Console.Write(message);
        }
        public static string read()
        {
            return Console.ReadLine();
        }
        public static void clear()
        {
            Console.Clear();
        }
    }
}
