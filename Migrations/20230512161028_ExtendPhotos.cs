using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExtendPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3668d59c-2eb1-4783-85c0-f59c094cf2d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9393c059-98a4-4de7-88cf-24f8cdab925d");

            migrationBuilder.AddColumn<byte[]>(
                name: "UserPhotoByte",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a60b0380-1cd6-43ee-897a-bf5570116276", null, "User", "USER" },
                    { "aa26c8e4-fc15-43fb-ae86-02029bfbedeb", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a60b0380-1cd6-43ee-897a-bf5570116276");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa26c8e4-fc15-43fb-ae86-02029bfbedeb");

            migrationBuilder.DropColumn(
                name: "UserPhotoByte",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3668d59c-2eb1-4783-85c0-f59c094cf2d0", null, "User", "USER" },
                    { "9393c059-98a4-4de7-88cf-24f8cdab925d", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
