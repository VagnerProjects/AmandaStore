using AmandaStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Factorys
{
    public class UsuarioFactory
    {
        public static UsuarioModel CriarUsuario(ClienteModel cliente)
        {
            return new UsuarioModel
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Idade = cliente.Idade,
                DataNascimento = cliente.DataNascimento,
                Celular = cliente.Celular,
                Telefone = cliente.Telefone,
                Senha = cliente.Senha,
                Email = cliente.Email,
                TipoUsuario = cliente.TipoUsuario
            };
        }
    }
}
