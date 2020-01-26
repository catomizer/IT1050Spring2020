using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 3 Exercise 4 - If ElseIf Else");

            /* Challenge
             * Read user input
             * If user enters a, display apple
             * if user enteres b, display ball
             * if user enters c, display cat
             * otherwise display dog
             * */
            Console.WriteLine("Enter a letter from a-z");
            string txt = Console.ReadLine();

            if (txt == "a")
            {
                Console.WriteLine("apple");
            }
            else if (txt == "b")
            {
                Console.WriteLine("ball");
            }
            else if (txt == "c")
            {
                Console.WriteLine("cat");
            }
            else
            {
                Console.WriteLine("dog");
            }

            Console.ReadKey();
        }
    }
}
