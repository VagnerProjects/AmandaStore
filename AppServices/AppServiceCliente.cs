using AmandaStore.AppServices.Interfaces;
using AmandaStore.Domain.Entitys;
using AmandaStore.Model;
using AmandaStore.Services.Interfaces;
using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.AppServices
{
    public class AppServiceCliente : AppService<Cliente>, IAppServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        public AppServiceCliente(IServiceCliente serviceCliente):base(serviceCliente)
        {
            _serviceCliente = serviceCliente;
        }
        public async Task<IServerStatus> AdicionarCliente(ClienteModel clienteModel)
        {
           return await _serviceCliente.AdicionarCliente(clienteModel);
        }
    }
}
