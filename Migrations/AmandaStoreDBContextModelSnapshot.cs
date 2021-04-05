﻿// <auto-generated />
using System;
using AmandaStore.Domain.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmandaStore.Migrations
{
    [DbContext(typeof(AmandaStoreDBContext))]
    partial class AmandaStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Acessorios", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("AvisosInstrucoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Comprimento")
                        .HasColumnType("float");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detalhes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Acessorios");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Avaliacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ComentarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estrelas")
                        .HasColumnType("int");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ComentarioId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bandeira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PVV")
                        .HasColumnType("int");

                    b.Property<string>("TipoCartao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Validade")
                        .HasColumnType("datetime2");

                    b.Property<bool>("VirtualCartao")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("ProdutoPreferido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Comentario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cupom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Desconto")
                        .HasColumnType("int");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Preenchimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Cupom");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Maquiagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("AvisosInstrucoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beneficios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Comprimento")
                        .HasColumnType("float");

                    b.Property<int>("Cor")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PesoLiquido")
                        .HasColumnType("float");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Textura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoMaquiagem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Maquiagem");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Custo")
                        .HasColumnType("float");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int");

                    b.Property<int>("SubTipoProduto")
                        .HasColumnType("int");

                    b.Property<int>("TipoProduto")
                        .HasColumnType("int");

                    b.Property<string>("Unidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.ProdutoCategoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SubCategoria")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutoCategoria");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Roupas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AvisoInstrucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PorcentagemDoMaterial")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoDeRoupa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Roupas");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CupomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoCartao")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CartaoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CupomId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Transacao");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<bool>("Lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Acessorios", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("Acessorios")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Avaliacao", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Cliente", null)
                        .WithMany("AvaliacaoCliente")
                        .HasForeignKey("ClienteId");

                    b.HasOne("AmandaStore.Domain.Entitys.Comentario", null)
                        .WithMany("AvaliacaoComentario")
                        .HasForeignKey("ComentarioId");

                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("ProdutoAvaliacao")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cartao", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Cliente", null)
                        .WithMany("Cartoes")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cliente", b =>
                {
                    b.OwnsOne("AmandaStore.Domain.ValueObjects.Endereco", "EnderecoCliente", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Endereco_Bairro");

                            b1.Property<string>("CepEndereco")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Endereco_Cidade");

                            b1.Property<string>("Complemento")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Endereco_Complemento");

                            b1.Property<string>("Estado")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)")
                                .HasColumnName("Endereco_UF");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnType("varchar(80)")
                                .HasColumnName("Endereco_Logradouro");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Endereco_Numero");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.OwnsOne("AmandaStore.Domain.ValueObjects.RG", "RgCliente", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime?>("DataDeEmissao")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Numero")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("OrgaoEmissor")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PaisEmissor")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.Navigation("EnderecoCliente");

                    b.Navigation("RgCliente");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Comentario", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Cliente", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cupom", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("Cupom")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Maquiagem", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("Maquiagem")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.ProdutoCategoria", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("CategoriaProduto")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Roupas", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("Roupas")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Transacao", b =>
                {
                    b.HasOne("AmandaStore.Domain.Entitys.Cartao", null)
                        .WithMany("CartaoTransacao")
                        .HasForeignKey("CartaoId");

                    b.HasOne("AmandaStore.Domain.Entitys.Cliente", null)
                        .WithMany("TransacaoCliente")
                        .HasForeignKey("ClienteId");

                    b.HasOne("AmandaStore.Domain.Entitys.Cupom", null)
                        .WithMany("Transacao")
                        .HasForeignKey("CupomId");

                    b.HasOne("AmandaStore.Domain.Entitys.Produto", null)
                        .WithMany("TransacaoProduto")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cartao", b =>
                {
                    b.Navigation("CartaoTransacao");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cliente", b =>
                {
                    b.Navigation("AvaliacaoCliente");

                    b.Navigation("Cartoes");

                    b.Navigation("Comentarios");

                    b.Navigation("TransacaoCliente");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Comentario", b =>
                {
                    b.Navigation("AvaliacaoComentario");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Cupom", b =>
                {
                    b.Navigation("Transacao");
                });

            modelBuilder.Entity("AmandaStore.Domain.Entitys.Produto", b =>
                {
                    b.Navigation("Acessorios");

                    b.Navigation("CategoriaProduto");

                    b.Navigation("Cupom");

                    b.Navigation("Maquiagem");

                    b.Navigation("ProdutoAvaliacao");

                    b.Navigation("Roupas");

                    b.Navigation("TransacaoProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
