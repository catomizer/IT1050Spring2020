using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 3 Exercise 3");

            /* Student score to grade conversion
             * 
             * A if score is between 90 and 100
             * B if score is betwen 80 and 89
             * C if score is between 70 and 79
             * D if the score is between 60 and 69
             * F otherwise
             * */

            int score = 0;
            string scoreAsText;

            Console.WriteLine("Enter score");
            scoreAsText = Console.ReadLine();
            score = Int32.Parse(scoreAsText);
            
            //Logical operators 
            /* 
             * and &&
             * or ||
             * not !
             * */

            if (score <= 100 && score >= 90)
            {
                Console.WriteLine("You scored an A");
            }
            else if (score <= 89 && score >= 80)
            {
                Console.WriteLine("You scored a B");
            }
            else if (score <= 79 && score >= 70)
            {
                Console.WriteLine("You scored a C");
            }
            else if (score <=69 && score >= 60)
            {
                Console.WriteLine("You scored a D");
            }
            else 
            {
                Console.WriteLine("You scored an F");
            }

            Console.ReadKey();
        }
    }
}
