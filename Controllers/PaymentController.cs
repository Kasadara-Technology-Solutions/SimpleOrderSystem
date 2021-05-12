using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleOrderSystem.Models;
using SimpleOrderSystem.Services;
//using ActionNameAttribute = System.Web.Http.ActionNameAttribute;
//using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
//using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace SimpleOrderSystem.Controllers
{
    public class PaymentController : Controller
    {
        PaymentService Ps = new PaymentService();
        //POST api
        [HttpPost]
        [ActionName("CreatePayment")]
        public void CreatePayment(Payment payment)
        {
            Ps.CreatePayment(payment);
        }
    }
}