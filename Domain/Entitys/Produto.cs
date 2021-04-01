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
        public virtual ICollection<Roupas> Roupas { get; set; } 
        public virtual ICollection<Cupom> Cupom { get; set; }
        public virtual ICollection<Acessorios> Acessorios { get; set; }
        public virtual ICollection<Maquiagem> Maquiagem { get; set; }
        public Produto() { }

        public Produto(string nome, string descricao, double valor, int quantidadeEstoque,
                      int tipoProduto, int subTipoProduto, string codigo, double custo, string unidade)
        {
            Descricao = descricao;
 
            ProdutoAvaliacao = new List<Avaliacao>();
            TransacaoProduto = new List<Transacao>();
            CategoriaProduto = new List<ProdutoCategoria>();
            Cupom = new List<Cupom>();
            Roupas = new List<Roupas>();
            Acessorios = new List<Acessorios>();
            Maquiagem = new List<Maquiagem>();
            Nome = nome;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
            TipoProduto = tipoProduto;
            SubTipoProduto = subTipoProduto;
            Codigo = codigo;
            Custo = custo;
            Unidade = unidade;
        }

        public void SetDescricao(string descricao) => Descricao = descricao;
        public string SetNome(string nome) => Nome = nome;
        public double SetValor(double valor) => Valor = valor;
        public int SetQuantidadeEstoque(int quantidade) => QuantidadeEstoque = quantidade;
        public int SetTipoProduto(int tipo) => TipoProduto = tipo;
        public int SetSubTipoProduto(int subTipo) => SubTipoProduto = subTipo;
        public string SetCodigo(string codigo) => Codigo = codigo;
        public string SetUnidade(string unidade) => Unidade = unidade;
      
    }
}
