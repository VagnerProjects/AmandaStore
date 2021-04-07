using AmandaStore.AppServices.Interfaces;
using AmandaStore.Domain.DTOs;
using AmandaStore.Model;
using AmandaStore.Services.Identidade.Interface;
using AmandaStore.Services.Identidade.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AmandaStore.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IAppServiceCliente _appServiceCliente;
        private readonly IServiceIdentidade _serviceIdentidade;

        public ClienteController(IAppServiceCliente appServiceCliente, IServiceIdentidade serviceIdentidade)
        {
            _appServiceCliente = appServiceCliente;
            _serviceIdentidade = serviceIdentidade;
        }

        [HttpPost("AdicionarCliente")]
        public async Task<IActionResult> AdicionarCliente(ClienteModel clienteModel)
        {
            try
            {
                var result = await _appServiceCliente.AdicionarCliente(clienteModel);

                if (result.Status == 1) return BadRequest(result);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "" + ex.InnerException);
            }
        }

        [HttpPost("AutenticarCliente")]
        public async Task<IActionResult> AutenticarCliente(UsuarioLogin usuarioLogin)
        {
            try
            {
                var result = await _serviceIdentidade.Login(usuarioLogin);

                var resultado = result.Content.ReadAsStringAsync().Result;

                if(result.StatusCode == HttpStatusCode.BadRequest)
                    return BadRequest(resultado);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " " + ex.InnerException);
            }
        }
    }
}
