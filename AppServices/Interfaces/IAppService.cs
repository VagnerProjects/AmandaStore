using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.AppServices.Interfaces
{
    public interface IAppService<TEntity>: IDisposable where TEntity:class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        TEntity Find(params object[] key);
        public void Excluir(Func<TEntity, bool> obj);
    }
}
