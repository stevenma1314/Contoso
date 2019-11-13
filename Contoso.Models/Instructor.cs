using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models

{
    [Table("Instructor")]
    public class Instructor: Person
    {
        public DateTime HireDate { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
        public  ICollection<Course> Courses { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
