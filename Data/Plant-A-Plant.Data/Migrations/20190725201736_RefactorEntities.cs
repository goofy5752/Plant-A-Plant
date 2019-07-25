using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantAPlant.Data.Migrations
{
    public partial class RefactorEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pests_PestTypes_PestTypeId",
                table: "Pests");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "PestTypes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PestTypes");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "PestTypes");

            migrationBuilder.AddColumn<string>(
                name: "PaPUserId",
                table: "RegisterActivities",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Plants",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<Guid>(
                name: "PestTypeId",
                table: "Pests",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Pests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuperFamily",
                table: "Pests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaPUserId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegisterActivities_PaPUserId",
                table: "RegisterActivities",
                column: "PaPUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PaPUserId",
                table: "Events",
                column: "PaPUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_PaPUserId",
                table: "Events",
                column: "PaPUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pests_PestTypes_PestTypeId",
                table: "Pests",
                column: "PestTypeId",
                principalTable: "PestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterActivities_AspNetUsers_PaPUserId",
                table: "RegisterActivities",
                column: "PaPUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_PaPUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Pests_PestTypes_PestTypeId",
                table: "Pests");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisterActivities_AspNetUsers_PaPUserId",
                table: "RegisterActivities");

            migrationBuilder.DropIndex(
                name: "IX_RegisterActivities_PaPUserId",
                table: "RegisterActivities");

            migrationBuilder.DropIndex(
                name: "IX_Events_PaPUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PaPUserId",
                table: "RegisterActivities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pests");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Pests");

            migrationBuilder.DropColumn(
                name: "SuperFamily",
                table: "Pests");

            migrationBuilder.DropColumn(
                name: "PaPUserId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Plants",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
                table: "PestTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "PestTypes",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PestTypeId",
                table: "Pests",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pests_PestTypes_PestTypeId",
                table: "Pests",
                column: "PestTypeId",
                principalTable: "PestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
