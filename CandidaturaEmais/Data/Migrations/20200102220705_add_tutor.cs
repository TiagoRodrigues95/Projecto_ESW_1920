using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidaturaEmais.Data.Migrations
{
    public partial class add_tutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    TutorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Contacto = table.Column<string>(maxLength: 9, nullable: true),
                    Email = table.Column<string>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.TutorId);
                    table.ForeignKey(
                        name: "FK_Tutor_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_EmpresaId",
                table: "Tutor",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tutor");
        }
    }
}
