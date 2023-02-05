using Microsoft.AspNetCore.Mvc;
using IS413_Mission04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IS413_Mission04.Controllers
{
    public class NEEEEEwController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculator model)
        {
            return View();
        }
    }
}
