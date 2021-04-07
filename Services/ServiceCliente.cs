using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.Repositorios.Interfaces;
using AmandaStore.Domain.ValueObjects;
using AmandaStore.Enums;
using AmandaStore.Model;
using AmandaStore.Services.Factorys;
using AmandaStore.Services.Identidade.Interface;
using AmandaStore.Services.Identidade.Model;
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
    public class ServiceCliente : Service<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;
        private readonly IServiceUsuario _serviceUsuario;
        private readonly IServiceIdentidade _serviceIdentidade;

        public ServiceCliente(IRepositoryCliente repositoryCliente, IServiceUsuario serviceUsuario, IServiceIdentidade serviceIdentidade) :
            base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
            _serviceUsuario = serviceUsuario;
            _serviceIdentidade = serviceIdentidade;
        }
        public async Task<IServerStatus> AdicionarCliente(ClienteModel clienteModel)
        {
            clienteModel.Id = Guid.NewGuid();

            var result = await _serviceIdentidade.EnviarIdentidade(new UsuarioRegistro(clienteModel.Id, clienteModel.Nome,
             clienteModel.CPF, clienteModel.TipoCliente, clienteModel.Email, clienteModel.Senha));
         
            var montarUsuario = UsuarioFactory.CriarUsuario(clienteModel);
            var userResult = await _serviceUsuario.AdicionarUsuario(montarUsuario);

            if (userResult.Status == 1)
                return await Task.FromResult(userResult);

            var cliente = new Cliente(clienteModel.ProdutoPreferido, clienteModel.CPF, new RG(clienteModel.RgNumero,
                                      clienteModel.RgOrgaoEmissor, clienteModel.RgPaisEmissor, clienteModel.RgEmissao),
                                       (int)(TipoCliente)Enum.Parse(typeof(TipoCliente), clienteModel.TipoCliente), new Endereco(clienteModel.Logradouro, clienteModel.Complemento, 
                                      clienteModel.Numero, clienteModel.Cep, clienteModel.Bairro, clienteModel.Cidade, clienteModel.Estado));

            cliente.Id = clienteModel.Id;

            _repositoryCliente.AdicionarCliente(cliente);
            return await Task.FromResult(new ServerStatus() { Mensagem = "Cliente cadastrado com sucesso!", Status = 0 });

        }
    }
}
