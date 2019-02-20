using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagementSystem.Migrations
{
    public partial class RefactoringAndAddedContentContainer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentContainer_PagesContent_PageContentId1",
                table: "ContentComponent");

            migrationBuilder.DropIndex(
                name: "IX_ContentContainer_PageContentId1",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "PageContentId1",
                table: "ContentComponent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageContentId1",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentContainer_PageContentId1",
                table: "ContentComponent",
                column: "PageContentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentContainer_PagesContent_PageContentId1",
                table: "ContentComponent",
                column: "PageContentId1",
                principalTable: "PagesContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
