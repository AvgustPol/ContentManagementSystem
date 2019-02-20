﻿// <auto-generated />
using System;
using ContentManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContentManagementSystem.Migrations
{
    [DbContext(typeof(WebsiteContentContext))]
    [Migration("20181115085122_Adding-Image")]
    partial class AddingImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.ImageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentType");

                    b.Property<byte[]>("Data");

                    b.Property<long>("Length");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ImageContent");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.PageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageName");

                    b.HasKey("Id");

                    b.ToTable("PagesContent");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.TextContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PageId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("TextsContent");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.TextContent", b =>
                {
                    b.HasOne("ContentManagementSystem.Data.Entities.PageContent", "Page")
                        .WithMany("TextContent")
                        .HasForeignKey("PageId");
                });
#pragma warning restore 612, 618
        }
    }
}
