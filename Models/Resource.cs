using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Resource
    {
        public int ResourceID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ResourceType { get; set; }
        public Course Course { get; set; }
        public int CourseID { get; set; }
    }
}
