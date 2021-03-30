using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Interfaces
{
    public interface IService<TEntity>: IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        TEntity Find(params object[] key);
        public void Excluir(Func<TEntity, bool> obj);
    }
}
