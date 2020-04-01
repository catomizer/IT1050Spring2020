using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cat has a name, id, color and age.
                1. name has to be displayed as uppercase when stored.
                2. id has to be 4 characters long.
                3. age cannot be negative.             

            Actions:
            1. When cat eats, he is not hungry anymore.
            2. When cat is not hungry, he doesn't want to eat. 
            3. When cat is hungry, he doesn't want to play. 
            4. When the cat plays, he gets hungry.
            5. When cat is sleepy he doesn't want to play.
            */
            

            Cat myCat = new Cat();//Create an object
            myCat.Name = "Tim";
            myCat.Color = "grey";
            myCat.Id = "A";//This is not 4 characters so it should be changed to "None"
            myCat.Id = "AAA2";//This should be retained
            myCat.Age = -4;//Invalid
            myCat.Age = 4;//Valid
            myCat.intro();

            Cat fluff = new Cat("fluff", "orange", 4, "A332");//Object name is fluff
            fluff.intro();
            fluff.play();//hungry=true
            fluff.eat(0,0);//hungry=false;
            fluff.eat(2, 1.5);//hungry=false
            fluff.sleep();
            fluff.play();
            fluff.eat(40, 40);
            

            Cat myCat2 = new Cat("snowbell", "white", 1, "R333");//Object name is myCat2
            myCat2.intro();
            myCat2.sleep();            

            Cat myCat3 = new Cat("stripey", "black", 6, "S123");//Object name is fluff
            myCat3.intro();
            bool result = myCat3.eat(1,1);

            Console.ReadKey();
        }
    }
}
