using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Demo1
{
    class Cat
    {
        static int catsForAdoption;//hold the count of how many cats are available for adoption
        public static int CatsForAdoption
        {
            get {
                return catsForAdoption;
            }
            set {
                catsForAdoption = value;
            }
        }

        //members/fields
        string name;
        //string color; This is not required as we are using autoimplemented property for color
        string id;
        int age;
        int cookies;
        double cupsOfKibble;

        bool hungry;//internal variable
        bool sleepy;//internal variable

        public string AdoptionStatus { get; set; }
        public string Owner { get; set; }
        public DateTime DateOfAdoption { get; set; }

        //Properties are public
        //Setter and Getter 
        public string Name
        {
            get { return name; }//when the user asks for a cat's name
            set { name = value.ToUpper(); }//when the user sets the cat's name
        }

        public string Color { get; set; } //Auto implemented property

        public string Id
        {
            get { return id; }//default

            set
            {
                //add validation for id length = 4 here
                if (value.Length == 4)
                    id = value;
                else
                {
                    id = "NONE";
                    Console.WriteLine("Invalid ID. Id has to be 4 characters in length");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {

                if (value < 0)
                {
                    age = 0;
                    Console.WriteLine("Age is negative and is an invalid input. So changing it to 0");
                }
                else
                    age = value;
            }
        }


        //Default constructor
        public Cat()
        {
            Age = 0;
            Name = "No name yet";
            Color = "none";
            Id = "None";
            hungry = false;
            sleepy = false;

            //food
            cookies = 5;
            cupsOfKibble = 5.0;

            AdoptionStatus = "Available";
            CatsForAdoption++;
        }

        //Constructor with parameters
        public Cat(string cName, string cColor, int cAge, string cID)
        {
            Name = cName;
            Age = cAge;
            Color = cColor;
            Id = cID;
            hungry = false;
            sleepy = false;

            //food
            cookies = 5;
            cupsOfKibble = 5.0;
            AdoptionStatus = "Available";
            CatsForAdoption++;

        }

        //method #1
        public void intro()
        {
            Console.WriteLine("Hi My name is {0}. My age is {1}. My fur color is {2} and my ID is {3}", Name, Age, Color, Id);
        }

        public bool play()
        {
            bool didCatPlay = false;
            if (hungry)
            {
                Console.WriteLine("I dont want to play. I am hungry. Feed me");
                didCatPlay = false;
            }
            else if (sleepy)
            {
                Console.WriteLine("I dont want to play. I am sleepy. Sing a lullaby!");
                didCatPlay = false;
            }
            else
            {
                Console.WriteLine("Lets play!");
                hungry = true;
                didCatPlay = true;
            }
            return didCatPlay;
        }

        public bool eat(int cookieCount, double kibbleCount)
        {
            bool didCatEat = false;//initialize the flag                  

            //this method will say if cat ate (true) or not (false)
            if (hungry)
            {
                if (cookieCount <= 0 && kibbleCount <= 0)
                {
                    //invalid 
                    Console.WriteLine("Invalid cookie count and kibble count. Please feed me properly!");
                    didCatEat = false;
                }
                else
                {
                    //valid
                    Console.WriteLine("Thanks for feeding me. I ate a lot and am not hungry anymore.");
                    hungry = false;//cat is no longer hungry
                    didCatEat = true;
                    sleepy = true;
                    RecalcFood(cookieCount, kibbleCount);
                }
            }
            else
            {
                Console.WriteLine("No thanks! I am not hungry now.");
                didCatEat = false;
            }

            return didCatEat;
        }

        void RecalcFood(int cookie, double kibble)
        {
            //if i try to feed cookies more than available
            if (cookie > cookies)
                cookies = 0;//feed what you can
            else
                cookies = cookies - cookie;

            if (kibble > cupsOfKibble)
                cupsOfKibble = 0;
            else
                cupsOfKibble = cupsOfKibble - kibble;
        }

        public bool sleep()
        {
            bool didCatSleep = false;

            if (sleepy)
            {
                Console.WriteLine("I am tired! Zzzzz");
                sleepy = false;
                didCatSleep = true;
            }
            else
            {
                Console.WriteLine("I am not tired! Can we play???");
            }

            return didCatSleep;
        }

        public bool Adopt(string owner, DateTime date)
        {
            if (AdoptionStatus == "Available")
            {
                AdoptionStatus = "Adopted";
                Owner = owner;
                DateOfAdoption = date;
                CatsForAdoption--;
                Console.WriteLine("Adoption was successful!");
                return true;
            }

            Console.WriteLine("Adoption was NOT successful!");
            return false;
        }

       

    }
}
