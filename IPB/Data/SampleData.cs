using IPB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Data
{
    public static class SampleData
    {
        public static List<Student> Students = new() { 
            new Student { 
                FirstName="lukas",
                LastName="Wojciechowski",
                Email="s20@pjwstk.edu.pl",
                DateOfBirth = new DateTime(200,2,2),
                Password = "123"
            },
            new Student
            {
                FirstName = "Viktor",
                LastName = "Lishchuk",
                Email = "s208@pjwstk.edu.pl",
                DateOfBirth = new DateTime(1996, 10, 27),
                Password = "qwerty"
            },
        };
    }
}
