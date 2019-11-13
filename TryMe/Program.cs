using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Services;
using Contoso.Data;

namespace TryMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DepartmentRepository();
            Console.WriteLine(db.GetAllDepartment().Count());
            Console.WriteLine(db.GetDepartmentByID(7).Name);
            Console.WriteLine(db.GetDepartmentByName("edf").Name);
            Console.ReadLine();

            

        }
    }
}
