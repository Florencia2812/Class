using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClassRamirez.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ClassRamirez.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<ClassRamirez.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<ClassRamirez.Models.Enrollment> Enrollments { get; set; }
    }
}