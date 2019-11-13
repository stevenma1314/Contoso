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


    public class CourseController : Controller
    {
        private CourseService courseService;
        // GET: 
        public CourseController()
        {
            courseService = new CourseService();
        }
        public ActionResult Index()
        {
          
            var Courses = courseService.GetAllCourses();
            ViewBag.CourseCount = Courses.Count();
            return View(Courses);
        }
        [HttpGet]
        public ActionResult CreateCourse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCourse(Course course)
        {
             courseService.Create(course);
            return RedirectToAction("Index");
        }
    }
}