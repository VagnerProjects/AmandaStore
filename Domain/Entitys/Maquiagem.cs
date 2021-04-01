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

        public void SetCor(int cor) => Cor = cor;
        public void SetMaterial(string material) => Material = material;
        public void SetTextura(string textura) => Textura = textura;
        public void SetPeso(double peso) => PesoLiquido = peso;
        public void SetComprimento(double comprimento) => Comprimento = comprimento;
        public void SetLargura(double largura) => Largura = largura;
        public void SetAltura(double altura) => Altura = altura;
        public void SetBeneficios(string beneficios) => Beneficios = beneficios;
        public void SetTipo(int tipo) => TipoMaquiagem = tipo;
        public void SetMarca(string marca) => Marca = marca;
        public void SetAvisosInstrucoes(string avisos) => AvisosInstrucoes = avisos;
    }
}
