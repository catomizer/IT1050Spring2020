using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* In this exercise we will write a program that will
           * read the scores of x students and
           * calculate the average.
           * The program will display the average.
           * We will implement to his logic using a "While" statement in C#
           */

            Console.WriteLine("Week 5 Exercise 2 - Sentinel controlled iteration");
            double score = 0.0;
            double sum = 0.0;
            double avg = 0.0;
            string scoreAsDouble;

            int flag = 0;

            while (flag != -1)
            {
                Console.WriteLine("Enter student score");
                scoreAsDouble = Console.ReadLine();
                score = Convert.ToDouble(scoreAsDouble);
                sum = sum + score;
                
                Console.WriteLine("Enter a number to continue or -1 to stop");
                flag = Int32.Parse(Console.ReadLine());//flag will capture 1 or -1. -1 indicates we stop getting input
            }

            avg = sum / 5;
            Console.WriteLine("Sum is {0} and Average is {1}", sum, avg);

            Console.ReadKey();
        }
    }
}
