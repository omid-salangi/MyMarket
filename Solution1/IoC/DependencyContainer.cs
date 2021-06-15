using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Application.Services;
using CleanArch.Data.Repository;
using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            // application layer
            service.AddScoped<ICourseServices, CourseService>();

            //data layer
            service.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
