using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Produto : EntityBase
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public double Custo { get; set; }
        public string Unidade { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int TipoProduto { get; set; }
        public int SubTipoProduto { get; set; }
        public virtual ICollection<Transacao> TransacaoProduto { get; set; }
        public virtual ICollection<ProdutoCategoria> CategoriaProduto {get;set;}
        public virtual ICollection<Avaliacao> ProdutoAvaliacao { get; set; }

        public Produto() { }

        public Produto(string nome, string descricao, double valor, int quantidadeEstoque,
                      int tipoProduto, int subTipoProduto, string codigo, double custo, string unidade)
        {
            Descricao = descricao;
            ProdutoAvaliacao = new List<Avaliacao>();
            TransacaoProduto = new List<Transacao>();
            CategoriaProduto = new List<ProdutoCategoria>();
            Nome = nome;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
            TipoProduto = tipoProduto;
            SubTipoProduto = subTipoProduto;
            Codigo = codigo;
            Custo = custo;
            Unidade = unidade;
        }

        public string SetDescricao(string descricao)
        {
            return Descricao = descricao;
        }
        public string SetNome(string nome)
        {
            return Nome = nome;
        }
        public double SetValor(double valor)
        {
            return Valor = valor;
        }

        public int SetQuantidadeEstoque(int quantidade)
        {
            return QuantidadeEstoque = quantidade;
        }

        public int SetTipoProduto(int tipo)
        {
            return TipoProduto = tipo;
        }

        public int SetSubTipoProduto(int subTipo)
        {
            return SubTipoProduto = subTipo;
        }

        public string SetCodigo(string codigo)
        {
            return Codigo = codigo;
        }

        public double SetCusto(double custo)
        {
            return Custo = custo;
        }

        public string SetUnidade(string unidade)
        {
            return Unidade = unidade;
        }
    }
}
