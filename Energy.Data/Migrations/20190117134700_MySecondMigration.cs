using Microsoft.EntityFrameworkCore.Migrations;

namespace Energy.Data.Migrations
{
    public partial class MySecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameofTheMaterial",
                table: "Materials",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameofTheMaterial",
                table: "Materials");
        }
    }
}
