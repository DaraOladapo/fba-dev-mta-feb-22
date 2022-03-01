using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            var car = new Car() { Make = "Toyota", Model = "RAV4" };
            return View(car);
        }
    }
}
