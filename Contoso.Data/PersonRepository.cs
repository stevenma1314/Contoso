using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.Data;

namespace Contoso.Data
{
    public class PersonRepository
    {
        ContosoDbContext db = new ContosoDbContext();

        public Person GetPersonByID(int dt)
        {
            return db.Person.FirstOrDefault(d => d.Id == dt);

        }
        public IEnumerable<Person> GetAllPeople()
        {
            return db.Person.ToList();
        }
        public Person GetPersonByName(string nm)
        {
            return db.Person.FirstOrDefault(c => c.FirstName == nm);
        }

        public Person getHighestId()
        {
            return db.Person.OrderByDescending(d => d.Id).FirstOrDefault();
        }
        public void Create(Person person)
        {
            using (var db = new ContosoDbContext())
                db.Person.Add(person);
                db.SaveChanges();
             

        }
    }
}
