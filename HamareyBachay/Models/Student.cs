using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamareyBachay.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public char Gender { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public int Age { get; set; }

        //public int CourseId { get; set; }

        //public Course Course { get; set; }

        public Student()
        {

        }
    }
}
