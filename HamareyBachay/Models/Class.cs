using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HamareyBachay.Models
{
    public class Class
    {
        [Key]
        [Column(Order = 1)]
        public int ClassId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int SectionId { get; set; }
        public int MinAgeLimit { get; set; }
        public int MaxAgeLimit { get; set; }
        public int NumOfStudents { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<Student> Students { get; set; }
        public Class()
        {
            this.Students = new HashSet<Student>();
        }
    }
}