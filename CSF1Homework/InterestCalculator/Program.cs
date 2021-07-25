using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        static void Main(string[] args)
        {

            #region Interest Calculator Coding Challenge Instructions

            /*
             * Write a program to calculate interest for a given amount.  The program should ask the user for a beginning balance, interest rate, and a number of years.  Print the amount of money they would have (after the specified number of years) if the money is compounded annually with no additional deposits  For example:
             * 
             * Enter the beginning balance: $1000.00
             * Enter the interest rate percentage: 5%
             * Enter the number of years: 2
             * The Amount you should have is $1102.50   
             */

            #endregion

            #region Variables

            decimal balance;      ///Needed Variables.
            decimal interestRate;
            decimal nbrYears;
            bool repeat = true;

            #endregion

            Console.Title = "<===== INTEREST CALCULATOR =====>";
        anotherCalculation:;
            Console.WriteLine("\n\nInterest Calculator.\n\n");   //User prompts for information.
            Console.Write("What is your starting balance?  ");
            balance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n\nWhat is your interest rate? (*Just type the percentage number with no percent sign*)");
            interestRate = Convert.ToDecimal(Console.ReadLine());
            interestRate = .01m * interestRate;
            Console.Write("\n\nHow many years will your money be in the bank?   ");
            nbrYears = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n\nComputing....");
            Console.ReadKey();

            for (int i = 1; i <= nbrYears; i++)
            {
                balance = balance + (balance *= interestRate);

            }//END FOR LOOP
            Console.Clear();
            Console.WriteLine($"\n\nIn {nbrYears} years, you will have {balance:c}.");  //Final answer for user.
            Console.ReadKey();

            do
            {
                Console.WriteLine("Would you like to perform another calculation?");
                string repeatProcess = Console.ReadLine().ToUpper();
                switch (repeatProcess)
                {
                    case "Y":
                    case "YES":
                        goto anotherCalculation; //Option to repeat process.

                    case "N":
                    case "NO":
                        Console.WriteLine("\n\nThank you for using this program."); //End of program
                        Console.ReadKey();
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("\n\nInvalid Response.  Please choose a valid option."); //Invalid response.  Return to Option.

                        break;
                }
            } while (repeat); //END OF DO WHILE LOOPs


        } //END MAIN

    } //END CLASS

} //END NAMESPACE
