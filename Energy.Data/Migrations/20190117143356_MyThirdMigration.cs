using Microsoft.EntityFrameworkCore.Migrations;

namespace Energy.Data.Migrations
{
    public partial class MyThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LamdaValue",
                table: "Materials",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LamdaValue",
                table: "Materials");
        }
    }
}
