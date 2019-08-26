using Microsoft.EntityFrameworkCore.Migrations;

namespace DeepTilapiaBackEnd.Data.Migrations
{
    public partial class klklk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "JaulaGrupos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "JaulaGrupos");
        }
    }
}
