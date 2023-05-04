using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class MealsConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4de2a49a-4e55-45f8-84e6-a9fe8f528a1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb4d6e53-e2ba-4a0e-a380-aa206af1e9aa");

            migrationBuilder.AddColumn<string>(
                name: "MealsUserId",
                table: "Meals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21fa5b8d-08ab-4c92-ac94-7769d1cf2d89", null, "Administrator", "ADMINISTRATOR" },
                    { "b7023391-4213-44c8-9894-eaa5999d9c50", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "MealsUserId",
                value: "1970b77a-defb-4710-a942-8062345d4a34");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "MealsUserId",
                value: "1970b77a-defb-4710-a942-8062345d4a34");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "MealsUserId",
                value: "1970b77a-defb-4710-a942-8062345d4a34");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4,
                column: "MealsUserId",
                value: "61226191-d59e-42fd-ac75-c8c66dc4f2b9");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5,
                column: "MealsUserId",
                value: "61226191-d59e-42fd-ac75-c8c66dc4f2b9");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "MealsUserId",
                value: "61226191-d59e-42fd-ac75-c8c66dc4f2b9");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "MealsUserId",
                value: "61226191-d59e-42fd-ac75-c8c66dc4f2b9");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealsUserId",
                table: "Meals",
                column: "MealsUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_AspNetUsers_MealsUserId",
                table: "Meals",
                column: "MealsUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_AspNetUsers_MealsUserId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_MealsUserId",
                table: "Meals");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21fa5b8d-08ab-4c92-ac94-7769d1cf2d89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7023391-4213-44c8-9894-eaa5999d9c50");

            migrationBuilder.DropColumn(
                name: "MealsUserId",
                table: "Meals");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4de2a49a-4e55-45f8-84e6-a9fe8f528a1e", null, "User", "USER" },
                    { "cb4d6e53-e2ba-4a0e-a380-aa206af1e9aa", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
