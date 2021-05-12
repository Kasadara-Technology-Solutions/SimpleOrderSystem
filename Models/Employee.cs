using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOrderSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int OfficeCode { get; set; }
        public int reportsTo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public Office office { get; set; }
      

    }
}