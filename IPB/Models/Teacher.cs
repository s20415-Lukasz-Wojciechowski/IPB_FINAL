using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Models
{
    public class Teacher : Person
    {
        public HashSet<Assigment> assigments { get; } = new HashSet<Assigment>();
        public HashSet<Student> Students { get; } = new HashSet<Student>();
    }
}
