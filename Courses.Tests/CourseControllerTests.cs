using Courses.Controllers;
using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;
using NSubstitute;
using Courses.Repositories;

namespace Courses.Tests
{
    public class CourseControllerTests
    {
        CourseController underTest;
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Course>>();
            underTest = new CourseController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_CourseModel_To_View()
        {
            var result = underTest.Index();

            Assert.IsType<List<Course>>(result.Model);
        }

    }
}
