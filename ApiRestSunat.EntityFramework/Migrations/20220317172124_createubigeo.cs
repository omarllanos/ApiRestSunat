using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiRestSunat.EntityFramework.Migrations
{
    public partial class createubigeo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ubigeo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ubigeo_reniec = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Ubigeo_inei = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Departamento_inei = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Departamento = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Provincia_inei = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Provincia = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Distrito = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Region = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Macroregion_inei = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Macroregion_minsa = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Iso_3166_2 = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Fips = table.Column<string>(type: "VARCHAR(4)", nullable: true),
                    Superficie = table.Column<decimal>(type: "numeric(11,2)", nullable: false),
                    Altitud = table.Column<int>(type: "integer", nullable: false),
                    Latitud = table.Column<decimal>(type: "numeric(14,8)", nullable: false),
                    Longitud = table.Column<decimal>(type: "numeric(14,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ubigeo");
        }
    }
}
