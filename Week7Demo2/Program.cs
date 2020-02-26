using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 7 Demo 2 - Continue statement");

            //Goal is to take 5 input numbers and only add any number that is greater than 100

            int sum = 0;
            for(int x=1;x<=5;x++)
            {
                Console.WriteLine("Enter a number");
                string inputStr = Console.ReadLine();//Read and Save
                int input = Int32.Parse(inputStr);//Convert to integer

                if (input <= 100)
                {
                    continue;//Control goes back to the top of the loop
                }
                sum = sum + input;
                Console.WriteLine("Thanks for entering a number > 100");               
            }

            Console.WriteLine(sum);

            Console.WriteLine("All done!");
            Console.ReadKey();
        }
    }
}
