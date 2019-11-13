using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
    public class InstructorRepository
    {
        ContosoDbContext db = new ContosoDbContext();
        public Instructor GetInstructorByID(int dt)
        {
            return db.Instructor.FirstOrDefault(d => d.Id == dt);


        }
        public IEnumerable<Instructor> GetAllInstructor()
        {
            return db.Instructor.ToList();
        }
        public Instructor GetInstructorByName(string nm)
        {
            return db.Instructor.FirstOrDefault(d => d.FirstName == nm);
        }

        public Instructor getHighestInstructor()
        {
            return db.Instructor.OrderByDescending(d => d.Id).FirstOrDefault();
        }

        public void Create(Instructor instructor)
        {
            using (var db = new ContosoDbContext())
            {
                db.Instructor.Add(instructor);
                db.SaveChanges();

            }
        }
        public void Update()
        {
        }
    }
}
