using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class OverrideKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1c36d74-8a34-43f5-bc4d-64c0c677df11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4fd5beb-19a6-4222-b1a2-25048a2f5d23");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ffda4b5-1ed6-4068-a00b-aff70a0e6bf2", null, "Administrator", "ADMINISTRATOR" },
                    { "a9644260-6665-4f6d-a2a2-50bd7a383340", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b1c36d74-8a34-43f5-bc4d-64c0c677df11", null, "Administrator", "ADMINISTRATOR" },
                    { "b4fd5beb-19a6-4222-b1a2-25048a2f5d23", null, "User", "USER" }
                });
        }
    }
}
