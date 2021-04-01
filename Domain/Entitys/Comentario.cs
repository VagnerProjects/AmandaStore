using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class Comentario : EntityBase
    {
        public string Descricao { get; set; }
        public virtual ICollection<Avaliacao> AvaliacaoComentario {get; set;}

        public Comentario () { }

        public Comentario(string descricao)
        {
            AvaliacaoComentario = new List<Avaliacao>();
            Descricao = descricao;
        }

        public void SetComentario(string comentario) => Descricao = comentario;
    }
}
