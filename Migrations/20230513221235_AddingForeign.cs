using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingForeign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32a5e7e8-f5ef-448f-bcb1-f38fad9f692d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc75f20-7095-4476-bab5-8f372746bb29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f80e88f-2081-4cd4-9092-4cbf977fcf87", null, "Administrator", "ADMINISTRATOR" },
                    { "6e5a4a76-f817-4bcc-9078-c0a0025e1db4", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f80e88f-2081-4cd4-9092-4cbf977fcf87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e5a4a76-f817-4bcc-9078-c0a0025e1db4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32a5e7e8-f5ef-448f-bcb1-f38fad9f692d", null, "User", "USER" },
                    { "6cc75f20-7095-4476-bab5-8f372746bb29", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
