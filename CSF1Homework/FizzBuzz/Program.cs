using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            #region FIZZBUZZ Instructions

            /*
             * Write a program that counts up from 1 to a number that the user enters.  Any time a number divisible by three would display, print the word "Fizz" instead.  Any time you would normally display a number that is divisibe by 5, instead display the word "Buzz".  Any time you would normally display a number that is both divisible by both 3 and 5, display "FizzBuzz".
             * 
             * Example:  1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz
             */

            #endregion

            #region Variables

            int userNbr;
            int threeDivide = 3;
            int fiveDivide = 5;
            #endregion

            Console.Title = "<====== FIZZBUZZ =====>";

            Console.Write("Welcome to FizzBuzz!!!  Please choose a number:  ");
            userNbr = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userNbr; i++)
            {
                if (i % threeDivide == 0 && i % fiveDivide == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } //END IF FIZZ
                else if (i % fiveDivide == 0)
                {
                    Console.WriteLine("Buzz");
                } //END ELSE IF BUZZ
                else if (i % threeDivide == 0)
                {
                    Console.WriteLine("Fizz");
                } // END ELSE IF FIZZBUZZ
                else
                {
                    Console.WriteLine(i);
                } //END ELSE

            } //END FOR LOOP


        } //END MAIN

    } //END CLASS

} //END NAMESPACE
