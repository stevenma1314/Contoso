using Contoso.Data;
using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contoso.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
            // any class that impaement this interface can be passed in as paramter
        {
            _departmentRepository = departmentRepository;
        }


        public void CrateDepartment(Department department)
        {
            _departmentRepository.Add(department);
            _departmentRepository.SaveChanges();
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public Department GetDepartmentByName(string name)
        {
            return _departmentRepository.GetDepartmentByname(name);
        }

        public int GetTotallDepartmentCount()
        {
            throw new NotImplementedException();
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartment();
        int GetTotallDepartmentCount();
        Department GetDepartmentById(int id);
        Department GetDepartmentByName(string name);
        void CrateDepartment(Department department);

    }
    
}
