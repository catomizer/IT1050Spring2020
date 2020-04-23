using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14Demo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Student s1 = new Student("Jim", "Carrey", "43242423", "S0039333", 3.0);
            s1.SchoolName = "Tri-C";
            s1.DateOfEnrollment = Convert.ToDateTime("01/01/2018");
            s1.Email = "jcarrey123@gmail.com";
            s1.PhoneNumber = "3330293030";
            s1.SetAddress("1234 Main St", "Apt 202", "Parma", "OH", "44554");
            s1.Intro();

            Student s2 = new Student("Joanna", "Smith", "767567657", "S0034333", 4.0);
            s2.SchoolName = "Tri-C";
            s2.DateOfEnrollment = Convert.ToDateTime("01/01/2018");
            s2.Intro();

            Course c1 = new Course("IT1050", "Programming Logic", 3, "Online");
            Course c2 = new Course("IT1150", "Intro to Web Programming", 3, "In-Person");
            Course c3 = new Course("IT2360", "Intro to Java Programming", 4, "In-Person");
            Course c4 = new Course("IT1025", "Intro to Computers", 3, "Blended");
            Course c5 = new Course("IT2030", "Intro to ASP Programming", 3, "Online");

            s1.Register(c1);
            s1.Register(c3);
            s1.Register(c5);
            s1.DisplayEnrolledCourses();

            s2.Register(c1);
            s2.Register(c2);
            s2.DisplayEnrolledCourses();

            s1.Drop(c1);
            s1.Pass(c3);
            s1.Fail(c5);
            s1.DisplayEnrolledCourses();

            Console.ReadKey();
        }
    }
}
