namespace ECommBlazor1.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
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

                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        Email = "Tim.hedin@gmail.com",
                        PasswordHash = null,
                        PasswordSalt = null
                    },

                modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Shadow & Claw",
                     Description = "The first two books of 'the book of the new sun' by renowned sci-fi author Gene Wolfe",                     
                     ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1600272802l/55077689.jpg",
                     Price = 9.99m,
                     CategoryId = 1
                 },
                new Product
                {
                    Id = 2,
                    Title = "C.S. Lewis - The Signature Collection",
                    Description = "C.S. Lewis's signature collection featuring a wide array of his fictional and Christian apolegetic works",                    
                    ImageUrl = "https://images.thenile.io/r1000/9780007500192.jpg",
                    Price = 19.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Red Bull",
                    Description = "A tasty beverage championed by athletes and programmers alike",                    
                    ImageUrl = "https://www.restockit.com/images/product/xlarge/RDBRBD99124.jpg",
                    Price = 1.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "Metroid Prime",
                    Description = "Classic game for the Nintendo Gamecube",                    
                    ImageUrl = "https://cdn.mobygames.com/covers/6555565-metroid-prime-gamecube-front-cover.jpg",
                    Price = 59.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 5,
                    Title = "Minecraft",
                    Description = "Building/Survival game available for many platforms",
                    ImageUrl = "https://cdn.mobygames.com/covers/3364463-minecraft-nintendo-switch-front-cover.jpg",
                    Price = 9.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Title = "Cool Hat",
                    Description = "This hat is guaranteed to boost your confidence",
                    ImageUrl = "https://stores.wholesalecentral.com/Images/NMJ6J950PK_892KUVGLGLO_CQQQWUF/5297112446201.jpg",
                    Price = 19.99m,
                    CategoryId = 4
                }
                ));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
