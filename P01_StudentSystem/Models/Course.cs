using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Column(TypeName = "nvarchar(80)")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }


        public ICollection<Student> StudentsEnrolled { get; set; } = new List<Student>();
        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new List<Homework>();
    }
}
