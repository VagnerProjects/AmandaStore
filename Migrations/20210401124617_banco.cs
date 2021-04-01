using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmandaStore.Migrations
{
    public partial class banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CupomId",
                table: "Transacao",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Maquiagem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Acessorios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cupom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Desconto = table.Column<int>(type: "int", nullable: false),
                    Preenchimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lixeira = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cupom_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_CupomId",
                table: "Transacao",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_Maquiagem_ProdutoId",
                table: "Maquiagem",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Acessorios_ProdutoId",
                table: "Acessorios",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cupom_ProdutoId",
                table: "Cupom",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acessorios_Produto_ProdutoId",
                table: "Acessorios",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maquiagem_Produto_ProdutoId",
                table: "Maquiagem",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_Cupom_CupomId",
                table: "Transacao",
                column: "CupomId",
                principalTable: "Cupom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acessorios_Produto_ProdutoId",
                table: "Acessorios");

            migrationBuilder.DropForeignKey(
                name: "FK_Maquiagem_Produto_ProdutoId",
                table: "Maquiagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_Cupom_CupomId",
                table: "Transacao");

            migrationBuilder.DropTable(
                name: "Cupom");

            migrationBuilder.DropIndex(
                name: "IX_Transacao_CupomId",
                table: "Transacao");

            migrationBuilder.DropIndex(
                name: "IX_Maquiagem_ProdutoId",
                table: "Maquiagem");

            migrationBuilder.DropIndex(
                name: "IX_Acessorios_ProdutoId",
                table: "Acessorios");

            migrationBuilder.DropColumn(
                name: "CupomId",
                table: "Transacao");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Maquiagem");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Acessorios");
        }
    }
}
