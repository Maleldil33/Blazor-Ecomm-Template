namespace ECommBlazor1.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Default" },
                new ProductType { Id = 2, Name = "Paperback" },
                new ProductType { Id = 3, Name = "E-Book" },
                new ProductType { Id = 4, Name = "Audiobook" },
                new ProductType { Id = 5, Name = "Nintendo Gamecube" },
                new ProductType { Id = 6, Name = "Playstation 1" },
                new ProductType { Id = 7, Name = "250ml" },
                new ProductType { Id = 8, Name = "500ml" }

            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Drinks",
                    Url = "drinks"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video-Games",
                    Url = "games"
                },
                new Category
                {
                    Id = 4,
                    Name = "Clothing",
                    Url = "clothing"
                }
                );

                modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Shadow & Claw",
                     Description = "The first two books of 'the book of the new sun' by renowned sci-fi author Gene Wolfe",
                     ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1600272802l/55077689.jpg",
                     CategoryId = 1
                 },
                new Product
                {
                    Id = 2,
                    Title = "C.S. Lewis - The Signature Collection",
                    Description = "C.S. Lewis's signature collection featuring a wide array of his fictional and Christian apolegetic works",
                    ImageUrl = "https://images.thenile.io/r1000/9780007500192.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Red Bull",
                    Description = "A tasty beverage championed by athletes and programmers alike",
                    ImageUrl = "https://www.restockit.com/images/product/xlarge/RDBRBD99124.jpg",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = 4,
                    Title = "Metroid Prime",
                    Description = "Classic game for the Nintendo Gamecube",
                    ImageUrl = "https://cdn.mobygames.com/covers/6555565-metroid-prime-gamecube-front-cover.jpg",
                    CategoryId = 3,
                    Featured = true
                },
                new Product
                {
                    Id = 5,
                    Title = "Minecraft",
                    Description = "Building/Survival game available for many platforms",
                    ImageUrl = "https://cdn.mobygames.com/covers/3364463-minecraft-nintendo-switch-front-cover.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Title = "Cool Hat",
                    Description = "This hat is guaranteed to boost your confidence",
                    ImageUrl = "https://stores.wholesalecentral.com/Images/NMJ6J950PK_892KUVGLGLO_CQQQWUF/5297112446201.jpg",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 7,
                    Title = "Animal Crossing",
                    Description = "Survival/social simulation game for the nintendo Gamecube",
                    ImageUrl = "https://cdn.mobygames.com/covers/5216426-animal-crossing-gamecube-front-cover.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 8,
                    Title = "That Hideous Strength",
                    Description = "Prophetic sci-fi novel by C.S. Lewis. This is the final volume of the space trilogy.",
                    ImageUrl = "https://i.pinimg.com/originals/0b/5d/db/0b5ddb6157152090875ab9d181cb51ae.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 9,
                    Title = "Design Patterns for Programmers",
                    Description = "Educational literature for teaching programmers about design patterns often encountered in object oriented programming.",
                    ImageUrl = "https://i1.wp.com/springframework.guru/wp-content/uploads/2015/04/9780201633610.jpg?resize=520%2C648",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 10,
                    Title = "King James Bible",
                    Description = "The king James holy bible in beautiful bound leather.",
                    ImageUrl = "https://tvaraj.files.wordpress.com/2012/10/the-holy-bible.jpg",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 11,
                    Title = "Dispelling Wetiko",
                    Description = "A book you should read if you want to understand the global psychosis we're currently living through by Paul Levy",
                    ImageUrl = "https://cdn2.penguin.com.au/covers/original/9781583945483.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 12,
                    Title = "Meditations",
                    Description = "Meditations by Marcus Aurelius",
                    ImageUrl = "https://i.thenile.io/r1000/9781543286700.jpg?r=5f83a98257416",
                    CategoryId = 1
                });;

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 7,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 8,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 1,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 1,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 6,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 6,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 2,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 3,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 2,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 3,
                    Price = 19.99m
                }
                ,
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 2,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 3,
                    Price = 19.99m
                }
                ,
                new ProductVariant
                {
                    ProductId = 12,
                    ProductTypeId = 2,
                    Price = 17.99m
                },
                new ProductVariant
                {
                    ProductId = 12,
                    ProductTypeId = 3,
                    Price = 12.99m
                }
                );

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
