using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class oo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "90928634-0d05-48c3-813a-eab1b4addf24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5f4456db-ce86-4fec-aa30-b490bd24f6ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ab0fa59b-b583-4596-88be-09ad95c63855");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e48dbebd-23a2-4b50-adbc-bc0a9ac4edde", "AQAAAAEAACcQAAAAEN0Ia3X/nCb+A9DelR4ZBEgsv5k2b6NQiWBOUhWA//3kcgyAlczM9dX4xTGOmZEWQw==", "9682c262-cdd5-4925-ba18-8e7b7413e606" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d1541e3-6973-45a7-ab1d-1c0011c5f0fd", "AQAAAAEAACcQAAAAEJDP7uWdm9zElth1xkGMSgtvGsQl+DxoqNVrg1NT2FAbHGOg3JYJgp34LW7d+CmzFw==", "1210d44d-2c9c-423f-90b4-adaf77e17d2a" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 16, 30, 13, 153, DateTimeKind.Local).AddTicks(5021));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
