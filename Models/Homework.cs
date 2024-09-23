using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Homework
    {
        public int HomeworkID { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public string SubmissionTime { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    }
}
