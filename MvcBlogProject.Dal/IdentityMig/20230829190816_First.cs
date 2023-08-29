using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article");

            migrationBuilder.AddColumn<int>(
                name: "ImageType",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Article",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ArticleName",
                table: "Article",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3175bee4-7d5f-462a-a63a-f1e9a846d2fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d76e4da9-f12e-4a39-a625-299c756a4fca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8a5bcf0d-64c4-4848-a07e-e4e960d75bd9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31129582-89c6-4582-8937-df0fc1622c94", "AQAAAAEAACcQAAAAEOpqp7XlHkztVvvCoN8/r3uQP6p7lP9os/OqwhlUaXLK9O97rbyQFDsjtmnZwCVulw==", "93b741aa-3e93-43f0-ab08-f00bec5a32d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8ea41a4-e3c2-438a-a644-a0d02b1568bd", "AQAAAAEAACcQAAAAEK+sdph9YxvCaugkEFmvVI5GcZookSd2nygqje/HkWPuXRGNmB32N9zFLnQyTJ0ebA==", "51bdabb6-2b7c-4ddd-bd68-90b22614520e" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8391), null, null, false, null, null, "Doğa" },
                    { 2, "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8395), null, null, false, null, null, "Spor" },
                    { 3, "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8398), null, null, false, null, null, "Magazin" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ImageType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9551), null, null, "images/test", "jpg", 0, false, null, null },
                    { 2, "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9554), null, null, "images/zay", "jpg", 0, false, null, null },
                    { 3, "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9558), null, null, "images/uzaay", "png", 0, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AppUserId", "ArticleName", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId", "ViewCount" },
                values: new object[] { 1, null, "THİS", 1, "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.", "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7344), null, null, 1, false, null, null, 1, 15 });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AppUserId", "ArticleName", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId", "ViewCount" },
                values: new object[] { 2, null, "IS", 1, "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.", "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7348), null, null, 1, false, null, null, 2, 10 });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AppUserId", "ArticleName", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId", "ViewCount" },
                values: new object[] { 3, null, "MINE", 1, "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.", "Admin", new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7352), null, null, 1, false, null, null, 2, 10 });

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article");

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Article",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "ArticleName",
                table: "Article",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "283d144d-af42-4e2e-9e44-ff0aea905f6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bc40bb58-a96d-4df1-912e-6b34986f5b15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1c39ffd3-c162-44b5-b99b-b4bf42e4b6a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f5d0419-aca6-4fcf-a558-b3a6cc7fd922", "AQAAAAEAACcQAAAAEI59HJgzB+QQWVVQsUWYGpOkWxcsZPFhqEltFX1QmzPKgEA6lRNqj7Bn2ODnLXjAIw==", "444296b8-5e74-4fda-aac8-66eba721df3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4fa34ac-65d5-4332-9769-3de04e55a5f2", "AQAAAAEAACcQAAAAEER6S+JTknZZjvJZZ6TEwmh2T5h3K97N393ZgpwrR3hR4s5rTCgLDmzXcwX3KdmEew==", "17630ad5-0a66-42c6-a778-43c2781bb0a8" });

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
