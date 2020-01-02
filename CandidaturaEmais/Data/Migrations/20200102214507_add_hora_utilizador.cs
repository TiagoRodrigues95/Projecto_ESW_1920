using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_hora_utilizador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contacto",
                table: "Empresa",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contacto",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 9,
                oldNullable: true);
        }
    }
}
