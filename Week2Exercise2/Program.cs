using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Challenge 1A
                Think of a number.
                Add 3.
                Double that.
                Subtract 4.
                Cut that in half.
                Subtract your original number.
                Your result is 1!
                Check if this is true!!!
                */

            Console.WriteLine("Week 2 Exercise 2 - Arithmetic operations");            
            int origNum;//declare variable
            origNum = 20;//assigned value to a variable

            int result;//declare variable called result

            //Add 3 to origNum and save to a variable called result
            result = origNum + 3;

            //Double that means result * 2 and then save it to result
            result = result * 2;

            //Subtract 4 from result and then save to result
            result = result - 4;

            //Cut that in half means divide result by 2 and save to result
            result = result / 2;

            //Subtract your original number from result and save to result
            result = result - origNum;

            //Display result
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
