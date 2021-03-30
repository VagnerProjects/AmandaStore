using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Entitys
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> orderConfiguration)
        {          
            orderConfiguration.HasKey(o => o.Id);
            orderConfiguration.Ignore("EnderecoCliente");
            orderConfiguration.OwnsOne(c => c.RgCliente);
            orderConfiguration.OwnsOne(c => c.EnderecoCliente, end =>
            {
                end.Property(c => c.Logradouro)
                    .IsRequired()
                    .HasColumnName("Endereco_Logradouro")
                    .HasColumnType("varchar(80)");

                end.Property(c => c.Numero)
                    .IsRequired()
                    .HasColumnName("Endereco_Numero");

                end.Property(c => c.Complemento)
                    .IsRequired()
                    .HasColumnName("Endereco_Complemento");

                end.Property(c => c.Bairro)
                    .IsRequired()
                    .HasColumnName("Endereco_Bairro");

                end.Property(c => c.Cidade)
                    .IsRequired()
                    .HasColumnName("Endereco_Cidade");

                end.Property(c => c.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("Endereco_UF");


            });

            orderConfiguration.ToTable("Clientes");
        }
    }
}
