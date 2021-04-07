using AmandaStore.Services.Identidade.HTTP;
using AmandaStore.Services.Identidade.Interface;
using AmandaStore.Services.Identidade.Model;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace AmandaStore.Services.Identidade
{
    public class ServiceIdentidade : HTTPService, IServiceIdentidade
    {
        public ServiceIdentidade(IConfiguration configuration)
        {
            ConfigurarBaseUrl(configuration.GetSection("AppSettings")["IdentityUrl"]);
        }

        public async Task<HttpResponseMessage> EnviarIdentidade(UsuarioRegistro autenticacao)
        {
            var result = _httpClient.PostAsync($"/api/identidade/Nova-Identidade", ObterConteudo(autenticacao)).Result;

            
            return await Task.FromResult(result);
        }

        public async Task<HttpResponseMessage> Login(UsuarioLogin usuarioLogin)
        {
            var result = _httpClient.PostAsync($"/api/identidade/Login", ObterConteudo(usuarioLogin)).Result;

            return await Task.FromResult(result);
        }
    }
}
