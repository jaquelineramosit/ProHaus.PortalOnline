using Microsoft.EntityFrameworkCore.Migrations;

namespace ProHaus.PortalOnline.Repositorio.Migrations
{
    public partial class AddContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParNumber",
                table: "Produtos",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParNumber",
                table: "Produtos",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
