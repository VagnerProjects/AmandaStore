using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Interfaces;
using AmandaStore.Domain.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Repositorios
{
    public class RepositorioUsuario : Repository<Usuario>, IRepositoryUsuario
    {
        public void AdicionarUsuario(Usuario usuario)
        {
            Adicionar(usuario);
        }
    }
}
