using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaE_.Data.Migrations
{
    public partial class Add_Inquerito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inquerito",
                columns: table => new
                {
                    InqueritoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    AnoLetivo = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquerito", x => x.InqueritoId);
                });

            migrationBuilder.CreateTable(
                name: "MarcacaoDuvidas",
                columns: table => new
                {
                    MRId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraId = table.Column<int>(nullable: false),
                    UtilizadorId = table.Column<int>(nullable: false),
                    UtilizadorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcacaoDuvidas", x => x.MRId);
                    table.ForeignKey(
                        name: "FK_MarcacaoDuvidas_AspNetUsers_UtilizadorId1",
                        column: x => x.UtilizadorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarcacaoReuniao",
                columns: table => new
                {
                    MR_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraId = table.Column<int>(nullable: false),
                    UtilizadorId = table.Column<int>(nullable: false),
                    UtilizadorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcacaoReuniao", x => x.MR_Id);
                    table.ForeignKey(
                        name: "FK_MarcacaoReuniao_AspNetUsers_UtilizadorId1",
                        column: x => x.UtilizadorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "Ata",
                columns: table => new
                {
                    AtaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    MR_Id = table.Column<int>(nullable: false),
                    UtilizadorId = table.Column<int>(nullable: false),
                    MarcacaoReuniaoMR_Id = table.Column<int>(nullable: true),
                    UtilizadorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ata", x => x.AtaId);
                    table.ForeignKey(
                        name: "FK_Ata_MarcacaoReuniao_MarcacaoReuniaoMR_Id",
                        column: x => x.MarcacaoReuniaoMR_Id,
                        principalTable: "MarcacaoReuniao",
                        principalColumn: "MR_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ata_AspNetUsers_UtilizadorId1",
                        column: x => x.UtilizadorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ata_MarcacaoReuniaoMR_Id",
                table: "Ata",
                column: "MarcacaoReuniaoMR_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ata_UtilizadorId1",
                table: "Ata",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Inquerito_Resposta_InqueritoId",
                table: "Inquerito_Resposta",
                column: "InqueritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquerito_Resposta_UtilizadorId1",
                table: "Inquerito_Resposta",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_UtilizadorId1",
                table: "MarcacaoDuvidas",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoReuniao_UtilizadorId1",
                table: "MarcacaoReuniao",
                column: "UtilizadorId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ata");

            migrationBuilder.DropTable(
                name: "Inquerito_Resposta");

            migrationBuilder.DropTable(
                name: "MarcacaoDuvidas");

            migrationBuilder.DropTable(
                name: "MarcacaoReuniao");

            migrationBuilder.DropTable(
                name: "Inquerito");
        }
    }
}
