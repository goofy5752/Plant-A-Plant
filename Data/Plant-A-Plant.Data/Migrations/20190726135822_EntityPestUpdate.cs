﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantAPlant.Data.Migrations
{
    public partial class EntityPestUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
