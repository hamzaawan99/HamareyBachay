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
        [Key]
        public int CourseId { get; set; }
        
        [Required]
        public string CourseName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        //[InverseProperty("Course")]
        public ICollection<Student> Students { get; set; }

        public ICollection<Class> Classes { get; set; }

        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Classes = new HashSet<Class>();
        }
    }
}
