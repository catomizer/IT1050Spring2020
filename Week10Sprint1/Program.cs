using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //I have 3 cats
            /* cat 1 is called fluff, is 4 years old, id="A322" and color is orange
             * cat 2 is called "snowbell", is 1 year old, id="R333" and color is white
             * cat 3 is called "stripey", is 6 years old, id="S123" and color is black
             * */

            /*string[] catNames = new string[] { "fluff", "snowbell","stripey"};
            string[] catIDs = new string[] { "A322", "R333", "S123"};
            int[] catAges = new int[] { 4,1,6 };
            string[] catColors = new string[] {"orange", "white","black" };

            Console.WriteLine("Enter cat name");
            catNames[3] = Console.ReadLine();

            Console.WriteLine("Enter cat id");
            catIDs[3] = Console.ReadLine();

            Console.WriteLine("Enter cat age");
            catAges[3] = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter cat color");
            catColors[3] = Console.ReadLine(); */

            Cat myCat = new Cat();//Create an object
            myCat.intro();

            Cat fluff = new Cat("fluff", "orange", 4, "A332");//Object name is fluff
            fluff.intro();
            fluff.play();
           

            Cat myCat2 = new Cat("snowbell", "white", 1, "R333");//Object name is myCat2
            myCat2.intro();
            myCat2.sleep();

            Cat myCat3 = new Cat("stripey", "black", 6, "S123");//Object name is fluff
            myCat3.intro();
            myCat3.eat();

            Console.ReadKey();

        }
    }
}
