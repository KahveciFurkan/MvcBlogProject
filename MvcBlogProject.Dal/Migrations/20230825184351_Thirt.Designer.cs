﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcBlogProject.Dal.Concrete.Context;

#nullable disable

namespace MvcBlogProject.Dal.Migrations
{
    [DbContext(typeof(StandartContext))]
    [Migration("20230825184351_Thirt")]
    partial class Thirt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ArticleName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ImageId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleName = "THİS",
                            CategoryId = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(3511),
                            ImageId = 1,
                            IsDeleted = false,
                            ViewCount = 15
                        },
                        new
                        {
                            Id = 2,
                            ArticleName = "IS",
                            CategoryId = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(3516),
                            ImageId = 1,
                            IsDeleted = false,
                            ViewCount = 10
                        },
                        new
                        {
                            Id = 3,
                            ArticleName = "MINE",
                            CategoryId = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(3521),
                            ImageId = 1,
                            IsDeleted = false,
                            ViewCount = 10
                        });
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(4572),
                            IsDeleted = false,
                            Name = "Doğa"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(4575),
                            IsDeleted = false,
                            Name = "Spor"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(4579),
                            IsDeleted = false,
                            Name = "Magazin"
                        });
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(5044),
                            FileName = "images/test",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(5048),
                            FileName = "images/zay",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 25, 21, 43, 50, 457, DateTimeKind.Local).AddTicks(5051),
                            FileName = "images/uzaay",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Article", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcBlogProject.Dal.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
