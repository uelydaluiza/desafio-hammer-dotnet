using Microsoft.EntityFrameworkCore.Migrations;

namespace BarbecueChallengeDotNet.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    SeConvidado = table.Column<bool>(nullable: false),
                    SeVaiBeber = table.Column<bool>(nullable: false),
                    SeEmpregado = table.Column<bool>(nullable: false),
                    SeCancelado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "Nome", "SeCancelado", "SeConvidado", "SeEmpregado", "SeVaiBeber" },
                values: new object[] { 1, "Ana Flávia", false, true, false, true });

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "Nome", "SeCancelado", "SeConvidado", "SeEmpregado", "SeVaiBeber" },
                values: new object[] { 2, "Ayrton Souza", false, true, false, false });

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "Nome", "SeCancelado", "SeConvidado", "SeEmpregado", "SeVaiBeber" },
                values: new object[] { 3, "Maria Eduarda", false, false, true, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participant");
        }
    }
}
