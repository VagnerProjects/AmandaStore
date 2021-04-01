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

        public string SetMaterial(string material)
        {
            return Material = material;
        }

        public double SetPeso(double peso)
        {
            return Peso = peso;
        }

        public double SetComprimento(double comprimento)
        {
            return Comprimento = comprimento;
        }

        public double SetLargura(double largura)
        {
            return Largura = largura;
        }

        public double SetAltura(double altura)
        {
            return Altura = altura;
        }

        public string SetCor(string cor)
        {
            return Cor = cor;
        }

        public string SetDetalhes(string detalhes)
        {
            return Detalhes = detalhes;
        }

        public string SetAvisosInstrucoes(string avisos)
        {
            return AvisosInstrucoes = avisos;
        }
        public int SetTipo(int tipo)
        {
            return Tipo = tipo;
        }
    }
}
