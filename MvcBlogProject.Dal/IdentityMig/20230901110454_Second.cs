using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaswordConfirm",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5cf091bf-6d57-46da-8cc0-46aca8f8283d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2d7d6fd0-ad64-473e-8c4f-736c79968f91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5f297262-15c3-4243-a3ad-b746547550c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c78df87a-c186-4656-97c1-a2ae992d92e0", "AQAAAAEAACcQAAAAELq++faOZOrL3BBd26PgFOda50b8cuDmuJkaIFnGgMrhnHHRlCpq0kNCJWvYxi17iQ==", "bf4f3a7f-0668-4d75-bfd8-7860dbaaf728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89892fac-51eb-4ad9-b943-0df6d241fdad", "AQAAAAEAACcQAAAAECUeYP3xo8KP0h1Bz7AnhlvRSJtJFveERWx2FjCT5BT3cGr3FEEtXDdAWamkTaVphg==", "8aab5989-74f4-45b1-bf13-dedc21868311" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 14, 4, 53, 991, DateTimeKind.Local).AddTicks(9759));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PaswordConfirm",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(7352));

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 8, 15, 495, DateTimeKind.Local).AddTicks(9558));
        }
    }
}
