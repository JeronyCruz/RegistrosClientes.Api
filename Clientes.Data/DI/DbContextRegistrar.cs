using Clientes.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Data.DI
{
    public static class DbContextRegistrar
    {
        public static IServiceCollection RegisterDbContextFactory(this IServiceCollection services)
        {
            services.AddDbContextFactory<ClientesContext>(o => o.UseSqlServer("Name=SqlConStr"));
            return services;
        }
    }
}
