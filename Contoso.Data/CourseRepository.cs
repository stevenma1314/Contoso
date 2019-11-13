using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
   public class CourseRepository
    {
        ContosoDbContext db = new ContosoDbContext();

        public Course GetCourseByID(int dt)
        {
            return db.Course.FirstOrDefault(d => d.Id == dt);

        }
        public IEnumerable<Course> GetAllCourse()
        {
            return db.Course.ToList();
        }
        public Course GetCourseByName(string nm)
        {
            return db.Course.FirstOrDefault(c => c.Title == nm);
        }

        public Course getHighestCredits()
        {
            return db.Course.OrderByDescending(d => d.Credits).FirstOrDefault();
        }
        public void Create(Course course)
        {
            using (var db = new ContosoDbContext()) ;
            db.Course.Add(course);
            db.SaveChanges();
            


        }


    }
}
