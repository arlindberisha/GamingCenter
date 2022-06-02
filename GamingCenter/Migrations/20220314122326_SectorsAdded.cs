using Microsoft.EntityFrameworkCore.Migrations;

namespace GamingCenter.Migrations
{
    public partial class SectorsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SectorsId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_SectorsId",
                table: "Workers",
                column: "SectorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Sectors_SectorsId",
                table: "Workers",
                column: "SectorsId",
                principalTable: "Sectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Sectors_SectorsId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropIndex(
                name: "IX_Workers_SectorsId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "SectorsId",
                table: "Workers");
        }
    }
}
