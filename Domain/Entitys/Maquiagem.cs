using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Maquiagem:EntityBase
    {
        public int Cor { get; set; }
        public string Material { get; set; }
        public string Textura { get; set; }
        public double PesoLiquido { get; set; }
        public double Comprimento { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public string Beneficios { get; set; }
        public int TipoMaquiagem { get; set; }
        public string Marca { get; set; }
        public string AvisosInstrucoes { get; set; }
        public Maquiagem() { }

        public Maquiagem(int cor, string material, string textura, double peso, double comprimento,
                         double largura, double altura, string beneficios, int maquiagemTipo, string marca = null, string avisos = null)
        {
            Cor = cor;
            Material = material;
            Textura = textura;
            PesoLiquido = peso;
            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
            Beneficios = beneficios;
            TipoMaquiagem = maquiagemTipo;
            Marca = marca;
            AvisosInstrucoes = avisos;
        }

        public int SetCor(int cor)
        {
            return Cor = cor;
        }

        public string SetMaterial(string material)
        {
            return Material = material;
        }

        public string SetTextura(string textura)
        {
            return Textura = textura;
        }
        public double SetPeso(double peso)
        {
            return PesoLiquido = peso;
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

        public string SetBeneficios(string beneficios)
        {
            return Beneficios = beneficios;
        }

        public int SetTipo(int tipo)
        {
            return TipoMaquiagem = tipo;
        }

        public string SetMarca(string marca)
        {
            return Marca = marca;
        }


        public string SetAvisosInstrucoes(string avisos)
        {
            return AvisosInstrucoes = avisos;
        }

    }
}
