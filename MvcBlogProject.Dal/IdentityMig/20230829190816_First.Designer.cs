﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcBlogProject.Dal.Concrete.Context;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    [DbContext(typeof(AppIdentityContext))]
    [Migration("20230829190816_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "3175bee4-7d5f-462a-a63a-f1e9a846d2fd",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "d76e4da9-f12e-4a39-a625-299c756a4fca",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "8a5bcf0d-64c4-4848-a07e-e4e960d75bd9",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31129582-89c6-4582-8937-df0fc1622c94",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Eren",
                            ImageId = 1,
                            LastName = "Kartal",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOpqp7XlHkztVvvCoN8/r3uQP6p7lP9os/OqwhlUaXLK9O97rbyQFDsjtmnZwCVulw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "93b741aa-3e93-43f0-ab08-f00bec5a32d8",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e8ea41a4-e3c2-438a-a644-a0d02b1568bd",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Umut",
                            ImageId = 2,
                            LastName = "Öncel",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK+sdph9YxvCaugkEFmvVI5GcZookSd2nygqje/HkWPuXRGNmB32N9zFLnQyTJ0ebA==",
                            PhoneNumber = "1234567870",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "51bdabb6-2b7c-4ddd-bd68-90b22614520e",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("ArticleName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int?>("CategoryId")
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
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Article");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleName = "THİS",
                            CategoryId = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7344),
                            ImageId = 1,
                            IsDeleted = false,
                            UserId = 1,
                            ViewCount = 15
                        },
                        new
                        {
                            Id = 2,
                            ArticleName = "IS",
                            CategoryId = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7348),
                            ImageId = 1,
                            IsDeleted = false,
                            UserId = 2,
                            ViewCount = 10
                        },
                        new
                        {
                            Id = 3,
                            ArticleName = "MINE",
                            CategoryId = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7352),
                            ImageId = 1,
                            IsDeleted = false,
                            UserId = 2,
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

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8391),
                            IsDeleted = false,
                            Name = "Doğa"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8395),
                            IsDeleted = false,
                            Name = "Spor"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8398),
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

                    b.Property<int>("ImageType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9551),
                            FileName = "images/test",
                            FileType = "jpg",
                            ImageType = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9554),
                            FileName = "images/zay",
                            FileType = "jpg",
                            ImageType = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9558),
                            FileName = "images/uzaay",
                            FileType = "png",
                            ImageType = 0,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcBlogProject.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.Article", b =>
                {
                    b.HasOne("MvcBlogProject.Dal.Entities.AppUser", null)
                        .WithMany("Articles")
                        .HasForeignKey("AppUserId");

                    b.HasOne("MvcBlogProject.Dal.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcBlogProject.Dal.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("MvcBlogProject.Dal.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
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