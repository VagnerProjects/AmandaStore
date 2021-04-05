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

namespace AmandaStore.Services.Identidade
{
    public class ServiceIdentidade : HTTPService, IServiceIdentidade
    {
        public ServiceIdentidade(IConfiguration configuration)
        {
            ConfigurarBaseUrl(configuration.GetSection("AppSettings")["IdentityUrl"]);
        }

        public string EnviarIdentidade(UsuarioRegistro autenticacao)
        {
            var result = _httpClient.PostAsync($"/api/identidade/Nova-Identidade", ObterConteudo(autenticacao)).Result;

            if (!result.IsSuccessStatusCode)
                throw new Exception($"Não foi possível criar a identidade, {result}");

            return result.Content.ReadAsStringAsync().Result;
            
        }
    }
}
