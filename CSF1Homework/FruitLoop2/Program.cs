using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLoop2
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {

            string[] fruitLoops = { "apples", "pears", "bananas", "lemons", "limes", "peaches" };

            foreach (string fruit in fruitLoops)
            {
                if (fruit == "apples")
                {
                    Console.WriteLine(fruit + "\n.");
                }
                else if (fruit == "pears")
                {
                    Console.WriteLine(fruit + "\n..");
                }
                else if (fruit == "bananas")
                {
                    Console.WriteLine(fruit + "\n...");
                }
                else if (fruit == "lemons")
                {
                    Console.WriteLine(fruit + "\n....");
                }
                else if (fruit == "limes")
                {
                    Console.WriteLine(fruit + "\n.....");
                }
                else if (fruit == "peaches")
                {
                    Console.WriteLine(fruit + "\n......");
                }
            }
        } //END MAIN

    } //END CLASS

} //END NAMESPACE
