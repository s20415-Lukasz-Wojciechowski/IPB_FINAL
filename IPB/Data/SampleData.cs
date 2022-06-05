using IPB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Data
{
    public static class SampleData
    {
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static List<Student> Students = new()
        {
            new Student
            {
                FirstName = "lukas",
                LastName = "Wojciechowski",
                Email = "s20@pjwstk.edu.pl",
                DateOfBirth = new DateTime(200, 2, 2),
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

        public static List<Teacher> Teachers = new()
        {
            new Teacher
            {
                FirstName = "Jan",
                LastName = "Nowak",
                Email = "JNow@pjwstk.edu.pl",
                DateOfBirth = new DateTime(1966, 10, 27),
                Password = "qwerty123",
                Students = new HashSet<Student>(SampleData.Students)
            }
        };
    }
}
