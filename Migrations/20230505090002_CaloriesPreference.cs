using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class CaloriesPreference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21fa5b8d-08ab-4c92-ac94-7769d1cf2d89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7023391-4213-44c8-9894-eaa5999d9c50");

            migrationBuilder.AddColumn<int>(
                name: "CaloriesPreference",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e0c05ea-9316-45cb-abe9-758df536c7e7", null, "User", "USER" },
                    { "d73be761-237b-482b-a529-bde93246468f", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e0c05ea-9316-45cb-abe9-758df536c7e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d73be761-237b-482b-a529-bde93246468f");

            migrationBuilder.DropColumn(
                name: "CaloriesPreference",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21fa5b8d-08ab-4c92-ac94-7769d1cf2d89", null, "Administrator", "ADMINISTRATOR" },
                    { "b7023391-4213-44c8-9894-eaa5999d9c50", null, "User", "USER" }
                });
        }
    }
}
