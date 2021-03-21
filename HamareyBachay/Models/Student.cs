using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamareyBachay.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public char gender { get; set; }
        public DateTime DOB { get; set; }
        public int age { get; set; }

        public Student()
        {

        }
    }
}
