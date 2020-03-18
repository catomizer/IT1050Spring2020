using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Sprint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 9 Sprint 3 - Assign values to an array");
            //Goal - Get input of 5 employee salaries and add to the salaryArray

            double salary = 0.0;          
            double taxPercent = 0.18;

            //Create 2 empty arrays to hold 5 salaries and taxes
            double[] salaryArray = new double[5];
            double[] tax = new double[5];

            //For 5 employees, get salary as input and add to salaryArray
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the salary of Employee # {0}", i);
                salary = Convert.ToDouble(Console.ReadLine());
                salaryArray[i] = salary;//assigning a value 

                tax[i] = salary * taxPercent;
                Console.WriteLine("Salary {0} Tax {1}", salaryArray[i], tax[i]);                
            }


            Console.WriteLine("All done");
            Console.ReadKey();
        }
    }
}
