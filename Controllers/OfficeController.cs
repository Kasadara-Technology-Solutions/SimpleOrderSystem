using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleOrderSystem.Models;
using SimpleOrderSystem.Services;

namespace SimpleOrderSystem.Controllers
{
    public class OfficeController : Controller
    {
        OfficeService Oc = new OfficeService();
        //POST api
        [HttpPost]
        [ActionName("CreateOffice")]
        public void CreateOffice(Office office)
        {
            Oc.CreateOffice(office);
        }

        //PUT api
        [HttpPut]
        [ActionName("EditOffice")]
        public void EditOffice(Office office)
        {
            Oc.EditOffice(office);
        }
    }
}