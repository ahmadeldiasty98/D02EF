﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string price { get; set; }
        public List<Student> Students { get; set; }
        public List<Homework> Homeworks { get; set; }
        public List<Resource> Resources { get; set; }


    }
}
