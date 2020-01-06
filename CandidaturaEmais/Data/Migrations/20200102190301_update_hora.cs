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

            migrationBuilder.CreateIndex(
                name: "IX_Hora_UtilizadorId",
                table: "Hora",
                column: "UtilizadorId");

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
