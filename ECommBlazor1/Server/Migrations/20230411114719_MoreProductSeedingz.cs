using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommBlazor1.Server.Migrations
{
    public partial class MoreProductSeedingz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 7, 3, "Survival/social simulation game for the nintendo Gamecube", false, "https://cdn.mobygames.com/covers/5216426-animal-crossing-gamecube-front-cover.jpg", "Animal Crossing" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 8, 1, "Prophetic sci-fi novel by C.S. Lewis. This is the final volume of the space trilogy.", false, "https://i.pinimg.com/originals/0b/5d/db/0b5ddb6157152090875ab9d181cb51ae.jpg", "That Hideous Strength" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 9, 1, "Educational literature for teaching programmers about design patterns often encountered in object oriented programming.", false, "https://i1.wp.com/springframework.guru/wp-content/uploads/2015/04/9780201633610.jpg?resize=520%2C648", "Design Patterns for Programmers" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 7, 6, 0m, 29.99m },
                    { 8, 6, 0m, 29.99m },
                    { 9, 2, 0m, 29.99m },
                    { 9, 3, 0m, 29.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
