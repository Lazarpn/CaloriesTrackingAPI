using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemovingMeals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d713ffb-ec20-4441-839e-9549a47d0ca2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "533530a6-25a3-47df-8757-ef01463eaa30");

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32a5e7e8-f5ef-448f-bcb1-f38fad9f692d", null, "User", "USER" },
                    { "6cc75f20-7095-4476-bab5-8f372746bb29", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1d713ffb-ec20-4441-839e-9549a47d0ca2", null, "Administrator", "ADMINISTRATOR" },
                    { "533530a6-25a3-47df-8757-ef01463eaa30", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calories", "Date", "MealsUserId", "Name", "Time" },
                values: new object[,]
                {
                    { 1, 150, "bas", "1970b77a-defb-4710-a942-8062345d4a34", "Jamaica", "bla" },
                    { 2, 150, "bas", "1970b77a-defb-4710-a942-8062345d4a34", "Jamaica", "bla" },
                    { 3, 150, "bas", "1970b77a-defb-4710-a942-8062345d4a34", "Jamaica", "bla" },
                    { 4, 150, "bas", "61226191-d59e-42fd-ac75-c8c66dc4f2b9", "Jamaica", "bla" },
                    { 5, 150, "bas", "61226191-d59e-42fd-ac75-c8c66dc4f2b9", "Jamaica", "bla" },
                    { 6, 150, "bas", "61226191-d59e-42fd-ac75-c8c66dc4f2b9", "Jamaica", "bla" },
                    { 7, 150, "bas", "61226191-d59e-42fd-ac75-c8c66dc4f2b9", "Jamaica", "bla" }
                });
        }
    }
}
