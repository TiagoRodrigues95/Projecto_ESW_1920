using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class Add_MarcacaoDuvidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquerito_Resposta_AspNetUsers_UtilizadorId1",
                table: "Inquerito_Resposta");

            migrationBuilder.DropIndex(
                name: "IX_Inquerito_Resposta_UtilizadorId1",
                table: "Inquerito_Resposta");

            migrationBuilder.DropColumn(
                name: "UtilizadorId",
                table: "Inquerito_Resposta");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "Inquerito_Resposta");

            migrationBuilder.AddColumn<int>(
                name: "Mensagem",
                table: "MensagemConversa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AluniId",
                table: "Inquerito_Resposta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AlunoId",
                table: "Inquerito_Resposta",
                nullable: true);

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
                name: "IX_Inquerito_Resposta_AlunoId",
                table: "Inquerito_Resposta",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_AlunoId1",
                table: "MarcacaoDuvidas",
                column: "AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_HoraId",
                table: "MarcacaoDuvidas",
                column: "HoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquerito_Resposta_AspNetUsers_AlunoId",
                table: "Inquerito_Resposta",
                column: "AlunoId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquerito_Resposta_AspNetUsers_AlunoId",
                table: "Inquerito_Resposta");

            migrationBuilder.DropTable(
                name: "MarcacaoDuvidas");

            migrationBuilder.DropIndex(
                name: "IX_Inquerito_Resposta_AlunoId",
                table: "Inquerito_Resposta");

            migrationBuilder.DropColumn(
                name: "Mensagem",
                table: "MensagemConversa");

            migrationBuilder.DropColumn(
                name: "AluniId",
                table: "Inquerito_Resposta");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Inquerito_Resposta");

            migrationBuilder.AddColumn<int>(
                name: "UtilizadorId",
                table: "Inquerito_Resposta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "Inquerito_Resposta",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inquerito_Resposta_UtilizadorId1",
                table: "Inquerito_Resposta",
                column: "UtilizadorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquerito_Resposta_AspNetUsers_UtilizadorId1",
                table: "Inquerito_Resposta",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
