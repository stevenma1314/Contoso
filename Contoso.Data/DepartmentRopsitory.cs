using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
   public class DepartmentRopsitory : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRopsitory(ContosoDbContext context) : base(context)
        {
        }

        public Department GetDepartmentByname(string name)
        {
            var department = _dbContext.Department.FirstOrDefault(d => d.Name == name);
            return department;
        }
    }
    public interface IDepartmentRepository:IRepository<Department>
    {
        Department GetDepartmentByname(string name);    
    }
}
