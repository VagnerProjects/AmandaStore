using AmandaStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Identidade.Model
{
    public class UsuarioRegistro
    {
        public Guid UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string TipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public UsuarioRegistro(Guid usuarioId, string nome, string cpf, string tipoUsuario, string email, string senha)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Email = email;
            Senha = new Senha(senha).Password;
        }
    }
}
