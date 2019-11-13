using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
   public class ContosoDbContext:DbContext
    {
        public ContosoDbContext() : base ("Name=ContosoDbContext")
        {
        }
        public DbSet<Department> Department { get; set;}
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Role> Role { get; set; }

        public DbSet<OfficeAssignment> OfficeAssignment { get; set; }








    }
}
