using Microsoft.EntityFrameworkCore.Migrations;

namespace DeepTilapiaBackEnd.Data.Migrations
{
    public partial class klklk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoPeso");

            migrationBuilder.DropColumn(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoMuertes");

            migrationBuilder.DropColumn(
                name: "IDAlimento",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropColumn(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropColumn(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoAguas");

            migrationBuilder.DropColumn(
                name: "IDGrupoTilapia",
                table: "JaulaGrupos");

            migrationBuilder.DropColumn(
                name: "IDJaula",
                table: "JaulaGrupos");

            migrationBuilder.DropColumn(
                name: "IDJaulaGrupoAnterior",
                table: "JaulaGrupos");

            migrationBuilder.DropColumn(
                name: "IDAlimento",
                table: "AlimentosSuplidores");

            migrationBuilder.DropColumn(
                name: "IDSuplidor",
                table: "AlimentosSuplidores");

            migrationBuilder.AddColumn<int>(
                name: "jaulaGrupoID",
                table: "JaulasGrupoPeso",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jaulaGrupoID",
                table: "JaulasGrupoMuertes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "alimentoID",
                table: "JaulasGrupoAlimentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jaulaGrupoID",
                table: "JaulasGrupoAlimentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jaulaGrupoID",
                table: "JaulasGrupoAguas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JaulaGrupoAnteriorID",
                table: "JaulaGrupos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "grupoID",
                table: "JaulaGrupos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jaulaID",
                table: "JaulaGrupos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "suplidorPecesID",
                table: "Grupos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "alimentoID",
                table: "AlimentosSuplidores",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "suplidorAlimentoID",
                table: "AlimentosSuplidores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JaulasGrupoPeso_jaulaGrupoID",
                table: "JaulasGrupoPeso",
                column: "jaulaGrupoID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulasGrupoMuertes_jaulaGrupoID",
                table: "JaulasGrupoMuertes",
                column: "jaulaGrupoID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulasGrupoAlimentos_alimentoID",
                table: "JaulasGrupoAlimentos",
                column: "alimentoID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulasGrupoAlimentos_jaulaGrupoID",
                table: "JaulasGrupoAlimentos",
                column: "jaulaGrupoID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulasGrupoAguas_jaulaGrupoID",
                table: "JaulasGrupoAguas",
                column: "jaulaGrupoID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulaGrupos_JaulaGrupoAnteriorID",
                table: "JaulaGrupos",
                column: "JaulaGrupoAnteriorID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulaGrupos_grupoID",
                table: "JaulaGrupos",
                column: "grupoID");

            migrationBuilder.CreateIndex(
                name: "IX_JaulaGrupos_jaulaID",
                table: "JaulaGrupos",
                column: "jaulaID");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_suplidorPecesID",
                table: "Grupos",
                column: "suplidorPecesID");

            migrationBuilder.CreateIndex(
                name: "IX_AlimentosSuplidores_alimentoID",
                table: "AlimentosSuplidores",
                column: "alimentoID");

            migrationBuilder.CreateIndex(
                name: "IX_AlimentosSuplidores_suplidorAlimentoID",
                table: "AlimentosSuplidores",
                column: "suplidorAlimentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_AlimentosSuplidores_Alimentos_alimentoID",
                table: "AlimentosSuplidores",
                column: "alimentoID",
                principalTable: "Alimentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlimentosSuplidores_SuplidorAlimentos_suplidorAlimentoID",
                table: "AlimentosSuplidores",
                column: "suplidorAlimentoID",
                principalTable: "SuplidorAlimentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_SuplidorAlevines_suplidorPecesID",
                table: "Grupos",
                column: "suplidorPecesID",
                principalTable: "SuplidorAlevines",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulaGrupos_JaulaGrupos_JaulaGrupoAnteriorID",
                table: "JaulaGrupos",
                column: "JaulaGrupoAnteriorID",
                principalTable: "JaulaGrupos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulaGrupos_Grupos_grupoID",
                table: "JaulaGrupos",
                column: "grupoID",
                principalTable: "Grupos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulaGrupos_Jaulas_jaulaID",
                table: "JaulaGrupos",
                column: "jaulaID",
                principalTable: "Jaulas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulasGrupoAguas_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoAguas",
                column: "jaulaGrupoID",
                principalTable: "JaulaGrupos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulasGrupoAlimentos_Alimentos_alimentoID",
                table: "JaulasGrupoAlimentos",
                column: "alimentoID",
                principalTable: "Alimentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulasGrupoAlimentos_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoAlimentos",
                column: "jaulaGrupoID",
                principalTable: "JaulaGrupos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulasGrupoMuertes_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoMuertes",
                column: "jaulaGrupoID",
                principalTable: "JaulaGrupos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JaulasGrupoPeso_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoPeso",
                column: "jaulaGrupoID",
                principalTable: "JaulaGrupos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlimentosSuplidores_Alimentos_alimentoID",
                table: "AlimentosSuplidores");

            migrationBuilder.DropForeignKey(
                name: "FK_AlimentosSuplidores_SuplidorAlimentos_suplidorAlimentoID",
                table: "AlimentosSuplidores");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_SuplidorAlevines_suplidorPecesID",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulaGrupos_JaulaGrupos_JaulaGrupoAnteriorID",
                table: "JaulaGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulaGrupos_Grupos_grupoID",
                table: "JaulaGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulaGrupos_Jaulas_jaulaID",
                table: "JaulaGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulasGrupoAguas_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoAguas");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulasGrupoAlimentos_Alimentos_alimentoID",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulasGrupoAlimentos_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulasGrupoMuertes_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoMuertes");

            migrationBuilder.DropForeignKey(
                name: "FK_JaulasGrupoPeso_JaulaGrupos_jaulaGrupoID",
                table: "JaulasGrupoPeso");

            migrationBuilder.DropIndex(
                name: "IX_JaulasGrupoPeso_jaulaGrupoID",
                table: "JaulasGrupoPeso");

            migrationBuilder.DropIndex(
                name: "IX_JaulasGrupoMuertes_jaulaGrupoID",
                table: "JaulasGrupoMuertes");

            migrationBuilder.DropIndex(
                name: "IX_JaulasGrupoAlimentos_alimentoID",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropIndex(
                name: "IX_JaulasGrupoAlimentos_jaulaGrupoID",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropIndex(
                name: "IX_JaulasGrupoAguas_jaulaGrupoID",
                table: "JaulasGrupoAguas");

            migrationBuilder.DropIndex(
                name: "IX_JaulaGrupos_JaulaGrupoAnteriorID",
                table: "JaulaGrupos");

            migrationBuilder.DropIndex(
                name: "IX_JaulaGrupos_grupoID",
                table: "JaulaGrupos");

            migrationBuilder.DropIndex(
                name: "IX_JaulaGrupos_jaulaID",
                table: "JaulaGrupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_suplidorPecesID",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_AlimentosSuplidores_alimentoID",
                table: "AlimentosSuplidores");

            migrationBuilder.DropIndex(
                name: "IX_AlimentosSuplidores_suplidorAlimentoID",
                table: "AlimentosSuplidores");

            migrationBuilder.DropColumn(
                name: "jaulaGrupoID",
                table: "JaulasGrupoPeso");

            migrationBuilder.DropColumn(
                name: "jaulaGrupoID",
                table: "JaulasGrupoMuertes");

            migrationBuilder.DropColumn(
                name: "alimentoID",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropColumn(
                name: "jaulaGrupoID",
                table: "JaulasGrupoAlimentos");

            migrationBuilder.DropColumn(
                name: "jaulaGrupoID",
                table: "JaulasGrupoAguas");

            migrationBuilder.DropColumn(
                name: "JaulaGrupoAnteriorID",
                table: "JaulaGrupos");

            migrationBuilder.DropColumn(
                name: "grupoID",
                table: "JaulaGrupos");

            migrationBuilder.DropColumn(
                name: "jaulaID",
                table: "JaulaGrupos");

            migrationBuilder.DropColumn(
                name: "suplidorPecesID",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "alimentoID",
                table: "AlimentosSuplidores");

            migrationBuilder.DropColumn(
                name: "suplidorAlimentoID",
                table: "AlimentosSuplidores");

            migrationBuilder.AddColumn<int>(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoPeso",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoMuertes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDAlimento",
                table: "JaulasGrupoAlimentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoAlimentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDJaulaGrupo",
                table: "JaulasGrupoAguas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDGrupoTilapia",
                table: "JaulaGrupos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDJaula",
                table: "JaulaGrupos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDJaulaGrupoAnterior",
                table: "JaulaGrupos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDAlimento",
                table: "AlimentosSuplidores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDSuplidor",
                table: "AlimentosSuplidores",
                nullable: false,
                defaultValue: 0);
        }
    }
}
