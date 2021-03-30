using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> orderConfiguration)
        {
            orderConfiguration.HasKey(o => o.Id);
            orderConfiguration.OwnsOne(o => o.SenhaUsuario);
        }
    }
}
