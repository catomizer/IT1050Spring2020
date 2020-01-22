using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int origNum = 10;
            int result = 0;

            result = origNum + 3; //Add 3 
            result = result * 2;
            result = result - 4;
            result = result / 2;
            result = result - origNum;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
