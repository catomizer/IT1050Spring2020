using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Bird b1 = new Bird("Emu");
            b1.Intro();            
            Console.ReadKey();

            Mammal m1 = new Mammal("Elephant");
            m1.Intro();
            Console.ReadKey();

            Fish f1 = new Fish("GoldFish");
            f1.Intro();
            Console.ReadKey();

            Reptile r1 = new Reptile("Lizard");
            r1.Intro();
            Console.ReadKey();

            SpeciesHelper.ColdBloodedCreatureInfo();
            SpeciesHelper.WhatIsAFamily();
            Console.ReadKey();

        }
    }
}
