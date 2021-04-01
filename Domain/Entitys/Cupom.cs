using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Cupom:EntityBase
    {
        public int Desconto { get; set; }
        public string Preenchimento { get; set; }
        public virtual ICollection<Transacao> Transacao { get; set; }

        public Cupom() { }
        public Cupom(int desconto, string preenchimento)
        {
            Transacao = new List<Transacao>();
            Desconto = desconto;
            Preenchimento = preenchimento;
        }

        public int SetDesconto(int desconto)
        {
            return Desconto = desconto;
        }

        public string SetPreenchimento(string preenchimento)
        {
            return Preenchimento = preenchimento;
        }
    }
}
