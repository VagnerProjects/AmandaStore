using AmandaStore.Domain.Repositorios;
using AmandaStore.Domain.Repositorios.Interfaces;
using AmandaStore.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore
{
    public class DependencyInjection
    {
        public static void Dependencias(IServiceCollection services)
        {
            services.AddScoped<IRepositoryProduto, RepositorioProduto>();
            services.AddScoped<IServiceProduto, ServiceProduto>();
        }
    }
}
