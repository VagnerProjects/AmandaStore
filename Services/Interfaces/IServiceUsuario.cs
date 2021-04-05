using AmandaStore.Domain.Entitys;
using AmandaStore.Model;
using AmandaStore.Services.Interfaces;
using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Interfaces
{
    public interface IServiceUsuario: IService<Usuario>
    {
        Task<IServerStatus> AdicionarUsuario(UsuarioModel userModel);
    }
}
