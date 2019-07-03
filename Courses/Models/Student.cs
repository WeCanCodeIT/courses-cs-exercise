using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<StudentCourse> StudentCourses { get; set; }
    }
}
