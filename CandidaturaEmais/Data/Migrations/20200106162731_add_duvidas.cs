using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_duvidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarcacaoDuvidas",
                columns: table => new
                {
                    MarcacaoDuvidasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcacaoDuvidas", x => x.MarcacaoDuvidasId);
                    table.ForeignKey(
                        name: "FK_MarcacaoDuvidas_AspNetUsers_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarcacaoDuvidas_Hora_HoraId",
                        column: x => x.HoraId,
                        principalTable: "Hora",
                        principalColumn: "HoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_AlunoId",
                table: "MarcacaoDuvidas",
                column: "AlunoId");

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
