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

    }
}
