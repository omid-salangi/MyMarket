using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Application.ViewModel;
using Domain.Interface;
using Domain.Models;

namespace Application.Services
{
    public class CourseService : ICourseServices
    {
        private ICourseRepository _CourseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this._CourseRepository = courseRepository;
        }

        public CourseViewModel getcCourses()
        {
            return new CourseViewModel()
            {
                Courses = _CourseRepository.getCourses() // object initializer 
            };
        }
    }
}
