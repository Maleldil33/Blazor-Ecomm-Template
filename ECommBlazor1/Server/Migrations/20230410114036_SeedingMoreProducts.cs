using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommBlazor1.Server.Migrations
{
    public partial class SeedingMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[] { 5, 1, 0m, 19.99m });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[] { 6, 1, 0m, 29.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 1 });
        }
    }
}
