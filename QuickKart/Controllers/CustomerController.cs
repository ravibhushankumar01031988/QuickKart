using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickKartDataAccessLayer.Models;
using QuickKartDataAccessLayer;

namespace QuickKart.Controllers
{
    public class CustomerController : Controller
    {
        private readonly QuickKartRepository _repoObj;

        public CustomerController(QuickKartRepository repObj)
        {
            _repoObj = repObj;
        }
        public IActionResult CustomerHome()
        {
            List<string> lstProducts = new List<string>();
            lstProducts.Add("Dell Inspiron");
            lstProducts.Add("HP");
            lstProducts.Add("Lenevo");
            ViewBag.TopProducts = lstProducts;
            return View();
        }
    }
}