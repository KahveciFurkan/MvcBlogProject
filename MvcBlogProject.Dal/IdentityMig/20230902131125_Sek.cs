using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class Sek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 285, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 285, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 285, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5b0ae142-6123-4c1a-bc65-70713dee4927");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "53eb3bcf-b075-4c1e-8fd1-bd8c117d6d66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "13407b19-a282-4773-9ce7-fde2db679b40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3d2c32b-0029-4e7b-9f2b-784755b7b07c", "AQAAAAEAACcQAAAAEObi96mdYVw3wJx/Av4MH+iMJMdDS7cVrE2szDF6++1Bz2aYGTTqxS/1mjUbUeQMfQ==", "a10ac451-751c-47d5-9b1a-01f89e90ae31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0195ec16-d85a-4c90-8d6b-d572bc42593b", "AQAAAAEAACcQAAAAEArFAMecumm/j1DA6JWFtAeDhPJ/YLRFu8dPnICQDkP1tbSRfvk/0fuYWD74QUbYdg==", "707eb5fa-3e58-4812-bd58-abedd9151c7b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 285, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 285, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 285, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 286, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 286, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 11, 24, 286, DateTimeKind.Local).AddTicks(1726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }
    }
}
