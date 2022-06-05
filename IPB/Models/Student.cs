using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Models
{
    public class Student : Person
    {
        private static int INDEX_NUMBER = 0;
        public string StudentNumber { get; } = "s" + INDEX_NUMBER++;
        public HashSet<Project> projects { get; set; } = new HashSet<Project>();
        public Teacher? Teacher { get; set; }
        public HashSet<Assigment> Assigments { get; set; } = new HashSet<Assigment>();

       
    }
}
