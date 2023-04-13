using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommBlazor1.Server.Migrations
{
    public partial class BookSeedsAndUserAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 10, 1, "The king James holy bible in beautiful bound leather.", true, "https://tvaraj.files.wordpress.com/2012/10/the-holy-bible.jpg", "King James Bible" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 11, 1, "A book you should read if you want to understand the global psychosis we're currently living through by Paul Levy", false, "https://cdn2.penguin.com.au/covers/original/9781583945483.jpg", "Dispelling Wetiko" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 12, 1, "Meditations by Marcus Aurelius", false, "https://i.thenile.io/r1000/9781543286700.jpg?r=5f83a98257416", "Meditations" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 10, 2, 0m, 29.99m },
                    { 10, 3, 0m, 19.99m },
                    { 11, 2, 0m, 19.99m },
                    { 11, 3, 0m, 19.99m },
                    { 12, 2, 0m, 17.99m },
                    { 12, 3, 0m, 12.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
