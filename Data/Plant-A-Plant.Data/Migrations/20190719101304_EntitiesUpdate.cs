using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_A_Plant.Data.Migrations
{
    public partial class EntitiesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Plants",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PestTypes",
                newName: "ShortDescription");

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Plants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "PestTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Families",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "PestTypes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Families");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Plants",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "PestTypes",
                newName: "Description");
        }
    }
}
