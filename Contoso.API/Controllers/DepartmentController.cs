using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contoso.Services;
using Contoso.Models;

namespace Contoso.API.Controllers
{
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        //method 
        //geting 
        [HttpGet]
        [Route("")]
        public IEnumerable<Department> GetDepartments()
        {
            var department = _departmentService.GetAllDepartment();
            return department;
        }
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetDepartmentById(int id)
        {
            var department = _departmentService.GetDepartmentById(id); 
            if (department == null)
            {
                var response = Request.CreateResponse(HttpStatusCode.NotFound, "No Department Found");
                return ResponseMessage(response);
            }
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, department));
        }
    }
}
