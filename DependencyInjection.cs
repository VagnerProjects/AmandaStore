using AmandaStore.AppServices;
using AmandaStore.AppServices.Interfaces;
using AmandaStore.Domain.Repositorios;
using AmandaStore.Domain.Repositorios.Interfaces;
using AmandaStore.Services;
using AmandaStore.Services.Identidade;
using AmandaStore.Services.Identidade.Interface;
using AmandaStore.Services.Interfaces;
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
            services.AddScoped<IRepositoryUsuario, RepositorioUsuario>();
            services.AddScoped<IServiceUsuario, ServiceUsuario>();
            services.AddScoped<IRepositoryCliente, RepositorioCliente>();
            services.AddScoped<IServiceCliente, ServiceCliente>();
            services.AddScoped<IAppServiceCliente, AppServiceCliente>();
            services.AddScoped<IServiceIdentidade, ServiceIdentidade>();
          
        }
    }
}
