using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleOrderSystem.Services;
using SimpleOrderSystem.Models;


namespace SimpleOrderSystem.Controllers
{
    public class OrdersController : Controller
    {
        OrderServices os = new OrderServices();
        //GET api
        [HttpGet]
        [EnableCors(origins: "http://localhost:5500", headers: "*", methods: "*")]
        public JsonResult GetAllOrders()
        {
            var orders = os.GetAllOrders();
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        public JsonResult GetOrderById(int ID)
        {
            var orders = os.GetOrderById(ID);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        public JsonResult GetOrdersByCustomerId(int id)
        {
            var orders = os.GetOrdersByCustomerId(id);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        public JsonResult ListOrdersBySalesRepresentative(int id)
        {
            var orders = os.ListOrdersBySalesRepresentative(id);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        public JsonResult ListOrdersBySalesOffice(int id)
        {
            var orders = os.ListOrdersBySalesOffice(id);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }
        //POST api
        [HttpPost]
        [ActionName("CreateOrder")]
        public void CreateOrder(Order order)
        {
            os.CreateOrder(order);
        }
        //PUT api
        [HttpPut]
        [ActionName("EditOrder")]
        public void EditOrder(Order order)
        {
            os.EditOrder(order);
        }




    }
}