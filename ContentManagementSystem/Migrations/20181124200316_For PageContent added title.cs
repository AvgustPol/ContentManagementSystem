using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagementSystem.Migrations
{
    public partial class ForPageContentaddedtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "PagesContent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "PagesContent");
        }
    }
}
