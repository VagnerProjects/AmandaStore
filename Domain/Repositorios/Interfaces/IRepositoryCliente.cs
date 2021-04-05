using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Repositorios.Interfaces
{
    public interface IRepositoryCliente: IRepository<Cliente>
    {
        void AdicionarCliente(Cliente cliente);
    }
}
