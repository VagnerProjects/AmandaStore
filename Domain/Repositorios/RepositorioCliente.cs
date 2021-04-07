using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Repositorios
{
    public class RepositorioCliente : Repository<Cliente>, IRepositoryCliente
    {
        public void AdicionarCliente(Cliente cliente)
        {
            Adicionar(cliente);
        }

        
    }
}
