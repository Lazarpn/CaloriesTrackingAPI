using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriesTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e0c05ea-9316-45cb-abe9-758df536c7e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d73be761-237b-482b-a529-bde93246468f");

            migrationBuilder.AddColumn<byte[]>(
                name: "UserPhoto",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "526ed3e4-afa3-4eed-a243-00d7da96fe2c", null, "User", "USER" },
                    { "869b6ee1-9f3f-4614-885f-d423d2ebbfc3", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "526ed3e4-afa3-4eed-a243-00d7da96fe2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869b6ee1-9f3f-4614-885f-d423d2ebbfc3");

            migrationBuilder.DropColumn(
                name: "UserPhoto",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e0c05ea-9316-45cb-abe9-758df536c7e7", null, "User", "USER" },
                    { "d73be761-237b-482b-a529-bde93246468f", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
