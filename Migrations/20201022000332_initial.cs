using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    VisitaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Nombres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.VisitaId);
                });

            migrationBuilder.InsertData(
                table: "Visitas",
                columns: new[] { "VisitaId", "Fecha", "Nombres" },
                values: new object[] { 1, new DateTime(2020, 10, 21, 20, 3, 31, 842, DateTimeKind.Local).AddTicks(8930), "Miguel Jose" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitas");
        }
    }
}
