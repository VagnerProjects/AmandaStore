using AmandaStore.AppServices.Interfaces;
using AmandaStore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IAppServiceCliente _appServiceCliente;

        public ClienteController(IAppServiceCliente appServiceCliente)
        {
            _appServiceCliente = appServiceCliente;
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
    }
}
