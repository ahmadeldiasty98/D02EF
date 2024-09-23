using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=StudentEFD02; Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(c => new { c.StudentID, c.CourseID });
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode(true);
            modelBuilder.Entity<Student>()
                .Property(s => s.PhoneNumber)
                .HasColumnType("varchar(10)")
                .IsUnicode(false);
        }
    }
}
