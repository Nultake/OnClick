using System;

namespace OnClick
{
    public class Program
    {
        public static Account account;
        static void Main(string[] args)
        {
            account = new NonAuthorizedAccount();
            printFirstMenu();

            
        }
        public static void printSecondMenu()
        {
            println("1.List Adverts");
            if (account is not Guest)
            {
                println("2.Check Mailbox");
                println("3.Remove Advert");
                println("4.Update Advert");
                println("5.Log Out");
            }
            if (account is User)
            {
                println("6.Add Advert");
            }
            if (account is Admin)
            {
                println("6.Ban Player");
                println("7.Promote Player To Admin");
            }
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(read());
            }catch(Exception e)
            {
                clear();
                println("You can only enter numbers");
                printSecondMenu();
            }
            {
                switch (choice)
                {
                    case 1:
                        account.listAdvert();
                        break;
                    default:
                        if (account is not Guest)
                        {
                            switch (choice)
                            {
                                case 2:
                                    ((AuthorizedAccount) account).checkMailBox();
                                    break;
                                case 3:
                                    ((AuthorizedAccount) account).removeAdvert();
                                    break;
                                case 4:
                                    ((AuthorizedAccount) account).updateProfile();
                                    break;
                                case 5:
                                    ((AuthorizedAccount) account).logOut();
                                    break;
                                case 6:
                                    if (account is User)
                                        printAddAdvertMenu();
                                    else
                                        printBanPlayerMenu();
                                    break;
                                default:
                                    if(account is Admin)
                                    {
                                        switch (choice)
                                        {
                                            case 7:
                                                printPromoteMenu();
                                                break;
                                            default:
                                                clear();
                                                println("You can only enter (1-2-3-4-5-6-7)");
                                                printSecondMenu();
                                                break;

                                        }
                                    }
                                    clear();
                                    println("You can only enter (1-2-3-4-5-6)");
                                    printSecondMenu();
                                    break;
                            }
                        }
                        clear();
                        println("You can only enter 1");
                        printSecondMenu();
                        break;
                }
            }



        }
        public static void printAddAdvertMenu()
        {

        }
        public static void printBanPlayerMenu()
        {

        }
        public static void printPromoteMenu()
        {

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
            }catch(Exception e)
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
                Console.BackgroundColor = ConsoleColor.Cyan;
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
            }
            catch(UsernameDoesNotExistException e)
            {
                clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                println("You could not login reasoned by : " + e.Message);
                Console.ResetColor();
                printFirstMenu();
            }
            catch(PasswordDoesNotMatchException e)
            {
                clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
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
