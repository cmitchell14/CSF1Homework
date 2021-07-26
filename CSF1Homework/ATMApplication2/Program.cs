using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructions - ATM APP 2

            //ATM APPLICATION -- Instructions --
            //Build and ATM Application that will lockout the user if they account number, and the PIN  are not entered correctly.  (Three attempts each.)
            //Also, once authenticated, build a menu application, so the user can deposit, withdraw, check balance, etc.
            //Thank them for using the Banking Services.

            #endregion

            #region Variables

            const string accountNumber = "555666789";
            string inputAccountNbr;
            string userName = "Caleb";
            int userAttempts = 1;
            int userAttamptsPin = 1;
            const string pinNbr = "5555";
            string inputPinNbr;
            bool endLoop = true;
            bool authLoop = true;
            bool authLoopPin = true;
            decimal accountBalance = 0;
            decimal withdrawalAmount;
            decimal depositAmount;

            #endregion

            #region Main Logic 

            Console.Title = "===== ATM Application =====";
            Console.ForegroundColor = ConsoleColor.Green;  //END OF INTRO



            while (authLoop)
            {
                Console.Write("\nWelcome to The Bank of the Developers.\n\nPlease enter your account number to begin:  "); //Prompt user for Account Number.
                inputAccountNbr = Console.ReadLine();

                if (inputAccountNbr != accountNumber && userAttempts <= 2)//If an invalid account number was used for the first two attempts.
                {
                    userAttempts++;
                    Console.WriteLine($"\n\nAccount Number {inputAccountNbr} was not found.  Please enter a valid entry.  You have {4 - userAttempts} attempts remaining.");
                } //END IF
                else if (inputAccountNbr != accountNumber) //If incorrect on final attempt.
                {
                    Console.WriteLine("\n\nYou've exceeded the maximum amount of attempts.  Your debit card has been incinerated for your convenience.");
                    authLoop = false;
                    Console.ReadKey();
                } //END ELSE IF
                else  //If Account Number was correct.
                {
                    while (authLoopPin)
                    {
                        Console.Write("\n\nPlease input your PIN:  ");
                        inputPinNbr = Console.ReadLine();
                        if (pinNbr != inputPinNbr && userAttamptsPin <= 2)//If an invalid account number was used for the first two attempts.
                        {
                            userAttamptsPin++;
                            Console.WriteLine($"\n\nInvalid PIN entry.  Please re-enter PIN.  You have {4 - userAttamptsPin} attempts remaining.");
                        } //END IF
                        else if (pinNbr != inputPinNbr) //If incorrect on final attempt.
                        {
                            Console.WriteLine("\n\nYou've exceeded the maximum amount of attempts.  Your debit card has been incinerated for your convenience.");
                            authLoop = false;
                            authLoopPin = false;
                            Console.ReadKey();

                        } //END ELSE IF
                        else  //If PIN Number was correct.
                        {
                            Console.Clear();
                            Console.WriteLine($"\n\nWelcome {userName}!!");

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n BANK OF THE DEVELOPERS MAIN MENU\n\nPlease make a selection from the following options:  ");
                                Console.WriteLine("\n\n A) Make a Deposit\n B) Make a Withdrawal from your Account\n C) See your Account Balance \n D) Exit\n\n");
                                string userChoice = Console.ReadLine().ToUpper();


                                switch (userChoice)
                                {
                                    case "A":
                                    case "DEPOSIT":
                                        Console.WriteLine("\n\nPlease insert your cash or check.");
                                        Console.Write("\n\nDeposit Amount:  ");
                                        depositAmount = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine($"\n\nThank you for your deposit of {depositAmount:c}.  \n\nYour updated balance is {accountBalance = depositAmount + accountBalance:c}.");
                                        Console.WriteLine("\n\nPress any key to return to the Main Menu.");
                                        Console.ReadKey();

                                        break; //END OF DEPOSIT BRANCH

                                    case "B":
                                    case "WITHDRAWAL":

                                        Console.Write("\n\nPlease choose an amount to withdraw:  ");
                                        withdrawalAmount = Convert.ToDecimal(Console.ReadLine());

                                        if (accountBalance < withdrawalAmount)
                                        {
                                            Console.WriteLine("\n\nYour account balance is lower than the amount you are requesting to withdraw.\n\nPlease see a representative to assist you.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n\n{withdrawalAmount:c} has been withdrawn from your account {accountNumber}.  Your updated account balance is: {accountBalance = accountBalance - withdrawalAmount:c}");
                                            Console.WriteLine("\n\nPress any key to return to the Main Menu.");
                                            Console.ReadKey();
                                        }

                                        break;

                                    case "C":
                                    case "BALANCE":
                                    case "ACCOUNT BALANCE":

                                        Console.WriteLine($"\n\nYour current balance is: {accountBalance:c}.");
                                        Console.WriteLine("\n\nPress any key to return to the Main Menu.");
                                        Console.ReadKey();
                                        break;

                                    case "E":
                                    case "D":
                                    case "EXIT":

                                        authLoop = false;
                                        authLoopPin = false;
                                        endLoop = false; //To break out of loop.
                                        break;

                                    default:
                                        Console.WriteLine("Invalid entry.  Please choose one of our options.");
                                        break;
                                } // END SWITCH MENU

                            } while (endLoop); // CONDITION
                                               //END OF DO WHILE LOOP

                        } //END  ELSE --PIN NUMBER

                    } // END ELSE STATEMENT -- ACCOUNT NUMBER

                } //END SUB FOR LOOP

            }//END of Main WHILE Loop

            #endregion

            #region GoodBye

            Console.Clear();
            Console.WriteLine("\n\nThank you for using \"The Bank of the Developers\" ATM!  We look forward to seeing you again soon!");
            Console.ReadKey();

            #endregion

        } //END MAIN

    }//END CLASS

} //END NAMESPACE

