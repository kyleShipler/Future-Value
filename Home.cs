using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch02FutureValueShipler2.Models;

namespace Ch02FutureValueShipler2.Controllers
{
    public class Home : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}
