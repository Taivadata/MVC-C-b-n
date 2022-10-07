using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class Customer
    {   
        [DisplayName("Id KH")]
        public int id { get; set; }
        [DisplayName("Fullname")]
        public string fullname { get; set; }
        [DisplayName("Đia chi")]
        public string address { get; set; }
    }
}