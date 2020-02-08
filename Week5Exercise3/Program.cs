using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1;

            while (num >= 0)
            {
                num = num * 2;
            }

            Console.WriteLine("Sum after while loop is {0}",num);

            do
            {
                num = num * 2;

            } while (num >= 0);

            Console.WriteLine("Sum after Do-while loop is {0}", num);


            Console.ReadKey();
        }
    }
}
