using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Sprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter first number
            Console.WriteLine("Enter the first number");
            string num1Str = Console.ReadLine();
            int num1 = Int32.Parse(num1Str);

            //Ask the user to enter second number
            Console.WriteLine("Enter the second number");
            string num2Str = Console.ReadLine();
            int num2 = Int32.Parse(num2Str);

            //Ask the user to enter the operation(allowed operations are are + -* /)
            Console.WriteLine("Enter the operator");
            string oper = Console.ReadLine();

            int ans = 0;
            //Using switch lets do some math
            switch (oper)
            {
                case "+":
                    ans = num1 + num2;
                    Console.WriteLine("Your result is {0}",ans);
                    break;
                case "-":
                    ans = num1 - num2;
                    Console.WriteLine("Your result is {0}", ans);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            
        }
    }
}
