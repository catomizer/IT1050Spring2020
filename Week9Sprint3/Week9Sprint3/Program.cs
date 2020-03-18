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
            
            //Goal - Get input of 5 employee salaries and add to the salaryArray. Calculate tax @ 18%
            double[] salaryArray = new double[5];//declaring an empty array
            double[] taxArray = new double[5];

            for(int i=0; i < 5; i++)
            {
                //Get input and save to a variable
                Console.WriteLine("Enter the salary of Employee # {0}", i);
                double salary = Convert.ToDouble(Console.ReadLine());

                salaryArray[i]=salary;
                taxArray[i] = salary * 0.18;

                //Console.WriteLine("Salary = {0} and Tax = {1}", salaryArray[i], taxArray[i]);

            }

            Console.WriteLine("Salary array");
            Console.WriteLine("-------------");
            foreach(double salary in salaryArray)
            {
              Console.WriteLine(salary);
            }

            Console.WriteLine("Tax array");
            Console.WriteLine("-------------");
            foreach(double tax in taxArray)
            {
              Console.WriteLine(tax);
            }

            Console.WriteLine("All done");
            Console.ReadKey();
        }
    }
}
