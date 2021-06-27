using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Application.ViewModel;

namespace MyMarket.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseServices _courseServices;

        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseServices.getcCourses();
            return View(model);
        }
    }
}
