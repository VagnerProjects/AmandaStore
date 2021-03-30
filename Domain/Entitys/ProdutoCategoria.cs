using AmandaStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class ProdutoCategoria:EntityBase
    {
        public int Categoria { get; set; }
        public int SubCategoria { get; set; }

        public ProdutoCategoria() { }

        public ProdutoCategoria(int categoria, int subCategoria)
        {
            Categoria = categoria;
            SubCategoria = subCategoria;
        }
    }
}
