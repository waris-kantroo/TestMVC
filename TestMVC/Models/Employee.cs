using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public  string FullName { get; set; }
        public Address address { get; set; }
        public DateTime DOB { get; set; }

    }

    public class Address
    {
        public int telephone { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
        public SubAddress subAddress { get; set; }
    }

    public class SubAddress
    {
        public int telephone { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
    }
}