
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models

{
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string AdressLine1 { get; set; }

        public ICollection<Role> Roles { get; set; }


    }
}
