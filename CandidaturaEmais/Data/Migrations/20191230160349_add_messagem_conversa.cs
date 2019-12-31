using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_messagem_conversa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mensagem",
                table: "MensagemConversa",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mensagem",
                table: "MensagemConversa");
        }
    }
}
