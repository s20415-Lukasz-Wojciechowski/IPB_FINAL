using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Models
{
    public class Project
    {
        public Student Student{get;set;}
        public Assigment Assigment { get; set; }
        public double Points { set; get; }
        public string StudentWork { set; get; }

        public void Submit()
        {
           //push points to server

        }
    }
}
