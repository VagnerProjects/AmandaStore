using Microsoft.EntityFrameworkCore.Migrations;

namespace AmandaStore.Migrations
{
    public partial class Sets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VirtualCartao",
                table: "Cartao",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VirtualCartao",
                table: "Cartao");
        }
    }
}
