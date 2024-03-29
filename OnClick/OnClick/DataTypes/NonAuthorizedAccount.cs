﻿using System;
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
                        if (acc is User)
                        {
                            if (((User)acc).isBanned)
                                throw new BannedException("This account is banned!");
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully logged in");
                        Console.ResetColor();
                        Program.account = acc;
                        return;
                    }
                    else
                    {
                        throw new PasswordDoesNotMatchException("Your password is incorrect");
                    }
                }
            }
            throw new UsernameDoesNotExistException("The username you have entered is not found.");
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
            // TODO: Save file
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have succesfully registered!");
            Console.ResetColor();
            Program.printFirstMenu();
            

        }

        public void continueAsGuest()
        {
            Program.account = new Guest();
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("You have entered as a Guest :" + Program.account.name );
            Console.ResetColor();
            Program.printSecondMenu();
        }

    }
}
