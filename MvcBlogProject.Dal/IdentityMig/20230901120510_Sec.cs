using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class Sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleIdId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6d20b0f2-09fa-4b00-ad8b-215f8a073aa9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c0d6a5b7-2290-4493-ada2-1dd4c0d903ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "854016fd-3859-487f-8810-f63f834d64dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84acfa27-a684-4b4f-99ed-afb92bc73424", "AQAAAAEAACcQAAAAEPTKFxuYeq3i4qs23rM3PVrCvY2PhvC1/ycC6KnQIiWAArk05l40BYh152DQskzUwA==", "363dc623-7489-4d65-bbb0-c7fae3119f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "357bd48d-6e7b-4e86-a153-c7fc7d569a2f", "AQAAAAEAACcQAAAAEPIcz5ahh7n1x823g6MpUit344lH//GoABKJIzPWCGJ7k+k8Mb9Q57g/RB5lL43Gig==", "3dba6700-6db7-47aa-a0f6-15f367aa7003" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 5, 9, 126, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleIdId",
                table: "AspNetUsers",
                column: "RoleIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleIdId",
                table: "AspNetUsers",
                column: "RoleIdId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleIdId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleIdId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleIdId",
                table: "AspNetUsers");

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
    }
}
