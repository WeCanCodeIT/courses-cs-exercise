using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class InstructorController : Controller
    {

        IRepository<Instructor> instructorRepo;

        public InstructorController(IRepository<Instructor> instructorRepo)
        {
            this.instructorRepo = instructorRepo;
        }

        public ViewResult Index()
        {
            var model = instructorRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = instructorRepo.GetById(id);
            return View(model);
        }
    }
}
