using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoTwo
{
    abstract class Animal
    {   
        public string Species { get; set; }

        public int NbrOfLegs { get; set; }

        public bool HasTail { get; set; }
        public bool HasHorns { get; set; }
        public bool HasFins { get; set; }
        public bool HasFeathers { get; set; }

        private string family;
       
        public string Family
        {
            get { return family; }
            set
            {
                family = value;
                SetFamilyTraits();
            }
        }

        public Animal():this("None","None")
        {           
        }

        public Animal(string species) :this(species,"None")
        {        
        }

        public Animal(string species, string family)
        {
            Species = species;
            Family = family;
        }

        public abstract void SetFamilyTraits();

        public virtual void Intro()//non-abstract method
        {
            Console.WriteLine("Species {0} Family{1}", Species, Family);
        }
    }
}
