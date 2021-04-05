using Microsoft.EntityFrameworkCore.Migrations;

namespace AmandaStore.Migrations
{
    public partial class removeSenha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenhaUsuario_Password",
                table: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SenhaUsuario_Password",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
