using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class StringPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "526ed3e4-afa3-4eed-a243-00d7da96fe2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869b6ee1-9f3f-4614-885f-d423d2ebbfc3");

            migrationBuilder.AlterColumn<string>(
                name: "UserPhoto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3668d59c-2eb1-4783-85c0-f59c094cf2d0", null, "User", "USER" },
                    { "9393c059-98a4-4de7-88cf-24f8cdab925d", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3668d59c-2eb1-4783-85c0-f59c094cf2d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9393c059-98a4-4de7-88cf-24f8cdab925d");

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserPhoto",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "526ed3e4-afa3-4eed-a243-00d7da96fe2c", null, "User", "USER" },
                    { "869b6ee1-9f3f-4614-885f-d423d2ebbfc3", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
