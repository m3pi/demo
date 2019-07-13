using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sisso.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ApellidoMaterno = table.Column<string>(nullable: true),
                    ApellidoPaterno = table.Column<string>(nullable: true),
                    NroDoi = table.Column<string>(nullable: true),
                    PrimerNombre = table.Column<string>(nullable: true),
                    SegundoNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "ApellidoMaterno", "ApellidoPaterno", "Created", "Deleted", "Modified", "NroDoi", "PrimerNombre", "SegundoNombre" },
                values: new object[] { new Guid("ac902172-aeb3-4285-9e7e-a512a69e69ea"), "Guarniz", "Saavedra", new DateTime(2019, 7, 13, 16, 25, 57, 42, DateTimeKind.Unspecified).AddTicks(6924), null, new DateTime(2019, 7, 13, 16, 25, 57, 44, DateTimeKind.Unspecified).AddTicks(4153), "47701560", "Oscar", "Geny" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "ApellidoMaterno", "ApellidoPaterno", "Created", "Deleted", "Modified", "NroDoi", "PrimerNombre", "SegundoNombre" },
                values: new object[] { new Guid("e1725f29-4aea-4fc0-8a55-55a6bf9d96a9"), "Urteaga", "Bazan", new DateTime(2019, 7, 13, 16, 25, 57, 45, DateTimeKind.Unspecified).AddTicks(128), null, new DateTime(2019, 7, 13, 16, 25, 57, 45, DateTimeKind.Unspecified).AddTicks(161), "87654321", "Anderson", "Kevin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
