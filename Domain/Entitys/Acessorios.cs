using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Acessorios: EntityBase
    {
        public string Material { get; set; }
        public double Peso { get; set; }
        public double Comprimento { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public string Cor { get; set; }
        public string Detalhes { get; set; }
        public string AvisosInstrucoes { get; set; }
        public int Tipo { get; set; }

        public Acessorios() { }

        public Acessorios(string material, double peso, double comprimento, double largura, double altura,
                         string cor, string detalhes, string avisosInstrucoes, int tipo)
        {
            Material = material;
            Peso = peso;
            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
            Cor = cor;
            Detalhes = detalhes;
            AvisosInstrucoes = avisosInstrucoes;
            Tipo = tipo;
        }

        public void SetMaterial(string material) => Material = material;
        public void SetPeso(double peso) => Peso = peso;
        public void SetComprimento(double comprimento) => Comprimento = comprimento;
        public void SetLargura(double largura) => Largura = largura;
        public void SetAltura(double altura) => Altura = altura;
        public void SetCor(string cor) => Cor = cor;
        public void SetDetalhes(string detalhes) => Detalhes = detalhes;
        public void SetAvisosInstrucoes(string avisos) => AvisosInstrucoes = avisos;
        public void SetTipo(int tipo) => Tipo = tipo;
    }
}
