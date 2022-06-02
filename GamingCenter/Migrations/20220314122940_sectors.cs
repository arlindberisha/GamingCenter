using Microsoft.EntityFrameworkCore.Migrations;

namespace GamingCenter.Migrations
{
    public partial class sectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Sectors_SectorsId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "Workers");

            migrationBuilder.AlterColumn<int>(
                name: "SectorsId",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Sectors_SectorsId",
                table: "Workers",
                column: "SectorsId",
                principalTable: "Sectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Sectors_SectorsId",
                table: "Workers");

            migrationBuilder.AlterColumn<int>(
                name: "SectorsId",
                table: "Workers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Sectors_SectorsId",
                table: "Workers",
                column: "SectorsId",
                principalTable: "Sectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
