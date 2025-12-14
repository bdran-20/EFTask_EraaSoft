using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }

    public class Resource
    {
        public int ResourceId { get; set; }
        [Column(TypeName = "nvarchar(55)")]
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }

        public ResourceType Type { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
