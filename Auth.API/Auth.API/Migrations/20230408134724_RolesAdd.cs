using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Auth.API.Migrations
{
    /// <inheritdoc />
    public partial class RolesAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a94e595-a3e9-4dee-9a3b-aa91a3c91510", "4bacf1ec-7ab0-41c9-b5d6-8c9113eec24e", "Viewer", "VIEWER" },
                    { "1ee0f6ae-407d-4744-9fbf-180b42fd7417", "94be0029-5bbb-4597-ae28-c1769648c646", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a94e595-a3e9-4dee-9a3b-aa91a3c91510");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee0f6ae-407d-4744-9fbf-180b42fd7417");
        }
    }
}
