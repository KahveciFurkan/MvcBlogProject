using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBlogProject.Dal.IdentityMig
{
    public partial class Secc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleIdId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "RoleIdId",
                table: "AspNetUsers",
                newName: "AppRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_RoleIdId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AppRoleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AppRoleId",
                table: "AspNetUsers",
                newName: "RoleIdId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_RoleIdId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleIdId",
                table: "AspNetUsers",
                column: "RoleIdId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }
    }
}
