using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 2 Exercise 3 - Mod operator");
            //Basic arithmetic operators are + - * /
            //Mod operator %

            //Divide a number 12 by 2 => quotient of 6 and reminder of 0
            //Divide a number 13 by 2 => quotient of 6 and reminder of 1

            int number = 13;//declare variable and assign value
            int quotient;
            int reminder;

            quotient = number / 2;
            Console.WriteLine(quotient);

            reminder = number % 2;
            Console.WriteLine(reminder);

            //if you divide a number by 2 and the reminder is 0, it is an even number
            /*
             * if reminder is equal to zero, write to console that the number is even
             * else write to console that the number is odd       
             *  
             * if (condition expression)
             * {
             *       do something
             * }
             * else
             * {
             *       do something else
             * }
             */

            if (reminder == 0)// == is comparison operator; = is assignment operator
            {
                Console.WriteLine("Given number is even");
            }
            else
            {
                Console.WriteLine("Given number is odd");
            }

            Console.ReadKey();

        }
    }
}
