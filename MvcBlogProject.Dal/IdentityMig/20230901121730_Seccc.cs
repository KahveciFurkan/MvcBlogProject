using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class Seccc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "85a07ab8-ce22-482e-9697-1a1181b69489");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "759c97b3-fc73-4a82-afa7-8e8f797f3f94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3350f707-b853-44e0-ba8d-fe2e2b9eb718");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0a14bd4-25d7-4d45-9dad-b32cb1e0f118", "AQAAAAEAACcQAAAAEDalty258v+dr1ao0ArPCoTPOWgZ+YxofnC1NVNvMhMeCWx6Q31LJZacXCihXGL1PA==", "a61480af-f3e3-4a5f-a065-3c2644904950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dde4a11-a070-4f16-8c10-b36e10631cfc", "AQAAAAEAACcQAAAAELRTooUtIzUX/hBTu88MiijPn/yzDkCg7prwoRrFtUoc8smSGsWiV1DjFj0yYeo2jQ==", "9dc163c1-b967-48ce-b114-25d95a4d586c" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 17, 29, 132, DateTimeKind.Local).AddTicks(7818));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmCode",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4907becf-938a-4f25-a12c-f2925481f7af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3dbc630c-9080-462e-a6d3-1b3e310fd10d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "91b46e71-e715-4790-8889-749f412d90df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09ab815-0f49-42ab-9b1d-8799f64b216a", "AQAAAAEAACcQAAAAEKjQL2S/7eI8it15tbHnEtbXbDp7k0gvTVTejrZziJzxEvTZ1a0qSsN1HyMHO6Dl5g==", "a2b0a110-5b6f-4d94-ac7c-fa4a336a1695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb01968-61c9-40ad-924d-ec2ea460a869", "AQAAAAEAACcQAAAAEBS/MHXTmo7TnEIo9d+atZJjCSS3T2WwyJidkGUZCHnIa+Z3BuQdgKeoET7OdntWIA==", "20740de0-51fb-44a1-8639-5b6989ed4dec" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 13, 34, 20, DateTimeKind.Local).AddTicks(5127));
        }
    }
}
