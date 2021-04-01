using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Roupas : EntityBase
    {
        public string Cor { get; set; }
        public string Material { get; set; }
        public int PorcentagemDoMaterial { get; set; }
        public string AvisoInstrucao { get; set; }
        public int TipoDeRoupa { get; set; }

        public Roupas() { }

        public Roupas(string cor, string material, int porcentagemdoMaterial, string avisoInstrucao, int tipodeRoupa)
        {
            Cor = cor;
            Material = material;
            PorcentagemDoMaterial = porcentagemdoMaterial;
            AvisoInstrucao = avisoInstrucao;
            TipoDeRoupa = tipodeRoupa;
        }

        public string SetCor(string cor)
        {
            return Cor = cor;
        }

        public string SetMaterial(string material)
        {
            return Material = material;
        }
        public int SetPorcentagemDoMaterial(int porcentagemDoMaterial)
        {
            return PorcentagemDoMaterial = porcentagemDoMaterial;
        }
        public string SetAvisoInstrucao (string avisoInstrucao)
        {
            return AvisoInstrucao = avisoInstrucao;
        }
        public int SetTipoDeRoupa (int tipoDeRoupa)
        {
            return TipoDeRoupa = tipoDeRoupa;

        }
    }
}
