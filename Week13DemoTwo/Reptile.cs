using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    class Reptile : Animal
    {
        public Reptile() : this("None")
        {          
        }

        public Reptile(string family) : base("Reptile",family)
        {            
            HasHorns = false;
            HasFins = false;
            HasTail = true;
            HasFeathers = false;
        }

        override public void SetFamilyTraits()
        {
            NbrOfLegs = 4;            

        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("I have a tail");
        }
    }
}
