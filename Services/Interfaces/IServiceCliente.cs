using AmandaStore.Domain.Entitys;
using AmandaStore.Model;
using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Interfaces
{
    public interface IServiceCliente: IService<Cliente>
    {
        Task<IServerStatus> AdicionarCliente(ClienteModel clienteModel);
    }
}
