using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdatatoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "_id", "address", "employeeCount", "name" },
                values: new object[,]
                {
                    { "3d490a70-94ce-4d15-9494-5248280c2ce3", "Some place mysterious place near the outer galaxy", 123456, "Radio Shack" },
                    { "c9d4c053-49b6-410c-bc78-2d54a9991870", "Some place near neptune", 1451, "SamDev Solutions" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "_id",
                keyValue: "3d490a70-94ce-4d15-9494-5248280c2ce3");

            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "_id",
                keyValue: "c9d4c053-49b6-410c-bc78-2d54a9991870");
        }
    }
}
