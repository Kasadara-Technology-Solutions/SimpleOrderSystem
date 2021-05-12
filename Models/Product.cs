using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOrderSystem.Models
{
    public class Product
    {
        public int Code { get; set; }
        public int ProductlineID { get; set; }
        public string Name { get; set; }
        public int Scale { get; set; }
        public string Vendor { get; set; }
        public string PdtDescription { get; set; }
        public int QtyInStock { get; set; }
        public float BuyPrice { get; set; }
        public string MSRP { get; set; }
        public Productline productline { get; set; }
    }
}