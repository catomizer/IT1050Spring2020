using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14Demo
{
    class Course
    {   
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public string Modality { get; set; }
        
        public Course(string id, string title, int credit, string modality)
        {
            Id = id;
            Title = title;
            CreditHours = credit;
            Modality = modality;
        }
    }
}
