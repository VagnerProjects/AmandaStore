using AmandaStore.Domain.Entitys;
using AmandaStore.Model;
using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.AppServices.Interfaces
{
    public interface IAppServiceCliente: IAppService<Cliente>
    {
        Task<IServerStatus> AdicionarCliente(ClienteModel userModel);
    }
}
