using Microsoft.EntityFrameworkCore.Migrations;

namespace AmandaStore.Migrations
{
    public partial class ProdutosItens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Material",
                table: "Produto",
                newName: "Unidade");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Custo",
                table: "Produto",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Custo",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Unidade",
                table: "Produto",
                newName: "Material");
        }
    }
}
