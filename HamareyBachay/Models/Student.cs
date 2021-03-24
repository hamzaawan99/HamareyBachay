using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamareyBachay.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        [Required]
        public string StudentName { get; set; }
        public char Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        
        [Required]
        public int Age { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public int ClassId { get; set; }

        public int SectionId { get; set; }

        public Class Class { get; set; }

        public Student()
        {

        }
    }
}
