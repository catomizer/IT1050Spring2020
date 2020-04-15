using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr_of_cats = 0;

            Cat myCat1 = new Cat("fluff","orange",3,"A333");
            myCat1.intro();
            nbr_of_cats = Cat.CatsForAdoption;
            Console.WriteLine(nbr_of_cats);

            Cat myCat2 = new Cat("stripey", "white", 3, "A323");
            myCat2.intro();
            nbr_of_cats = Cat.CatsForAdoption;
            Console.WriteLine(nbr_of_cats);

            Cat myCat3 = new Cat("tiger", "black", 3, "A834");
            myCat3.intro();
            nbr_of_cats = Cat.CatsForAdoption;
            Console.WriteLine(nbr_of_cats);

            Cat myCat4 = new Cat("snowbell", "brown", 3, "A903");
            myCat4.intro();
            nbr_of_cats = Cat.CatsForAdoption;
            Console.WriteLine(nbr_of_cats);

            bool result = myCat1.Adopt("Tim", Convert.ToDateTime("1/1/2020"));
            nbr_of_cats = Cat.CatsForAdoption;
            Console.WriteLine(nbr_of_cats);
            result = myCat1.Adopt("Tim", Convert.ToDateTime("1/1/2020"));

            Console.ReadKey();

        }
    }
}
