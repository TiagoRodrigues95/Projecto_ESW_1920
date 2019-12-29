using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_marcacao_reuniao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarcacaoReuniao",
                columns: table => new
                {
                    MarcacaoReuniaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false),
                    AlunoId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcacaoReuniao", x => x.MarcacaoReuniaoId);
                    table.ForeignKey(
                        name: "FK_MarcacaoReuniao_AspNetUsers_AlunoId1",
                        column: x => x.AlunoId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarcacaoReuniao_Hora_HoraId",
                        column: x => x.HoraId,
                        principalTable: "Hora",
                        principalColumn: "HoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoReuniao_AlunoId1",
                table: "MarcacaoReuniao",
                column: "AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoReuniao_HoraId",
                table: "MarcacaoReuniao",
                column: "HoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcacaoReuniao");
        }
    }
}
