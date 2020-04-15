using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    static class SpeciesHelper
    {
        static public void WhatIsASpecies()
        {
            Console.WriteLine("General Info about species");

        }
        static public void WhatIsAFamily()
        {
            Console.WriteLine("General Info about family");
        }

        static public void ColdBloodedCreatureInfo()
        {
            Console.WriteLine("Info about cold-blodded creatures");
        }

        static public void WarmBloodedCreatureInfo()
        {
            Console.WriteLine("Info about warm-blodded creatures");
        }
        
        static public void Print(Animal a)
        {
            Console.WriteLine("This function will print a passed object");
        }
        
    }
}
