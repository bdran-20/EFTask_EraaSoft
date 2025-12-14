using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        [Unicode(false)]
        [Column(TypeName ="nvarchar(10)")]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateOnly? Birthday { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new List<Homework>();
        
    }
}
