using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Interfaces
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        TEntity Find(params object[] key);
        public void Excluir(Func<TEntity, bool> obj);
    }
}
