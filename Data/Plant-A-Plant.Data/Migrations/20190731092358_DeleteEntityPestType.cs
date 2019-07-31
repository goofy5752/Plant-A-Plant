using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantAPlant.Data.Migrations
{
    public partial class DeleteEntityPestType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pests_PestTypes_TypeId",
                table: "Pests");

            migrationBuilder.DropTable(
                name: "PestTypes");

            migrationBuilder.DropIndex(
                name: "IX_Pests_TypeId",
                table: "Pests");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Pests");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Pests",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Pests");

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Pests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PestTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PestTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pests_TypeId",
                table: "Pests",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pests_PestTypes_TypeId",
                table: "Pests",
                column: "TypeId",
                principalTable: "PestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
