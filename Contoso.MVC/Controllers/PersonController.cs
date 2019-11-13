using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Services;
using Contoso.Models;

namespace Contoso.MVC.Controllers
{

    public class PersonController : Controller
    {
        PersonService personService;
        public PersonController()
        {
            personService = new PersonService();
        }

        // GET: Person
        public ActionResult IndexPeople()
        {
            var people = personService.GetAllPeople();
            ViewBag.PersonCount = personService.GetAllPeople().Count();
            return View(people);
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePerson(Person p)
        {
            personService.CreatePerson(p);
            return RedirectToAction("IndexPeople");

        }


    }
}