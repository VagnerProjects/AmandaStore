using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Cartao:EntityBase
    {
        [CreditCard(ErrorMessage = "Cartão inválido")]
        public string Numero { get; set; }
        public int CVV { get; set; }
        public string Bandeira { get; set; }
        public DateTime? Validade { get; set; }
        public int PVV { get; set; }
        public string TipoCartao { get; set; }
        public bool VirtualCartao { get; set; }
        public virtual ICollection<Transacao> CartaoTransacao { get; set; }

        public Cartao() { }
        public Cartao(string numero, int cvv, string bandeira,DateTime? validade,
                      int pvv, string tipo, bool virtualCartao)
        {
            Numero = numero;
            CVV = cvv;
            Bandeira = bandeira;
            Validade = validade;
            PVV = pvv;
            TipoCartao = tipo;
            VirtualCartao = virtualCartao;
        }

        public void SetCVV(int cvv) => CVV = cvv;
        public void SetPVV(int pvv) => PVV = pvv;
        
    }
}
