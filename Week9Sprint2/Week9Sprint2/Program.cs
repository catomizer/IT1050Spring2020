using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Sprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grades using Arrays - Sort, Reverse, Min, Max");

            int[] grades;//array declaration
            grades = new int[] { 45, 87, 90,34,56,32,88,99 };//assign values to the array called grades

            Console.WriteLine("Grades as-is");
            Console.WriteLine("------------");
            foreach(int grade in grades)
            {
                Console.WriteLine(grade);
            }

            //To sort the array in ascending order
            Array.Sort(grades);
            Console.WriteLine("Grades after Sort");
            Console.WriteLine("------------");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            //Sort descending by first sorting in ascending and then reversing the order
            Array.Reverse(grades);
            Console.WriteLine("Grades after Reverse");
            Console.WriteLine("------------");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            //Lowest value in the array
            int lowestGrade = grades.Min();
            Console.WriteLine("Lowest grade is {0}", lowestGrade);

            int highestGrade = grades.Max();
            Console.WriteLine("Highest grade is {0}", highestGrade);

            int sum = grades.Sum();
            Console.WriteLine("Sum of all the grades is {0}", sum);

            int len = grades.Length;
            Console.WriteLine("Length of the array is {0}", len);

            double avg = sum / len;
            Console.WriteLine("Average grade is {0}", avg);


            Console.WriteLine("All done!!!");
            Console.ReadKey();

        }
    }
}
