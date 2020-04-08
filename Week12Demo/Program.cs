using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();
            Address myAddress1 = new Address("1623 mayflower dr","","Mayfield Hts", "OH", "44124");

            Person p1 = new Person();//Default constructor
            p1.Intro();
            p1.SetAddress("1980 Miner Road", "Apartment 1210", "Highland Hts", "OH", "44143");

            Person p2 = new Person("Tim", "Smith", "232323232");//3 argument constructor
            p2.Intro();
            if (p2.IsBirthday())
                Console.WriteLine("Happy Birthday");

            Student s1 = new Student();
            Student s2 = new Student("Tom", "Hanks", "23232232");
            Student s3 = new Student("Jim", "Carrey", "43242423", "S0039333", 3.0);
            s3.SchoolName = "Tri-C";
            s3.DateOfEnrollment = Convert.ToDateTime("01/01/2018");
            s3.Email = "jcarrey123@gmail.com";
            s3.PhoneNumber = "3330293030";
            s3.SetAddress("1234 Main St", "Apt 202", "Parma", "OH", "44554");
            s3.Intro();

            if (s3.IsAcademicStandingGood())
                Console.WriteLine("Academic standing is good");
            else
                Console.WriteLine("Academic standing is not good");

            s3.CalculateGPA(3.0, 2.7, 2.2, 2.1, 2.0);//bad GPA

            if (s3.IsAcademicStandingGood())
                Console.WriteLine("Academic standing is good");
            else
                Console.WriteLine("Academic standing is not good");

            s3.LastAttended = Convert.ToDateTime("01/01/2005");
            s3.DetermineCurrentStatus();

            s3.DateOfBirth = Convert.ToDateTime("04/08/2000");

            if (s3.IsBirthday())
                Console.WriteLine("Happy Birthday");

            Console.ReadKey();
        }
    }
}
