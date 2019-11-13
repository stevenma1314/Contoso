using System;
using Contoso.Services;
using Contoso.Models;
using Contoso.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;//MS test for unit test
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Moq;
//anotehr one called NUnit and other is Xunit. most popular three package for unit test

namespace Contoso.MVC.Tests.Services
{
    [TestClass]
    public class DepartmentServiceTest
    {
        private IDepartmentService _departmentService;
        private Mock<IDepartmentRepository> _mockDepartmentRepository;
        private List<Department> _departments;
        [TestInitialize]
        public void Initilize()
        {
            _mockDepartmentRepository = new Mock<IDepartmentRepository>();
            //automatically create the MockDepartmentRepository class in the runtime
            _departmentService = new DepartmentService(_mockDepartmentRepository.Object);
            _departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    Name = "CS",
                    BUdget = 300,
                    StartDate = DateTime.Now
                },
            new Department
            {
                Id = 2,
                Name = "HR",
                BUdget = 400,
                StartDate = DateTime.Now
            },
            new Department
            {
                Id = 3,
                Name = "FA",
                BUdget = 5990,
                StartDate = DateTime.Now
            },
            new Department
            {
                Id = 4,
                Name = "WC",
                BUdget = 500,
                StartDate = DateTime.Now
            }


            };
            _mockDepartmentRepository.Setup(d => d.GetAll()).Returns(_departments);
            _mockDepartmentRepository.Setup(d => d.GetById(It.IsAny<int>())).Returns((int s) => _departments.First(x => x.Id == s));
        }

        [TestMethod]
        public void CheckDepartmentCountFromFakeData() 
            // the name of test method normally are very lone like a sectence 
            //use data from memory to check the mothod 
        {
           // _departmentService = new DepartmentService(new MockDepartmentRepository());
            var department = _departmentService.GetAllDepartment();
            //AAA
            // first A Arrange: INitilize object, crate mock object , or instance
            // Second A Act : invoking the methods or properties 
            //third A　Assert: verify the action of method, make sure it behavies as expected 

            // what we gonna check ?
            //Assert come from MS test
            Assert.IsNotNull(department);
            Assert.AreEqual(4,department.Count());

           
        }
        [TestMethod]
        public void Check()
        {
            var department = _departmentService.GetDepartmentById(3);
            Assert.AreEqual("FA", department.Id);
        }
    }

    //public class MockDepartmentRepository : IDepartmentRepository
    //{
    //    public void Add(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department Get(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Department> GetAll()
    //    {
    //        var department = new List<Department>
    //        {
    //        new Department
    //        {
    //            Id=1,
    //            Name="CS",
    //            BUdget=300,
    //            StartDate=DateTime.Now
    //        },
    //        new Department
    //        {
    //            Id=2,
    //            Name="HR",
    //            BUdget=400,
    //            StartDate=DateTime.Now
    //        },
    //        new Department
    //        {
    //            Id=3,
    //            Name="FA",
    //            BUdget=5990,
    //            StartDate=DateTime.Now
    //        },
    //        new Department
    //        {
    //            Id=4,
    //            Name="WC",
    //            BUdget=500,
    //            StartDate=DateTime.Now
    //        }


    //        };
    //        return department;
    //    }

    //    public Department GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int GetCount(Expression<Func<Department, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department GetDepartmentByname(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Department> GetMany(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveChanges()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
