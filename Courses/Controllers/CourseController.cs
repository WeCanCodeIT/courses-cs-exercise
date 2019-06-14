using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            CourseRepository courseRepo = new CourseRepository();

            var model = courseRepo.GetAll();

            return View(model);
        }
    }
}
