using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_marcacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarcacaoDuvidas",
                columns: table => new
                {
                    MD_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false),
                    AlunoId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcacaoDuvidas", x => x.MD_Id);
                    table.ForeignKey(
                        name: "FK_MarcacaoDuvidas_AspNetUsers_AlunoId1",
                        column: x => x.AlunoId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarcacaoDuvidas_Hora_HoraId",
                        column: x => x.HoraId,
                        principalTable: "Hora",
                        principalColumn: "HoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_AlunoId1",
                table: "MarcacaoDuvidas",
                column: "AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_HoraId",
                table: "MarcacaoDuvidas",
                column: "HoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcacaoDuvidas");
        }
    }
}
