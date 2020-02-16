using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 5 Spring Add 10 numbers
            
            int number = 0;
            int counter = 0;
            int sum = 0;

            Console.WriteLine("Week 5 Sprint Add 10 numbers");            

            while (counter < 10)
            {
                Console.WriteLine("Enter a number");
                number = Int32.Parse(Console.ReadLine());
                sum = sum + number;
                counter = counter + 1;
            }

            Console.WriteLine("The sum of 10 given numbers is {0}", sum);
            Console.ReadKey();

           
        }
    }
}
