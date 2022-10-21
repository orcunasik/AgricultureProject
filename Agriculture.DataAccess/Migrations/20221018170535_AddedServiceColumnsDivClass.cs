using Microsoft.EntityFrameworkCore.Migrations;

namespace Agriculture.DataAccess.Migrations
{
    public partial class AddedServiceColumnsDivClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DivClass1",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DivClass2",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DivClass1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "DivClass2",
                table: "Services");
        }
    }
}
