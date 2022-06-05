using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Models
{
    public class Assigment
    {
        public Teacher Teacher{get;set;}
        public HashSet<Requirements> Requirements { get; } = new HashSet<Requirements>();
        public HashSet<Project> Projects { get; } = new HashSet<Project>();
        public DateTime DateTime { set; get; }
        public string Description { set; get; }
        public double MaxPoints { set; get; }
    }
}
