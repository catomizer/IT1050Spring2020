using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    class Bird : Animal
    {
        public bool HasFlight { get; set; }

        public Bird():this("None")
        {
            
        }
        public Bird(string family) : base("Bird",family)
        {
            HasTail = false;
            HasFins = false;
            HasHorns = false;
            HasFeathers = true;
        }
        override public void SetFamilyTraits()
        {
            switch(Family)
            {
                case "Ostrich":
                case "Penguin":
                case "Emu":
                    HasFlight = false;
                    break;
                default:
                    HasFlight = true;
                    break;
            }
            NbrOfLegs = 2;
        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("I have feathers and wings");
            Console.WriteLine("I have {0} legs", NbrOfLegs);
            if (HasFlight)
                Console.WriteLine("I can fly!");
            else
                Console.WriteLine("I cannot fly");
        }
    }
}
