using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleOrderSystem.Models;
using SimpleOrderSystem.Services;
using ActionNameAttribute = System.Web.Http.ActionNameAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace SimpleOrderSystem.Controllers
{
    public class CustomerController : Controller
    {
        CustomerService Cc = new CustomerService();
        //POST api
        [HttpPost]
        [ActionNameAttribute("CreateCustomer")]
        public void CreateCustomer(Customer customer)
        {
            Cc.CreateCustomer(customer);
        }
        //PUT api
        [HttpPut]
        [ActionNameAttribute("EditCustomer")]
        public void EditCustomer(Customer customer)
        {
            Cc.EditCustomer(customer);
        }
    }
}