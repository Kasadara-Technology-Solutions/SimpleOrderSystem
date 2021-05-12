using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOrderSystem.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Status { get; set; }
        public string Comments { get; set; }
        public Customer customer { get; set; }
        public virtual List<Order_Product> Order_Products { get; set; }
    }
}