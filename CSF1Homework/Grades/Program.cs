using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {

        static void Main(string[] args)
        {

            #region Coding Challenge: Grades Instructions

            //Write a program that asks the user for scores (like they would receive on a test) and then displays each score.  The program should
            //stop asking for scores and displays the results when the user enters a negative score.
            /*
             * For Example:            Your scores
             * Enter a score: 95            95
             * Enter a score: 81            81
             * Enter a score: -1            
             */

            #endregion

            #region Variables

            int userScore;
            List<int> gradeScores = new List<int>();

            #endregion

            Console.Title = "<===== Grades Lab =====>";

            do
            {
                Console.Write("Please enter a grade score:  ");
                userScore = Convert.ToInt32(Console.ReadLine());

                if (userScore < 0)
                {

                } //END IF

                else
                {
                    gradeScores.Add(userScore);
                } //END ELSE

                if (userScore >= 0)
                {
                    Console.WriteLine($"\n\nYour score: {userScore}");
                } //END IF

                else
                {
                    Console.WriteLine();
                } //END ELSE

            } while (userScore >= 0);
            //END DO WHILE LOOP

            Console.WriteLine("Your Scores:\n\n");
            gradeScores.ForEach(Console.WriteLine);
            Console.ReadKey();


        }//END MAIN

    }//END CLASS

}//END NAMESPACE
