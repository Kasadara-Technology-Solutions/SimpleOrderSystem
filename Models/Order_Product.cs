using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOrderSystem.Models
{
    public class Order_Product
    {
        public int ID { get; set; }
        public int OrderID{ get; set; }
        public int ProductCode { get; set; }
        public int Qty { get; set; }
        public int PriceEach { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
    }
}