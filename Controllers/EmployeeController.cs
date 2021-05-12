using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleOrderSystem.Models;
using SimpleOrderSystem.Services;

namespace SimpleOrderSystem.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService Es = new EmployeeService();
        //POST api
        [HttpPost]
        [ActionName("CreateEmployee")]
        public void CreateEmployee(Employee employee)
        {
            Es.CreateEmployee(employee);
        }
        //PUT api
        [HttpPut]
        [ActionName("EditEmployee")]
        public void EditEmployee(Employee employee)
        {
            Es.EditEmployee(employee);
        }
    }
}