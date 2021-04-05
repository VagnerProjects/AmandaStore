using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Model
{
    public class UsuarioModel:BaseModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string TipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public UsuarioModel() { }
        public UsuarioModel(string nome, int idade, DateTime? dataNascimento, string tipoUsuario, 
                              string email, string senha, string telefone, string celular)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            TipoUsuario = tipoUsuario;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Celular = celular;
        }
    }
}
