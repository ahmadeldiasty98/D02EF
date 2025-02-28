﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string BirthDay { get; set; }
        public List<Homework> Homeworks { get; set; }
        public List<Course> Courses { get; set; }
    }
}
