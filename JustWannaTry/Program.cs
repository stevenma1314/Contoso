using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
namespace JustWannaTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DepartmentRepository();
            var db1 = db.GetDepartmentByID(1);
            Console.WriteLine(db1.Name);
            var db2 = db.GetAllDepartment();
            foreach (var item in db2)
            {
                Console.WriteLine(item.Name);
            }
            var db3 = db.GetDepartmentByName("TING");
            Console.WriteLine(db3.Name);
            var db4 = db.getHighestBudgetDepartment();
            Console.WriteLine(db4.Name);
        }
    }
}
