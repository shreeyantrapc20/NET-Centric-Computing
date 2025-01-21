//used for communicating with another project
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class AssemblyReference
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            return services;
        }
    }
}
