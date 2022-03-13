using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiRestSunat.EntityFramework.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Padron_sunat_10",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ruc = table.Column<string>(type: "text", nullable: true),
                    RazonSocial = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    Condicion = table.Column<string>(type: "text", nullable: true),
                    Ubigeo = table.Column<string>(type: "text", nullable: true),
                    TipoDeVia = table.Column<string>(type: "text", nullable: true),
                    NombreDeVia = table.Column<string>(type: "text", nullable: true),
                    CodigoDeZona = table.Column<string>(type: "text", nullable: true),
                    TipoDeZona = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Interior = table.Column<string>(type: "text", nullable: true),
                    Lote = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<string>(type: "text", nullable: true),
                    Manzana = table.Column<string>(type: "text", nullable: true),
                    Kilometro = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_10", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Padron_sunat_20",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ruc = table.Column<string>(type: "text", nullable: true),
                    RazonSocial = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    Condicion = table.Column<string>(type: "text", nullable: true),
                    Ubigeo = table.Column<string>(type: "text", nullable: true),
                    TipoDeVia = table.Column<string>(type: "text", nullable: true),
                    NombreDeVia = table.Column<string>(type: "text", nullable: true),
                    CodigoDeZona = table.Column<string>(type: "text", nullable: true),
                    TipoDeZona = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Interior = table.Column<string>(type: "text", nullable: true),
                    Lote = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<string>(type: "text", nullable: true),
                    Manzana = table.Column<string>(type: "text", nullable: true),
                    Kilometro = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_20", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Padron_sunat_10");

            migrationBuilder.DropTable(
                name: "Padron_sunat_20");
        }
    }
}
