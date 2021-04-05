using AmandaStore.Services.Identidade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Identidade.Interface
{
    public interface IServiceIdentidade
    {
        string EnviarIdentidade(UsuarioRegistro autenticacao);
    }
}
