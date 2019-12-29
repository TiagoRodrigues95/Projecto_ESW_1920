using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class Add_Ata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inquerito_Resposta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    AnoLetivo = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    InqueritoId = table.Column<int>(nullable: false),
                    UtilizadorId = table.Column<int>(nullable: false),
                    UtilizadorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquerito_Resposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inquerito_Resposta_Inquerito_InqueritoId",
                        column: x => x.InqueritoId,
                        principalTable: "Inquerito",
                        principalColumn: "InqueritoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inquerito_Resposta_AspNetUsers_UtilizadorId1",
                        column: x => x.UtilizadorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inquerito_Resposta_InqueritoId",
                table: "Inquerito_Resposta",
                column: "InqueritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquerito_Resposta_UtilizadorId1",
                table: "Inquerito_Resposta",
                column: "UtilizadorId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inquerito_Resposta");
        }
    }
}
