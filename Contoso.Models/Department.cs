
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models

{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BUdget { get; set; }
        public DateTime StartDate { get; set;}

        public int InstructorId {get; set; }
        public string RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdateBy { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Course> Courses { get; set; }



    }
}
