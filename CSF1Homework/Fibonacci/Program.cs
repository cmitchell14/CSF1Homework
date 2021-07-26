using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {

            #region FIBONACCI INSTRUCTIONS

            /*
             * Write a program that outputs a Fibonacci sequence, starting at 1, until a number that the user inputs is reached.
             * 
             * The Fibonacci sequence is where each number in the sequence is the sum of the two numbers that precede it.
             */

            #endregion

            //Variables

            int userNbr;
            ulong preceder = 0;
            ulong preceder2 = 1;
            ulong ender;

            Console.Title = "<====== FIBONACCI SEQUENCE ======>";
            Console.Write("\n\nWelcome to the Fibonacci Sequencer.\n\nPlease enter the number of times you would like the sequence to run:  ");
            userNbr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nYou have chosen the number {userNbr:n0}.\n\nHere is the sequence:\n\n");
            Console.ReadKey();

            for (int i = 0; i < userNbr; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(0);
                }//ELSE IF

                else if (i == 1)
                {
                    Console.WriteLine(1);
                }//END ELSE IF

                else
                {
                    ender = preceder + preceder2;
                    Console.WriteLine($"{ender}");
                    preceder = preceder2;
                    preceder2 = ender;
                }// END ELSE


            } //END FOR LOOP



        } // END MAIN

    } //END CLASS

} //END NAMESPACE
