using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Variables 
            string adjective1;
            string nationality1;
            string person;
            string noun1;
            string adjective2;
            string noun2;
            string adjective3;
            string adjective4;
            string pluralNoun;
            string noun3;
            string number;
            string shapePlural;
            string food;
            string food2;
            string number2;
                        
            #endregion

            Console.WriteLine("Welcome to MadLibs!!");
            Console.Title = "============= MADLIB ==============";

            startOver:

            Console.WriteLine("\n\nPlease choose an adjective: ");
            adjective1 = Console.ReadLine();

            Console.WriteLine("\nPlease choose a Nationality: ");
            nationality1 = Console.ReadLine();

            Console.WriteLine("\nPlease choose a person: ");
            person = Console.ReadLine();

            Console.WriteLine("\nPlease choose a noun: ");
            noun1 = Console.ReadLine();

            Console.WriteLine("\nPlease choose an adjective: ");
            adjective2 = Console.ReadLine();

            Console.WriteLine("\nPlease choose a noun: ");
            noun2 = Console.ReadLine();

            Console.WriteLine("\nPlease choose an adjective: ");
            adjective3 = Console.ReadLine();

            Console.WriteLine("\nPlease choose an adjective: ");
            adjective4 = Console.ReadLine();

            Console.WriteLine("\nPlease choose a plural food (s): ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("\nPlease choose a noun: ");
            noun3 = Console.ReadLine();

            Console.WriteLine("\nPlease choose a number: ");
            number = Console.ReadLine();

            Console.WriteLine("\nPlease choose a plural shape (ex. circles): ");
            shapePlural = Console.ReadLine();

            Console.WriteLine("\nPlease choose a food: ");
            food = Console.ReadLine();

            Console.WriteLine("\nPlease choose another food: ");
            food2 = Console.ReadLine();

            Console.WriteLine("\nPlease choose another number: ");
            number2 = Console.ReadLine();

            Console.WriteLine("\n\nPerfect!! Are you ready for your result?!?");
            Console.WriteLine("\n\nPress any key if you are ready!!!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Pizza was invented by a {adjective1} {nationality1} chef named {person}.  To make a pizza, \nyou need to take a lump of {noun1}, and make a thin, round {adjective2} {noun2}.  \nThen you cover it with {adjective3} sauce, {adjective4} cheese, and fresh chopped {pluralNoun}.  \nNext you have to bake it in a very hot {noun3}.  When it is done, cut \n into {number} {shapePlural}.  Some kids like {food} pizza the best, but my favorite is the {food2} \npizza.  If I could, I would eat pizza {number2} times a day!!\n\n\n\n");

            Console.WriteLine("I hope you enjoyed this MadLib...");

            Console.WriteLine("\n\nPress any button to play again");
            Console.ReadKey();
            goto startOver;



        } //END MAIN

    } //END CLASS

} //END NAMESPACE
