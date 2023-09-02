using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class cc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "82ca4f80-9eb0-4a8d-b1af-1607e2906208");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d72365d7-6737-4cf7-83d2-3fefa50974c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3408ab9c-1799-4cf1-a42b-573ca31d2425");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f2c3757-ef79-440a-acc4-d1fbbb30d3b9", "AQAAAAEAACcQAAAAEKx45GjxOoTIVBfT3ZOSnZEQuxudkE2SrX3CFFD5OimCd90vcQvsQkh/x5A03eYcEA==", "4cbaf772-1df8-4263-b4ce-cd719b7250d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9873e7-9b2f-4ec9-a9b1-d123bd20d51e", "AQAAAAEAACcQAAAAEPXB0aNuEnOWwtqq5qFf4sdEoPgGijXeTVrGHnjtodG45CWZX4Z6+StrdvPFao9olg==", "bc0b956f-94d8-40ad-a6d9-e73bbf707d66" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 23, 10, 816, DateTimeKind.Local).AddTicks(4648));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
