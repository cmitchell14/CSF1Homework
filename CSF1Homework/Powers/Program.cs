using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers
{
    class Powers
    {
        static void Main(string[] args)
        {

            #region Coding Challenge: Powers Instructions

            //Using a FOR loop, display the powers of 2 from 1 to 50.
            //(2 to the 1st power through 2 to the 20th power).  Use a long varaible to store your results.  
            //Example: 2 to the 4th power is 2*2*2*2.

            #endregion

            #region Variables

            long baseNbr = 2;
            long result = 1;

            #endregion

            Console.Title = "<========== Coding Challenge: Powers ==========>";
            Console.WriteLine("Welcome to the \"Powers\" lab.");

            for (long i = 1; i <= 50; i++)
            {
                Console.WriteLine(result *= baseNbr);
            }
            Console.ReadKey();

        }// END MAIN

    }// END CLASS

}// END NAMESPACE
