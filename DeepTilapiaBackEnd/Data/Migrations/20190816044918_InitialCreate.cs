using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeepTilapiaBackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    PorcentajeProteina = table.Column<float>(nullable: false),
                    PorcentajeCarbohidratos = table.Column<float>(nullable: false),
                    Vitaminas = table.Column<string>(nullable: true),
                    CantidadInventario = table.Column<float>(nullable: false),
                    Etapa = table.Column<string>(nullable: true),
                    Unidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AlimentosSuplidores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDAlimento = table.Column<int>(nullable: false),
                    IDSuplidor = table.Column<int>(nullable: false),
                    Precio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlimentosSuplidores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    PesoPromedio = table.Column<double>(nullable: false),
                    Etapa = table.Column<string>(nullable: true),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    CostoXPeso = table.Column<double>(nullable: false),
                    CostoXUnidad = table.Column<double>(nullable: false),
                    TemperaturaSuplidor = table.Column<float>(nullable: false),
                    PhSuplidor = table.Column<float>(nullable: false),
                    TemperaturaTransporte = table.Column<float>(nullable: false),
                    PhTransporte = table.Column<float>(nullable: false),
                    TemperaturaRecibimiento = table.Column<float>(nullable: false),
                    PhRecibimiento = table.Column<float>(nullable: false),
                    DistanciaTransporte = table.Column<float>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: false),
                    MetodoTransporte = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JaulaGrupos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDJaula = table.Column<int>(nullable: false),
                    IDGrupoTilapia = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    IDJaulaGrupoAnterior = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JaulaGrupos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Jaulas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoJaula = table.Column<string>(nullable: true),
                    Ubicacion = table.Column<string>(nullable: true),
                    Ancho = table.Column<double>(nullable: false),
                    Largo = table.Column<double>(nullable: false),
                    Profundidad = table.Column<double>(nullable: false),
                    Volumen = table.Column<double>(nullable: false),
                    Capacidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jaulas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JaulasGrupoAguas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDJaulaGrupo = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Temperatura = table.Column<float>(nullable: false),
                    Ph = table.Column<float>(nullable: false),
                    Turbidez = table.Column<float>(nullable: false),
                    Iluminacion = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JaulasGrupoAguas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JaulasGrupoAlimentos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDJaulaGrupo = table.Column<int>(nullable: false),
                    IDAlimento = table.Column<int>(nullable: false),
                    Cantidad = table.Column<float>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JaulasGrupoAlimentos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JaulasGrupoMuertes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDJaulaGrupo = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JaulasGrupoMuertes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JaulasGrupoPeso",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDJaulaGrupo = table.Column<int>(nullable: false),
                    PesoPromedio = table.Column<double>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JaulasGrupoPeso", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SuplidorAlevines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Encargado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplidorAlevines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SuplidorAlimentos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Encargado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplidorAlimentos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentos");

            migrationBuilder.DropTable(
                name: "AlimentosSuplidores");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "JaulaGrupos");

            migrationBuilder.DropTable(
                name: "Jaulas");

            migrationBuilder.DropTable(
                name: "JaulasGrupoAguas");

            migrationBuilder.DropTable(
                name: "JaulasGrupoAlimentos");

            migrationBuilder.DropTable(
                name: "JaulasGrupoMuertes");

            migrationBuilder.DropTable(
                name: "JaulasGrupoPeso");

            migrationBuilder.DropTable(
                name: "SuplidorAlevines");

            migrationBuilder.DropTable(
                name: "SuplidorAlimentos");
        }
    }
}
