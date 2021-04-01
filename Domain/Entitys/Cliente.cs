using AmandaStore.Domain.Base;
using AmandaStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Cliente : EntityBase
    {
        public string CPF { get; set; }
        public RG RgCliente { get; set; }
        public int TipoCliente { get; set; }
        public string ProdutoPreferido { get; set; }
        public virtual ICollection<Transacao> TransacaoCliente { get; set; }
        public virtual ICollection<Cartao> Cartoes { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<Avaliacao> AvaliacaoCliente { get; set; }

        public Endereco EnderecoCliente { get; private set; }
        public Cliente() { }

        public Cliente(string produtoPreferido, string cpf, RG rgCleinte, int tipoCliente, Endereco enderecoCliente)
        {
            TransacaoCliente = new List<Transacao>();
            Cartoes = new List<Cartao>();
            Comentarios = new List<Comentario>();
            CPF = cpf;
            TipoCliente = tipoCliente;
            RgCliente = rgCleinte;
            ProdutoPreferido = produtoPreferido;
            EnderecoCliente = enderecoCliente;
        }

        public void SetProdutoPreferido(string produto) => ProdutoPreferido = produto;
        public void SetTipoCliente(int clienteTipo) => TipoCliente = clienteTipo;
        public void SetCPF(string cpf) => CPF = cpf;
        public void SetEndereco(Endereco endereco) => EnderecoCliente = endereco;
    }
}
