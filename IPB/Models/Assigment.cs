using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Models
{
    public class Assigment
    {
        public Teacher Teacher{get;set;}
        public HashSet<Requirements> Requirements { get; set; } = new HashSet<Requirements>();
        public HashSet<Student> Students { get; set; } = new HashSet<Student>();
        public HashSet<Project> Projects { get; set; } = new HashSet<Project>();
        public DateTime DateTime { set; get; }
        public string Description { set; get; }
        public double MaxPoints { set; get; }

        public double GetPointFromQualityTest()
        {
            var rand = new Random();
            return rand.NextDouble()+0.01;
        }
    }
}
