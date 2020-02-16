using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Sprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 5 Sprint Multiplication Table");
            Console.WriteLine("Enter a number");
            int multiplicant = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The multiplication table for {0}:", multiplicant);
            int product = 1;
            for (int counter = 1; counter <= 10; counter++) //write multiplication table from 1 to 10
            {
                product = counter * multiplicant;
                Console.WriteLine("{0} x {1} = {2}", counter, multiplicant, product);
            }
            Console.ReadKey();
        }
    }
}
