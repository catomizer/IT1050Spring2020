using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Sprint1
{
    class Cat
    {
        string name;
        string color;
        string ID;
        int age;

        bool hungry;
        bool sleepy;

        //Default constructor
        public Cat()
        {
            age = 0;
            name = "No name yet";
            color = "none";
            ID = "Not assigned";

            hungry = false;
            sleepy = false;
        }

        //Constructor with parameters
        public Cat(string cName, string cColor, int cAge, string cID)
        {
            name = cName;
            age = cAge;
            color = cColor;
            ID = cID;

            hungry = false;
            sleepy = false;
        }

        //method #1
        public void intro()
        {
            Console.WriteLine("Hi My name is {0}. My age is {1}. My fur color is {2} and my ID is {3}", name, age,color, ID);
        }

        public void play()
        {
            Console.WriteLine("I love to play. Come join me!");
        }

        public void eat()
        {
            Console.WriteLine("Thanks for feeding me!");
        }

        public void sleep()
        {
            Console.WriteLine("I am tired! Zzzzz");
        }
    }
}
