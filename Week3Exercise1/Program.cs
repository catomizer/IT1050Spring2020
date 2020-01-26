using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 3 Exercise 1 - If conditions");

            /* Student score to grade conversion (P/F)
             * Input student score
             * Evaluate if score greater than or equal to 70
             * If true, then the program will display "Pass"
             * otherwise program will display "Fail"
             * */

            int score;
            string scoreValue; 
            scoreValue = Console.ReadLine();//Input score as text
            score = Int32.Parse(scoreValue);//Convert score to integer

            if (score >= 70)//Comparison >= means greater than or equal to
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();

        }
    }
}
