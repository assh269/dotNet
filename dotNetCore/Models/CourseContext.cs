using System;
using Microsoft.EntityFrameworkCore;

namespace dotNetCore.Models
{
    public class CourseContext:DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options):base(options)
        {

        }

        public DbSet<Course> CourseList { get; set; }
    }
}
