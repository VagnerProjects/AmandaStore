using AmandaStore.Domain.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmandaStore.Domain.Entitys;

namespace AmandaStore.Domain.Repositorios
{
    public class RepositorioProduto : Repository<Produto>, IRepositoryProduto
    {
        public void AdicionarProduto(Produto produto)
        {
            Adicionar(produto);
        }
    }
}
