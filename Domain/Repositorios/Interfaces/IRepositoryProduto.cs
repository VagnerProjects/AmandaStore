using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Repositorios.Interfaces
{
    public interface IRepositoryProduto: IRepository<Produto>
    {
        void AdicionarProduto(Produto produto);
    }
}
