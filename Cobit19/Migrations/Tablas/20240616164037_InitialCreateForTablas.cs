using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit19.Migrations.Tablas
{
    /// <inheritdoc />
    public partial class InitialCreateForTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MetasAlineamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetaGobierno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AG01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AG13 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetasAlineamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetasEmpresarialess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetaAlineamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EG01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EG13 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetasEmpresarialess", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetasAlineamientos");

            migrationBuilder.DropTable(
                name: "MetasEmpresarialess");
        }
    }
}
