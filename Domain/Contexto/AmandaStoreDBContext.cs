using AmandaStore.Domain.Entitys;
using AmandaStore.Domain.ValueObjects;
using Microsoft.Azure.Management.Compute.Fluent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.Contexto
{
    public class AmandaStoreDBContext : DbContext
    {
        public AmandaStoreDBContext(DbContextOptions<AmandaStoreDBContext> options)
            : base(options)
        {

        }

        public AmandaStoreDBContext()
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cartao> Cartao { get; set; }
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoCategoria> ProdutoCategoria { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Maquiagem> Maquiagem { get; set; }
        public DbSet<Acessorios> Acessorios { get; set; }
        public DbSet<Roupas> Roupas { get; set; }
       public DbSet<Cupom> Cupom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("AmandaStoreDB");
            optionsBuilder.UseSqlServer(connectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>().HasKey("EnderecoCliente");

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Roupas>().ToTable("Roupas");
            modelBuilder.Entity<Acessorios>().ToTable("Acessorios");
         
           

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var cetZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeCadastro") != null))
            {

                if (entry.State == EntityState.Added)
                    entry.Property("DataDeCadastro").CurrentValue = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, cetZone);

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataDeCadastro").IsModified = false;
                    entry.Property("DataDeAlteracao").CurrentValue = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, cetZone);

                }
            }
            return base.SaveChanges();
        }
    }
}
