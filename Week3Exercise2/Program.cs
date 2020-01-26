using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 3 Exercise 2 - Area of a rectangle");

            /* --------------------------------------------
             * Challenge
             * --------------------------------------------
             * Get the length of the rectangle
             * Get the width of the rectangle
             * Compare the length and width. If they are equal, then display "Shape is a square"
             * Calculate area of the shape: area = length * width
             * */

            //To read an input we will use Console.ReadLine();
            int length=0;
            int width=0;
            int area = 0;

            string lengthAsText;
            string widthAsText;

            Console.WriteLine("Enter the length in inches");
            lengthAsText = Console.ReadLine();
            

            Console.WriteLine("Enter the width in inches");
            widthAsText = Console.ReadLine();
            
            //Validate that the entered value is not negative


            //Convert text to integer
            length = Int32.Parse(lengthAsText);
            width = Int32.Parse(widthAsText);

            if (length == width )//comparison operator == is used
            {
                Console.WriteLine("Shape is a square");
            }

            area = length * width;
            Console.WriteLine("Area of the shape is " + area + " square inches");//string concatenation

            Console.ReadKey();
        }
    }
}
