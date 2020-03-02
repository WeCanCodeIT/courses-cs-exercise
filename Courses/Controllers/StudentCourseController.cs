using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class StudentCourseController : Controller
    {
        IRepository<StudentCourse> studentCourseRepo;
        
        public StudentCourseController(IRepository<StudentCourse> studentCourseRepo)
        {
            this.studentCourseRepo = studentCourseRepo;
        }
    }
}
