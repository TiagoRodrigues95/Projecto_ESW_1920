using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_mensagem_conversa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mensagem",
                table: "Notificacao",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "MensagemConversa",
                columns: table => new
                {
                    MensagemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilizadorId = table.Column<int>(nullable: false),
                    utilizador2Id = table.Column<int>(nullable: false),
                    UtilizadorInicianteId = table.Column<string>(nullable: true),
                    UtilizadorDestinatarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MensagemConversa", x => x.MensagemId);
                    table.ForeignKey(
                        name: "FK_MensagemConversa_AspNetUsers_UtilizadorDestinatarioId",
                        column: x => x.UtilizadorDestinatarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MensagemConversa_AspNetUsers_UtilizadorInicianteId",
                        column: x => x.UtilizadorInicianteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MensagemConversa_UtilizadorDestinatarioId",
                table: "MensagemConversa",
                column: "UtilizadorDestinatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MensagemConversa_UtilizadorInicianteId",
                table: "MensagemConversa",
                column: "UtilizadorInicianteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MensagemConversa");

            migrationBuilder.AlterColumn<string>(
                name: "Mensagem",
                table: "Notificacao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
