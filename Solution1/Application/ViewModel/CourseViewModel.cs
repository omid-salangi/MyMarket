using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Courses> Courses { get; set; }
    }
}
