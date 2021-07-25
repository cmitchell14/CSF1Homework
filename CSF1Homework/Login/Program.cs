using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Instructions for Login Page

            /*
             * Ask for Username
             * 
             * If it matches your one hard-coded, correct username, tell the user to they have access.  If not, tell the user that they have been denied access.
             * 
             * Make sure the usernames (hard-coded & user input are case insensitive (uppercase or lowercase).
             * 
             * ADDITIONAL FUNCTIONALITY
             * 
             * Encase the username functionality in a loop that allows the user to make another attempt if the previous attempt was unsuccessful.
             * 
             * Extend the loop functionality to deny access to the user if they enter the wrong username 3 times. 
             * 
             * Extend the username functionality to ask for a password if the user entered the correct username.  Deny access if the password is entered incorrectly 3 times.  (Note: 3 attempts at username if the correct username is entered, give 3 attemps for the correct password.)
             */

            #endregion

            #region Variables

            const string userName = "CMITCHELL";
            string userPassword = "WebDeveloper";
            bool loopClose = true;
            #endregion

            Console.Title = "====== Web Developer Login Station ======";

            do
            {
                Console.WriteLine("Welcome to the Web Developer Intranet.");
                Console.WriteLine("\nPlease login to continue.");
                Console.Write("\nUsername:  ");
                string userNameInput = Console.ReadLine().ToUpper();

                switch (userNameInput)
                {
                    case userName:
                        Console.WriteLine("\nPlease Enter your password.");
                        Console.Write("Password:  ");
                        string inputPassword = Console.ReadLine();
                        
                        switch (userPassword)
                        {
                            case inputPassword:
                            
                                break;
                            default:
                                Console.WriteLine("Invalid Password. You have 2 attempts remaining.");
                                break;
                        }
                    default:
                }

            } while (loopClose);
            

        }// END MAIN

    }// END CLASS

}// END NAMESPACE
