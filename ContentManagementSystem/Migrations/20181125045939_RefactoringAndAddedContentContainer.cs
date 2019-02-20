using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagementSystem.Migrations
{
    public partial class RefactoringAndAddedContentContainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextsContent_PagesContent_PageId",
                table: "TextsContent");

            migrationBuilder.DropTable(
                name: "ImageContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextsContent",
                table: "TextsContent");

            migrationBuilder.RenameTable(
                name: "TextsContent",
                newName: "ContentComponent");

            migrationBuilder.RenameIndex(
                name: "IX_TextsContent_PageId",
                table: "ContentComponent",
                newName: "IX_ContentContainer_PageId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ContentComponent",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PageContentId",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Length",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageContentId1",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "ContentComponent",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentContainer",
                table: "ContentComponent",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ContentContainer_PageContentId",
                table: "ContentComponent",
                column: "PageContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentContainer_PageContentId1",
                table: "ContentComponent",
                column: "PageContentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentContainer_PagesContent_PageContentId",
                table: "ContentComponent",
                column: "PageContentId",
                principalTable: "PagesContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentContainer_PagesContent_PageContentId1",
                table: "ContentComponent",
                column: "PageContentId1",
                principalTable: "PagesContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentContainer_PagesContent_PageId",
                table: "ContentComponent",
                column: "PageId",
                principalTable: "PagesContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentContainer_PagesContent_PageContentId",
                table: "ContentComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentContainer_PagesContent_PageContentId1",
                table: "ContentComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentContainer_PagesContent_PageId",
                table: "ContentComponent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentContainer",
                table: "ContentComponent");

            migrationBuilder.DropIndex(
                name: "IX_ContentContainer_PageContentId",
                table: "ContentComponent");

            migrationBuilder.DropIndex(
                name: "IX_ContentContainer_PageContentId1",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "PageContentId",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "PageContentId1",
                table: "ContentComponent");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "ContentComponent");

            migrationBuilder.RenameTable(
                name: "ContentComponent",
                newName: "TextsContent");

            migrationBuilder.RenameIndex(
                name: "IX_ContentContainer_PageId",
                table: "TextsContent",
                newName: "IX_TextsContent_PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextsContent",
                table: "TextsContent",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ImageContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentType = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true),
                    Length = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PageContentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageContent_PagesContent_PageContentId",
                        column: x => x.PageContentId,
                        principalTable: "PagesContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageContent_PageContentId",
                table: "ImageContent",
                column: "PageContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TextsContent_PagesContent_PageId",
                table: "TextsContent",
                column: "PageId",
                principalTable: "PagesContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
