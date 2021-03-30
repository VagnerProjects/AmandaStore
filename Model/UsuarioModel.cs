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
        public int TipoUsuario { get; set; }
        public string Rgnumero { get; set; }
        public string RgOrgaoEmissor { get; set; }
        public string PaisEmissor { get; private set; }
        public DateTime? DataDeEmissao { get; private set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public UsuarioModel(string nome, int idade, DateTime? dataNascimento, int tipoUsuario, 
                            string rgnumero, string rgOrgaoEmissor, string paisEmissor, DateTime? dataDeEmissao,
                            string cpf, string email, string senha, string telefone, string celular)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            TipoUsuario = tipoUsuario;
            Rgnumero = rgnumero;
            RgOrgaoEmissor = rgOrgaoEmissor;
            PaisEmissor = paisEmissor;
            DataDeEmissao = dataDeEmissao;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Celular = celular;
        }
    }
}
