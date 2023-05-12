using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class NullablePhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a60b0380-1cd6-43ee-897a-bf5570116276");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa26c8e4-fc15-43fb-ae86-02029bfbedeb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "589fcbca-347a-478d-9122-f6174db149ad", null, "Administrator", "ADMINISTRATOR" },
                    { "707dce37-2bf0-411b-b8ca-7735961ecf77", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "589fcbca-347a-478d-9122-f6174db149ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "707dce37-2bf0-411b-b8ca-7735961ecf77");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a60b0380-1cd6-43ee-897a-bf5570116276", null, "User", "USER" },
                    { "aa26c8e4-fc15-43fb-ae86-02029bfbedeb", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
