using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class update_hora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hora_AspNetUsers_UtilizadorId1",
                table: "Hora");

            migrationBuilder.DropIndex(
                name: "IX_Hora_UtilizadorId1",
                table: "Hora");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "Hora");

            migrationBuilder.AlterColumn<string>(
                name: "UtilizadorId",
                table: "Hora",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "IX_Hora_UtilizadorId",
                table: "Hora",
                column: "UtilizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_AlunoId1",
                table: "MarcacaoDuvidas",
                column: "AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacaoDuvidas_HoraId",
                table: "MarcacaoDuvidas",
                column: "HoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hora_AspNetUsers_UtilizadorId",
                table: "Hora",
                column: "UtilizadorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hora_AspNetUsers_UtilizadorId",
                table: "Hora");

            migrationBuilder.DropTable(
                name: "MarcacaoDuvidas");

            migrationBuilder.DropIndex(
                name: "IX_Hora_UtilizadorId",
                table: "Hora");

            migrationBuilder.AlterColumn<int>(
                name: "UtilizadorId",
                table: "Hora",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "Hora",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hora_UtilizadorId1",
                table: "Hora",
                column: "UtilizadorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Hora_AspNetUsers_UtilizadorId1",
                table: "Hora",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
