using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 7 Demo 3 - Switch statement");

            //pineapple, banana, avocado, kiwi, papaya - tropical

            Console.WriteLine("Enter a fruit name");
            string input = Console.ReadLine();//input will hold fruit name so it is a string
            //no need to convert it 

            switch (input)
            {
                case "avocado":
                case "papaya":
                case "banana":
                    Console.WriteLine("Tropical");
                    break;
                case "berries":
                case "pear":
                case "apple":
                    Console.WriteLine("Not tropical");
                    break;                
                default:
                    Console.WriteLine("I am not sure");
                    break;
            }

            Console.WriteLine("All done");
            Console.ReadKey();
        }
    }
}
