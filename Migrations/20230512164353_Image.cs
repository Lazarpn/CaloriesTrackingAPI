using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "589fcbca-347a-478d-9122-f6174db149ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "707dce37-2bf0-411b-b8ca-7735961ecf77");

            migrationBuilder.DropColumn(
                name: "UserPhoto",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91eda14d-ec47-4361-a4ce-7066453ebd0f", null, "User", "USER" },
                    { "cebaf3c6-5f7a-430e-b96d-e470d0dd6e34", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91eda14d-ec47-4361-a4ce-7066453ebd0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cebaf3c6-5f7a-430e-b96d-e470d0dd6e34");

            migrationBuilder.AddColumn<string>(
                name: "UserPhoto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "589fcbca-347a-478d-9122-f6174db149ad", null, "Administrator", "ADMINISTRATOR" },
                    { "707dce37-2bf0-411b-b8ca-7735961ecf77", null, "User", "USER" }
                });
        }
    }
}
