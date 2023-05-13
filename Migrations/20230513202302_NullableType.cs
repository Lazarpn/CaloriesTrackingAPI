using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class NullableType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91eda14d-ec47-4361-a4ce-7066453ebd0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cebaf3c6-5f7a-430e-b96d-e470d0dd6e34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48842222-0b45-4a60-87ca-f7c95f7fe1b2", null, "Administrator", "ADMINISTRATOR" },
                    { "de557258-fecd-4c5f-b736-e9a94beed8be", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48842222-0b45-4a60-87ca-f7c95f7fe1b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de557258-fecd-4c5f-b736-e9a94beed8be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91eda14d-ec47-4361-a4ce-7066453ebd0f", null, "User", "USER" },
                    { "cebaf3c6-5f7a-430e-b96d-e470d0dd6e34", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
