﻿// <auto-generated />
using System;
using ContentManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContentManagementSystem.Migrations
{
    [DbContext(typeof(WebsiteContentContext))]
    partial class WebsiteContentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.ContentComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("PageContentId");

                    b.HasKey("Id");

                    b.HasIndex("PageContentId");

                    b.ToTable("ContentComponent");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ContentComponent");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.PageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageName");

                    b.Property<string>("PageTitle");

                    b.HasKey("Id");

                    b.ToTable("PagesContent");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.Image", b =>
                {
                    b.HasBaseType("ContentManagementSystem.Data.Entities.ContentComponent");

                    b.Property<string>("ContentType");

                    b.Property<byte[]>("Data");

                    b.Property<long>("Length");

                    b.Property<string>("Name");

                    b.ToTable("Image");

                    b.HasDiscriminator().HasValue("Image");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.TextContent", b =>
                {
                    b.HasBaseType("ContentManagementSystem.Data.Entities.ContentComponent");

                    b.Property<int>("Language");

                    b.Property<int?>("PageId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasIndex("PageId");

                    b.ToTable("TextContent");

                    b.HasDiscriminator().HasValue("TextContent");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.ContentComponent", b =>
                {
                    b.HasOne("ContentManagementSystem.Data.Entities.PageContent")
                        .WithMany("Content")
                        .HasForeignKey("PageContentId");
                });

            modelBuilder.Entity("ContentManagementSystem.Data.Entities.TextContent", b =>
                {
                    b.HasOne("ContentManagementSystem.Data.Entities.PageContent", "Page")
                        .WithMany()
                        .HasForeignKey("PageId");
                });
#pragma warning restore 612, 618
        }
    }
}
