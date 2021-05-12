using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleOrderSystem.Models;
using SimpleOrderSystem.Services;


namespace SimpleOrderSystem.Controllers
{
    public class ProductController : Controller
    {
        ProductService Ps = new ProductService();
        //GET api
        [HttpGet]
        [ActionName("GetAllProducts")]
        public JsonResult Get()
        {
            var products = Ps.GetAllProducts();
            return Json(new { products = products }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        [ActionName("GetProductsById")]
        public JsonResult Get(int id)
        {
            var products = Ps.GetProductsById(id);
            return Json(new { products = products }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        [ActionName("GetProductByName")]
        public JsonResult Get(string name)
        {
            var product = Ps.GetProductByName(name);
            return Json(new { product = product }, JsonRequestBehavior.AllowGet);
        }
        //GET api
        [HttpGet]
        [ActionName("GetProductsByOrderId")]
        public JsonResult GetProductsByOrderId(int id)
        {
            var products = Ps.GetProductsByOrderId(id);
            return Json(new { products = products }, JsonRequestBehavior.AllowGet);
        }
        //POST api
        [HttpPost]
        [ActionName("CreateProduct")]
        public void CreateProduct(Product product)
        {
            Ps.CreateProduct(product);
        }
        //PUT api
        [HttpPut]
        [ActionName("EditProduct")]
        public void EditProduct(Product product)
        {
            Ps.EditProduct(product);
        }
    }

}