using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StCourse.Model;

namespace StCourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Course {Id=1,Name="C#" });
        }
    }
}