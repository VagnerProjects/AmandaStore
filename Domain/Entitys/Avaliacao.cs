using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Avaliacao : EntityBase
    {
        public int Estrelas { get; set; }
      
        public Avaliacao() { }
        public Avaliacao(int estrelas)
        {           
            Estrelas = estrelas;
        }

        public void SetEstrelas(int estrelas) => Estrelas = estrelas;
    }
}
