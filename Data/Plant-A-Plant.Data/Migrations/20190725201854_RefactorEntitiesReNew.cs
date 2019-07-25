using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantAPlant.Data.Migrations
{
    public partial class RefactorEntitiesReNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pests_PestTypes_PestTypeId",
                table: "Pests");

            migrationBuilder.DropTable(
                name: "PestTypes");

            migrationBuilder.DropIndex(
                name: "IX_Pests_PestTypeId",
                table: "Pests");

            migrationBuilder.DropColumn(
                name: "PestTypeId",
                table: "Pests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PestTypeId",
                table: "Pests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PestTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PestTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pests_PestTypeId",
                table: "Pests",
                column: "PestTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pests_PestTypes_PestTypeId",
                table: "Pests",
                column: "PestTypeId",
                principalTable: "PestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
