using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StCourse.Model;

namespace StCourse.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if(ModelState.IsValid)
            { 
            Repository.AddStudent(student);
            return View("Thanks", student);
            }
            else
            {
                return View();
            }
        }
    }
}