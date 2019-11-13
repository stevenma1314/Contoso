using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
   public class PersonService
    {
        PersonRepository repo = new PersonRepository();
        public Person PersonGetById(int id)
        {
            return repo.GetPersonByID(id);
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return repo.GetAllPeople();
        }

        public Person PersonByName(string name)
        {
            return repo.GetPersonByName(name);
        }

        public Person GetHighestId()
        {
            return repo.getHighestId();
        }

        public void CreatePerson(Person person)
        {
          repo.Create(person);
        }
    }
}
