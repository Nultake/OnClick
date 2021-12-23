using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class NonAuthorizedAccount : Account
    {
        public void login(string userName, string password)
        {
            if (AuthorizedAccount.accounts.Count == 0)
            {
                throw new UsernameDoesNotExistException("The username you have entered is not found.");
            }
            foreach(AuthorizedAccount acc in AuthorizedAccount.accounts)
            {
                if(acc.userName.Equals(userName))
                {
                    if (acc.password.Equals(password))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully logged in");
                        Console.ResetColor();
                        Program.account = acc;
                    }
                    else
                    {
                        throw new PasswordDoesNotMatchException("Your password is invalid");
                    }
                }
                else
                {
                    throw new UsernameDoesNotExistException("The username you have entered is not found.");
                }
            }

        }
        public void register(string userName, string password) 
        {
            if (AuthorizedAccount.accounts.Count != 0)
            {
                foreach (AuthorizedAccount acc in AuthorizedAccount.accounts)
                {
                    if (acc.userName.Equals(userName))
                    {
                        throw new UsernameIsNotUniqueException("This username is already taken.");
                    }

                }
            }
            User user = new User();
            user.userName = userName;
            user.password = password;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have succesfully registered!");
            Console.ResetColor();
            Program.printFirstMenu();
            // TO DO: Save file

        }

        public void continueAsGuest()
        {
            Program.account = new Guest();
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("You have entered as a Guest : Guest" + Account.counter);
            Console.ResetColor();
        }

    }
}
