using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Repositorios.Interfaces;
using AmandaStore.Domain.ValueObjects;
using AmandaStore.Enums;
using AmandaStore.Model;
using AmandaStore.Services.Interfaces;
using AmandaStore.Services.Serviços;
using AmandaStore.Services.Status;
using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services
{
    public class ServiceUsuario : Service<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<IServerStatus> AdicionarUsuario(UsuarioModel userModel)
        {
            try
            {
                var usuarioVerify = _repositoryUsuario.Find(userModel.Id);

                if (usuarioVerify != null)
                    return await Task.FromResult(new ServerStatus() { Mensagem = "O usuario já esta cadastrado!", Status = 1 });

                var usuario = new Usuario(userModel.Nome, userModel.Idade, userModel.DataNascimento, (int)(TipoUsuario)Enum.Parse(typeof(TipoUsuario), userModel.TipoUsuario), 
                    new Email(userModel.Email).Endereco, userModel.Telefone, userModel.Celular);

                _repositoryUsuario.AdicionarUsuario(usuario);
            }
            catch(Exception ex)
            {
                return await Task.FromResult(new ServerStatus() { Mensagem = ex.Message, Status = 1 });
            }

            return await Task.FromResult(new ServerStatus() { Mensagem = "Usuario Cadastrado com sucesso!", Status = 0 });
        }
    }
}
