using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommBlazor1.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Books", "books" },
                    { 2, "Drinks", "drinks" },
                    { 3, "Video-Games", "games" },
                    { 4, "Clothing", "clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The first two books of 'the book of the new sun' by renowned sci-fi author Gene Wolfe", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1600272802l/55077689.jpg", 9.99m, "Shadow & Claw" },
                    { 2, 1, "C.S. Lewis's signature collection featuring a wide array of his fictional and Christian apolegetic works", "https://images.thenile.io/r1000/9780007500192.jpg", 19.99m, "C.S. Lewis - The Signature Collection" },
                    { 3, 2, "A tasty beverage championed by athletes and programmers alike", "https://www.restockit.com/images/product/xlarge/RDBRBD99124.jpg", 1.99m, "Red Bull" },
                    { 4, 3, "Classic game for the Nintendo Gamecube", "https://cdn.mobygames.com/covers/6555565-metroid-prime-gamecube-front-cover.jpg", 59.99m, "Metroid Prime" },
                    { 5, 3, "Building/Survival game available for many platforms", "https://cdn.mobygames.com/covers/3364463-minecraft-nintendo-switch-front-cover.jpg", 9.99m, "Minecraft" },
                    { 6, 4, "This hat is guaranteed to boost your confidence", "https://stores.wholesalecentral.com/Images/NMJ6J950PK_892KUVGLGLO_CQQQWUF/5297112446201.jpg", 19.99m, "Cool Hat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
