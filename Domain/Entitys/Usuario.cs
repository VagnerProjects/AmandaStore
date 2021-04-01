using AmandaStore.Domain.Base;
using AmandaStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Usuario: EntityBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int TipoUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public Senha SenhaUsuario { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Usuario() { }
        public Usuario(string nome, int idade, string cpf, DateTime? dataNascimento, int tipoUsuario, string emailUsuario,
                       Senha senhaUsuario, string telefone, string celular)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            TipoUsuario = tipoUsuario;
            EmailUsuario = emailUsuario;
            SenhaUsuario = senhaUsuario;
            Telefone = telefone;
            Celular = celular;
            
        }

        public void SetNome(string nome) => Nome = nome;
        public void SetIdade(int idade) => Idade = idade;
        public void SetDataNascimento(DateTime? data) => DataNascimento = data;
        public void SetTelefone(string telefone) => Telefone = telefone;
        public void SetCelular(string celular) => Celular = celular;
        public void SetTipoUsuario(int tipoUsuario) => TipoUsuario = tipoUsuario;
    }
}
