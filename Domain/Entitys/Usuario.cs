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

        public string SetNome(string nome)
        {
            return Nome = nome;
        }
        public int SetIdade(int idade)
        {
            return Idade = idade;
        }

        public DateTime? SetDataNascimento(DateTime? data)
        {
            return DataNascimento = data;
        }

        public string SetTelefone(string telefone)
        {
            return Telefone = telefone;
        }

        public string SetCelular(string celular)
        {
            return Celular = celular;
        }

        public int SetTipoUsuario(int tipoUsuario)
        {
            return TipoUsuario = tipoUsuario;
        }

    }
}
