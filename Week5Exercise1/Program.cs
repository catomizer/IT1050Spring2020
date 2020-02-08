using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* In this exercise we will write a program that will
             * read the scores of 5 students and
             * calculate the average.
             * The program will display the average.
             * We will implement this logic using a "While" statement in C#
             */

            Console.WriteLine("Week 5 Exercise 1 - Counter controlled iteration");
            double score = 0.0;
            double sum = 0.0;
            double avg = 0.0;
            string scoreAsText;

            int counter = 0;//counter variable

            while(counter < 5)
            {
                scoreAsText = Console.ReadLine();
                score = Convert.ToDouble(scoreAsText);
                sum = sum + score;
                counter = counter + 1;
            }

            avg = sum / 5;

            Console.WriteLine("Sum of scores of 5 students is {0} and average is {1}", sum, avg);

            Console.ReadKey();


        }
    }
}
