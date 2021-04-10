using Microsoft.Extensions.DependencyInjection;
using SimpleCrud.Application.Services;
using SimpleCrud.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
