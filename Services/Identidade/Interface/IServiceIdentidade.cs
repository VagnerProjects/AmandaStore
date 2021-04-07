using AmandaStore.Services.Identidade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AmandaStore.Services.Identidade.Interface
{
    public interface IServiceIdentidade
    {
        Task<HttpResponseMessage> EnviarIdentidade(UsuarioRegistro autenticacao);
        Task<HttpResponseMessage> Login(UsuarioLogin usuarioLogin);
    }
}
