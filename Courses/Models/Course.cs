﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Course
    {
        public string Name { get; set; }

        public Course()
        {
        }

        public Course(string name)
        {
            Name = name;
        }
    }
}