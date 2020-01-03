using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_inquerito_resposta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InqueritoResposta",
                columns: table => new
                {
                    InqueritoRespostaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    AnoLetivo = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    InqueritoId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InqueritoResposta", x => x.InqueritoRespostaId);
                    table.ForeignKey(
                        name: "FK_InqueritoResposta_AspNetUsers_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InqueritoResposta_Inquerito_InqueritoId",
                        column: x => x.InqueritoId,
                        principalTable: "Inquerito",
                        principalColumn: "InqueritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InqueritoResposta_AlunoId",
                table: "InqueritoResposta",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_InqueritoResposta_InqueritoId",
                table: "InqueritoResposta",
                column: "InqueritoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InqueritoResposta");
        }
    }
}
