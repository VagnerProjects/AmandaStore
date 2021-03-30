using AmandaStore.Domain.Entitys;
using AmandaStore.Model;
using AmandaStore.Services.Interfaces;
using AmandaStore.Services.Status.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services
{
    public interface IServiceProduto:IService<Produto>
    {
        Task<IServerStatus> AdicionarProduto(IFormFile file);
    }
}
