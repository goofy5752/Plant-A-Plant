using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantAPlant.Data.Migrations
{
    public partial class FeedbackDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    SenderEmail = table.Column<string>(nullable: true),
                    SenderPhoneNumber = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    SendOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");
        }
    }
}
