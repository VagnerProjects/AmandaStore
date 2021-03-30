using AmandaStore.Domain.Contexto;
using AmandaStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Repositorios
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected AmandaStoreDBContext ctx;

        public Repository()
        {
            ctx = new AmandaStoreDBContext();
        }
        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
            ctx.SaveChanges();
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            if (ctx != null)
            {
                ctx.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
            .Where(predicate).ToList()
            .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }
    }
}
