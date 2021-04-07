using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.DTOs
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string TipoUsuario { get; set; }
        public string TipoCliente { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public ClienteDTO() { }
        public ClienteDTO(Guid id, string nome, string dataNascimento, string tipoUsuario,
                          string tipoCliente, string email, string cpf)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            TipoUsuario = tipoUsuario;
            TipoCliente = tipoCliente;
            Email = email;
            CPF = cpf;
        }
    }
}
