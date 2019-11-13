using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class CourseService
    {
        CourseRepository Courserepo = new CourseRepository();


        public Course GetCourseByID(int id)
        {
            return Courserepo.GetCourseByID(id);
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return Courserepo.GetAllCourse();
        }
        public Course GetCourseByName(string name)
        {
            return Courserepo.GetCourseByName(name);
        }

        public Course GetHighestCreditOne()
        {
            return Courserepo.getHighestCredits();
        }
        public void Create( Course course)
        {
           Courserepo.Create(course);
        }

        
    }
}
