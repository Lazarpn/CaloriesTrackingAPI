using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemovingKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ffda4b5-1ed6-4068-a00b-aff70a0e6bf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9644260-6665-4f6d-a2a2-50bd7a383340");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d713ffb-ec20-4441-839e-9549a47d0ca2", null, "Administrator", "ADMINISTRATOR" },
                    { "533530a6-25a3-47df-8757-ef01463eaa30", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d713ffb-ec20-4441-839e-9549a47d0ca2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "533530a6-25a3-47df-8757-ef01463eaa30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ffda4b5-1ed6-4068-a00b-aff70a0e6bf2", null, "Administrator", "ADMINISTRATOR" },
                    { "a9644260-6665-4f6d-a2a2-50bd7a383340", null, "User", "USER" }
                });
        }
    }
}
