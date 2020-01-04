using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_reuniao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reuniao",
                columns: table => new
                {
                    ReuniaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraId = table.Column<int>(nullable: false),
                    AtaId = table.Column<int>(nullable: false),
                    UtilizadorIdParticipante = table.Column<string>(nullable: false),
                    UtilizadorIdConvocado = table.Column<string>(nullable: false),
                    UtilizadorParticipanteId = table.Column<string>(nullable: true),
                    UtilizadorConvocadoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reuniao", x => x.ReuniaoId);
                    table.ForeignKey(
                        name: "FK_Reuniao_AtaReuniao_AtaId",
                        column: x => x.AtaId,
                        principalTable: "AtaReuniao",
                        principalColumn: "AtaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reuniao_Hora_HoraId",
                        column: x => x.HoraId,
                        principalTable: "Hora",
                        principalColumn: "HoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reuniao_AspNetUsers_UtilizadorConvocadoId",
                        column: x => x.UtilizadorConvocadoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reuniao_AspNetUsers_UtilizadorParticipanteId",
                        column: x => x.UtilizadorParticipanteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_AtaId",
                table: "Reuniao",
                column: "AtaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_HoraId",
                table: "Reuniao",
                column: "HoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_UtilizadorConvocadoId",
                table: "Reuniao",
                column: "UtilizadorConvocadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_UtilizadorParticipanteId",
                table: "Reuniao",
                column: "UtilizadorParticipanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reuniao");
        }
    }
}
