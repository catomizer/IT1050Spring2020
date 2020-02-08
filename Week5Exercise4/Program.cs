using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* For Loop*/
            Console.WriteLine("Week5Exercise4 - For loop");

            double score = 0.0;
            double sum = 0.0;
            double avg = 0.0;

            for (int counter=0;counter < 5 ; counter++)//counter++ => counter = counter + 1
            {
                string scoreAsText = Console.ReadLine();
                score = Convert.ToDouble(scoreAsText);
                //sum = sum + score;
                sum += score;
            }

            avg = sum / 5;
            Console.WriteLine("sum and average are {0} {1}", sum, avg);
            Console.ReadKey();

        }
    }
}
