using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 7 - Break statement demo");

            //Goal - ask for 10 numbers and find if the input matches 3500
            //If match found we stop running the loop

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("Enter a number");
                string inputStr = Console.ReadLine();//Read and Save
                int input = Int32.Parse(inputStr);//Convert to integer

                if (input == 3500)
                {
                    Console.WriteLine("Found my match after {0} tries", i);
                    break;//Control will go to first statement after the loop
                }
                Console.WriteLine("Too bad we didnot find a match");
            }           

            Console.WriteLine("All done");
            Console.ReadKey();
        }
    }
}
