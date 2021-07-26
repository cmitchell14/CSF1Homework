using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATM APPLICATION -- Instructions --
            //Build and ATM Application that will lockout the user if they account number, and the PIN  are not entered correctly.  (Three attempts each.)
            //Also, once authenticated, build a menu application, so the user can deposit, withdraw, check balance, etc.
            //Thank them for using the Banking Services.

            #region Variables  

            const string accountNumber = "555666789";
            string inputAccountNbr;
            int attemptsRemaining;
            const string pinNbr = "5555";
            string inputPinNbr;
            bool endLoop = true;

            #endregion

            Console.Title = "===== ATM Application =====";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to The Bank of the Developers.\n\nPlease enter your account number to begin."); //Prompt user for Account Number.

            for (int userAttempts = 1; userAttempts <= 3; userAttempts++)
            {
                Console.Write("\nAccount Number:  ");
                inputAccountNbr = Console.ReadLine();  //User enters Account Number

                switch (inputAccountNbr) //Branches for incorrect and correct Account number.
                {
                    case accountNumber:

                        goto accountCorrect;

                    default:
                        Console.WriteLine($"\n\nAccess denied.  Account number {inputAccountNbr} not found. \n\nPlease re-enter your account number. \n\nYou have {attemptsRemaining = 3 - userAttempts} attempts remaining.");
                        break;
                } //END SWITCH Account Number
            } // END FOR LOOP Account Number
            Console.Clear();
            Console.WriteLine("\n\nYou have exceeded the acceptable amout of attempts.  \n\nYour debit card has been shredded into tiny bits for your convenience.\n\nThank you for choosing \"The Bank of the Developers\".");
            Console.ReadKey();
            return;

        accountCorrect:; //Label to goto after correct Account number is entered.

            Console.Clear();
            Console.WriteLine("\n\n Please enter your pin number to continue."); //Prompt User for PIN 
            for (int userAttempts = 1; userAttempts <= 3; userAttempts++)
            {
                Console.Write("\nPin:  ");
                inputPinNbr = Console.ReadLine();  //User PIN input.

                switch (inputPinNbr)  // Branches for incorrect and correct PIN entry.
                {
                    case pinNbr:

                        goto pinCorrect;

                    default:
                        Console.WriteLine($"\n\nIncorrect pin number. \n\nPlease re-enter your PIN. \n\nYou have {attemptsRemaining = 3 - userAttempts} attempts remaining.");
                        break;
                } //END SWITCH PIN Number
            } // END FOR LOOP PIN Number

            Console.Clear();  //Resets screen.
            Console.WriteLine("\n\nYou have exceeded the acceptable amount of attempts.  \n\nYour debit card has been incinerated for your convenience.  \n\nPlease see a member of our banking staff. \n\nGood Bye. ");
            Console.ReadKey(); // Makes the user press a key to end program.
            return; //Shuts down program if PIN is incorrect.

        pinCorrect:; // Label to goto after the correct PIN is entered.

            decimal accountBalance = 0;
            decimal withdrawalAmount;
            decimal depositAmount;

            do
            {
                Console.Clear(); //Clears the screen.
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

                        endLoop = false; //To break out of loop.
                        break;


                    default:
                        Console.WriteLine("Invalid entry.  Please choose one of our options.");
                        break;
                }



            } while (endLoop); // CONDITION
            //END OF DO WHILE LOOP

            Console.Clear();
            Console.WriteLine("\n\nThank you for using \"The Bank of the Developers\" ATM!  We look forward to seeing you again soon!");
            Console.ReadKey();
            return;

        } //END MAIN METHOD

    }// END CLASS

}// END NAMESPACE
