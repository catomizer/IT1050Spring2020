﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14Demo
{
    class Student : Person
    {
        //Autoimplemented properties
        public string Id { get; set; }
        public string SchoolName { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public string Status { get; set; }
        public double GPA { get; set; }
        public DateTime LastAttended { get; set; }
        public List<Enrollment> EnrollmentList = new List<Enrollment>();
       
        public Student() : base() //Constructor with no arguments
        {
            //base constructor gets called first
            Id = "Unassigned";
            GPA = 0;
            Status = "active";
        }

        public Student(string fname, string lname, string ssn) : base(fname,  lname, ssn) //Constructor with 3 arguments
        {
            //base constructor gets called first
            Id = "Unassigned";
            GPA = 0;
            Status = "active";
        }
        public Student(string fname, string lname, string ssn, string sid, double sGPA) : base(fname, lname, ssn) //Constructor with 6 arguments
        {
            Id = sid;
            GPA = sGPA;
            Status = "active";
        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("I am student of {0} since {1}", SchoolName, DateOfEnrollment.Year);
        }

        public bool IsAcademicStandingGood()
        {
           if (GPA > 2.5)
                return true;//good standing

            return false;//bad standing
        }

        public double CalculateGPA(double grade1,double grade2, double grade3, double grade4, double grade5)
        {
            GPA = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            return GPA;
        }

        public void DetermineCurrentStatus()
        {
            double days = (DateTime.Today - LastAttended).TotalDays;
            

            if (days > 180)
            {
                Status = "Inactive";
            }
            else
            {
                Status = "Active";
            }
            Console.WriteLine("Student enrollment status: {0}", Status);
        }

        public void DisplayEnrolledCourses()
        {
            Console.WriteLine("List of courses enrolled by Student #{0}:", Id);

            foreach(Enrollment e in EnrollmentList)
            {
                Console.WriteLine("{0} {1} {2}",e.CourseEnrolled.Title, e.EnrolledDate, e.Status);
            }
        }
        public void Register(Course c) {
            Enrollment e = new Enrollment(c);
            EnrollmentList.Add(e);//We link enrollment in a course to the student
        }

        public void Drop(Course c)
        {
            Enrollment e = EnrollmentList.Find(o => o.CourseEnrolled.Id == c.Id);
            EnrollmentList.Remove(e);
        }

        public void Pass(Course c)
        {
            EnrollmentList.SingleOrDefault(o => o.CourseEnrolled.Id == c.Id).Status = "Passed";            
        }
        public void Fail(Course c)
        {
            EnrollmentList.SingleOrDefault(o => o.CourseEnrolled.Id == c.Id).Status = "Failed";
        }
    }
}
