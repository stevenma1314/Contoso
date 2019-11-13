using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Services;
using Contoso.Models;
using Contoso.MVC.Filters;


namespace Contoso.MVC.Controllers
{
    [ContosoExceptionFilter]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        // GET: Department

        public ActionResult Index()
        {
            var departments = _departmentService.GetAllDepartment();
            //ViewData["depts"] = departments;
            ViewBag.DepartmentCount = departments.Count();
            return View(departments);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            // get the data from formCillection and call service layer
            // save to database 
            try
            {
                //var departmentName = form["departname"];
                //var budget = form["budget"];
                //var satrdate = form["startdate"];
                //Department department = new Department();
                //department.Name = departname;
                //department.BUdget = budget;
                //department.StartDate = startdate;
                //department.InstructorId = 2;


                //department.RowVersion = "dcscs";
                //department.CreateDate = DateTime.Now;
                //department.CreatBy = "ssssd";
                //department.UpdatedDate = DateTime.Now;
                //department.UpdateBy = "uceindeun";
                _departmentService.CrateDepartment(department);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }


        }
        public ActionResult Edit(int id)
        {
            var department =  _departmentService.GetDepartmentById(id);
            return View(department);
        }
    }
}