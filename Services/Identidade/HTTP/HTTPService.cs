using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AmandaStore.Services.Identidade.HTTP
{
    public class HTTPService
    {
        protected readonly HttpClient _httpClient;

        public HTTPService()
        {
            _httpClient = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        protected void ConfigurarBaseUrl(string url)
        {
            _httpClient.BaseAddress = new Uri(url);
        }

        protected async Task<T> DeserializarObjetoResponse<T>(HttpResponseMessage responseMessage)
        {
            return JsonConvert.DeserializeObject<T>(await responseMessage.Content.ReadAsStringAsync());
        }

        protected HttpContent ObterConteudo(object dados)
        {
            return new StringContent(
                JsonConvert.SerializeObject(dados),
                Encoding.UTF8,
                "application/json");
        }
    }
}
