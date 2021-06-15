using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Data.Context;
using Domain.Interface;
using Domain.Models;

namespace CleanArch.Data.Repository
{
    public class CourseRepository:ICourseRepository // in model repositories
    {
        private UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Courses> getCourses()
        {
            return _context.Courses; // it will return a iqueryable
        }
    }
}
