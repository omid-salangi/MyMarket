using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public string ImageUrl { get; set; }
    }
}
