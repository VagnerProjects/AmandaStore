using AmandaStore.Domain.Interfaces;
using AmandaStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Serviços
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Excluir(Func<TEntity, bool> obj)
        {
            _repository.Excluir(obj);
        }

        public TEntity Find(params object[] key)
        {
            return _repository.Find(key);
        }
    }
}
