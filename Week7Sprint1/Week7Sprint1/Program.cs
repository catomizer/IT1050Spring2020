using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 0-9");//Prompt user for input
            string input = Console.ReadLine();//Read and save

            switch (input)//Check value of input
            {
                case "0"://if input is equal to "0"
                    Console.WriteLine("You entered 0");
                    break;
                case "1"://if input is equal to "1"
                    Console.WriteLine("You entered 1");
                    break;
                default://if input is some other value not liste above
                    Console.WriteLine("Your input is invalid");
                    break;
            }
            Console.WriteLine("All done");
            Console.ReadKey();
        }
    }
}
