using Microsoft.EntityFrameworkCore.Migrations;

namespace DeepTilapiaBackEnd.Data.Migrations
{
    public partial class porfavor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Etapa",
                table: "JaulaGrupos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Etapa",
                table: "JaulaGrupos");
        }
    }
}
