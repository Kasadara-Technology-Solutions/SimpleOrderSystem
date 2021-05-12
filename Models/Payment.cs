using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOrderSystem.Models
{
    public class Payment
    {
        public string CheckNum { get; set; }
        public int CustomerID { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }

    }
}