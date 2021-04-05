using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Repositorios.Interfaces
{
    interface IRepositoryUsuario: IRepository<Usuario>
    {
        void AdicionarUsuario(Usuario usuario);
    }
}
