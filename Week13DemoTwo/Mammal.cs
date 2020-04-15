using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    class Mammal : Animal
    {
        public bool HasTusks { get; set; }//Only for Mammal class

        public Mammal():this("None")
        {         
        }
      
        public Mammal(string family):base("Mammal", family)
        {
            HasFins = false;
            HasFeathers = false;
        }

        override public void SetFamilyTraits()
        {
           switch (Family)
            {
                case "Cow":
                case "Goat":
                case "Deer":
                case "Moose":
                    HasHorns = true;
                    HasTail = true;
                    NbrOfLegs = 4;
                    break;
                case "Horse":
                case "Pig":
                case "Lion":
                    HasHorns = false;
                    HasTail = true;
                    NbrOfLegs = 4;
                    break;
                case "Human":                
                case "Gorilla":
                    HasHorns = false;
                    HasTail = false;
                    NbrOfLegs = 2;
                    break;
                case "Elephant":
                    HasTusks = true;
                    HasHorns = false;
                    HasTail = true;
                    NbrOfLegs = 4;
                    break;
                default:
                    HasTail = true;
                    HasTusks = false;
                    HasHorns = false;
                    NbrOfLegs = 4;
                    break;
            }
        }

        public override void Intro()
        {
            base.Intro();

            if (HasHorns == true)
                Console.WriteLine("I have horns");
            else
                Console.WriteLine("I have no horns");

            if (HasTail == true)
                Console.WriteLine("I have tail");
            else
                Console.WriteLine("I have no tail");

            if (HasTusks == true)
                Console.WriteLine("I have tusks");
            else
                Console.WriteLine("I have no tusks");

            Console.WriteLine("I have {0} legs", NbrOfLegs);
        }
    }
}
