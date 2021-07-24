using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            #region Instructions

            // TEMPERTATURE CONVERTER LAB 
            /*
             * Celius to Farenheit -- celsiusTemp = 9/5 + 32
             * Farenheit to Celsius -- farenheitTemp = celsiusTemp * (9.0/5.0) + 32
             * 
             * Use 100 Celsius as example when testing.  Answer should be 212F
             * 
             *Degree unicode = \u00b0 
             * 
             *
             */

            #endregion

            #region Variables

            decimal converterDec = 1.8m; //To multiply & divide for conversions
            decimal tempAdd = 32;   // To add and subtract for conversions

            #endregion


            Console.WriteLine("Temperature Converter Lab");
            Console.Title = "<--- Temperature Converter Lab --->";

            

            bool repeat = true;  //TO SET THE LOOP.

            do
            {
                Console.WriteLine("\n\nAre you wanting to convert a temperature from: \n\n A) Celsius to Farenheit \n\n or \n\n B) Farenheit to Celsius \n Please Type 'A', 'B', or 'E' to Exit the program: \n\n"); //Prompt user for input.
                ConsoleKey userAnswer = Console.ReadKey(true).Key; //User Answer decides whether to convert celsius to farenheit or vice versa.
                Console.Clear();


                if (userAnswer == ConsoleKey.A)
                {
                    Console.WriteLine("Please enter the temperature you are wanting to convert to farenheit: ");
                    decimal celsiusTemp = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"\nYour temperature of {celsiusTemp}\u00b0C is eqaul to " + ((celsiusTemp * converterDec) + tempAdd) + "\u00b0F");
                    //Branch to give coversion for celsius to farenheit.
                }
                else if (userAnswer == ConsoleKey.B)
                {
                    Console.WriteLine("Please enter the temperature you are wanting to convert to celsius: ");
                    decimal farenTemp = Convert.ToDecimal(Console.ReadLine());
                    decimal celsiusAnswer = ((farenTemp - tempAdd) / converterDec); //To allow formatting and rounding to two decimal places.
                    Console.WriteLine($"\nYour temperature of {farenTemp}\u00b0F is eqaul to {celsiusAnswer:n2}\u00b0C");
                    //Branch to give conversion for farenheit to celsius.
                }
                else if (userAnswer == ConsoleKey.E)
                {
                    Console.WriteLine("\n\nThank you for using this converter.  Have a great day!");
                    repeat = false;  //UPDATE TO ALLOW EXIT LOOP
                }

                else
	           {
                Console.WriteLine("Please enter a valid entry.");
                }

                Console.WriteLine("\n\nCool huh?  Would you like to try it again?");

        } while (repeat); //CONDITION


        } //END MAIN METHOD

} //END CLASS

} //END NAMESPACE