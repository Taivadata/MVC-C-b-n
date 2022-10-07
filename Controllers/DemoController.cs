using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Test(){
            ViewBag.x = "Duc Tai!";
            Customer obj = new Customer();
            obj.id = 01; 
            obj.fullname = "Nguyen Duc Tai";
            obj.address = "Lai Vung = Đồng Tháp";

            return View(obj);
            
        }

        
        
    }
}