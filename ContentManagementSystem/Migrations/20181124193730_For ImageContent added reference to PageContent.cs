using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagementSystem.Migrations
{
    public partial class ForImageContentaddedreferencetoPageContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageContentId",
                table: "ImageContent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImageContent_PageContentId",
                table: "ImageContent",
                column: "PageContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageContent_PagesContent_PageContentId",
                table: "ImageContent",
                column: "PageContentId",
                principalTable: "PagesContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageContent_PagesContent_PageContentId",
                table: "ImageContent");

            migrationBuilder.DropIndex(
                name: "IX_ImageContent_PageContentId",
                table: "ImageContent");

            migrationBuilder.DropColumn(
                name: "PageContentId",
                table: "ImageContent");
        }
    }
}
