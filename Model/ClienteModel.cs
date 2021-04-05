using AmandaStore.Domain.Base;
using AmandaStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AmandaStore.Model
{
    public class ClienteModel: UsuarioModel
    {
        public string CPF { get; set; }
        public string RgNumero { get; set; }
        public string RgOrgaoEmissor { get; set; }
        public string RgPaisEmissor { get; set; }
        public DateTime? RgEmissao { get; set; }
        public string TipoCliente { get; set; }
        public string ProdutoPreferido { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public ClienteModel(string nome, int idade, DateTime? dataNascimento, string tipoUsuario,
                           string cpf, string email, string senha, string telefone, string celular,
                           string tipoCliente, string produtoPreferido, string rgNumero, string rgOrgaoEmissor, 
                           string rgPaisEmissor, DateTime? rgEmissao, string logradouro, string complemento,
                           string numero, string cep, string bairro, string cidade, string estado)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            TipoUsuario = tipoUsuario;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Celular = celular;
            CPF = cpf;
            TipoCliente = tipoCliente;
            ProdutoPreferido = produtoPreferido;
            RgNumero = rgNumero;
            RgOrgaoEmissor = rgOrgaoEmissor;
            RgPaisEmissor = rgPaisEmissor;
            RgEmissao = rgEmissao;
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
