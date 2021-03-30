using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Transacao : EntityBase
    {
        public double Valor { get; set; }
        public int TipoCartao { get; set; }
        public Transacao () { }

        public Transacao(double valor, int tipoCartao)
        {
            Valor = valor;
            TipoCartao = tipoCartao;
        }

    }
}
