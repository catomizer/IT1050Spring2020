using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    class Fish : Animal
    {
        public Fish() : this("None")
        {
          
        }
        public Fish(string family) : base("Fish",family)
        {
            HasTail = false;
            HasHorns = false;
            HasFins = true;
            HasFeathers = false;
        }

        override public void SetFamilyTraits()
        {
            NbrOfLegs = 0;
        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("I have fins");
            Console.WriteLine("I have {0} legs", NbrOfLegs);
        }


    }
}
