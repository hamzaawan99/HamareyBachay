using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HamareyBachay.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        //[InverseProperty("Course")]
        //public List<Student> Students { get; set; }

        public Course()
        {

        }
    }
}
