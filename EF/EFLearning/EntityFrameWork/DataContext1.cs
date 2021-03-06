﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EntityFrameWork;

namespace EntityFrameWorkSTV
{
    public class DataContext1 : DbContext
    {
        public DataContext1() : base("DataContext")
        {            
        }
    
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
