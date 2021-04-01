using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Repositorios;
using AmandaStore.Domain.Repositorios.Interfaces;
using AmandaStore.Model;
using AmandaStore.Services.Status;
using AmandaStore.Services.Status.Interface;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services
{
    public class ServiceProduto : Repository<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
        public async Task<IServerStatus> AdicionarProduto(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                var stream = file.OpenReadStream();
                stream.CopyTo(memoryStream);

                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                using (var package = new ExcelPackage())
                {
                }
            }

            return new ServerStatus() { Mensagem = "Teste", Status = 0 };
        }
    }
}
