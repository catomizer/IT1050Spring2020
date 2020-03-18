using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Goal is to display a collection of birds
            Console.WriteLine("Collection of birds");
            
            //birds are cockatiel, robin, sparrow, kingfisher, pigeon, crow            
            string[] birds = { "cockatiel", "robin", "sparrow", "kingfisher", "pigeon", "crow" };

            int len = birds.Length;
            Console.WriteLine("Length of birds array is {0}", len);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Now iterating the array using for loop");
            Console.WriteLine("-------------------------------------");
            for (int i=0;i< len; i++)
            {
                Console.WriteLine("One of the birds in collection is {0}", birds[i]);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Now iterating the array using foreach");
            Console.WriteLine("-------------------------------------");
            foreach (string bird in birds)
            {
                Console.WriteLine("One of the birds in collection is {0}", bird);
            }

            Console.WriteLine("All done!");

            Console.ReadKey();
        }
    }
}
