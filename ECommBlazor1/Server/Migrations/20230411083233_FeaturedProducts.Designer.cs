﻿// <auto-generated />
using System;
using ECommBlazor1.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommBlazor1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230411083233_FeaturedProducts")]
    partial class FeaturedProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommBlazor1.Shared.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drinks",
                            Url = "drinks"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video-Games",
                            Url = "games"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Clothing",
                            Url = "clothing"
                        });
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "The first two books of 'the book of the new sun' by renowned sci-fi author Gene Wolfe",
                            Featured = false,
                            ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1600272802l/55077689.jpg",
                            Title = "Shadow & Claw"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "C.S. Lewis's signature collection featuring a wide array of his fictional and Christian apolegetic works",
                            Featured = false,
                            ImageUrl = "https://images.thenile.io/r1000/9780007500192.jpg",
                            Title = "C.S. Lewis - The Signature Collection"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "A tasty beverage championed by athletes and programmers alike",
                            Featured = true,
                            ImageUrl = "https://www.restockit.com/images/product/xlarge/RDBRBD99124.jpg",
                            Title = "Red Bull"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Classic game for the Nintendo Gamecube",
                            Featured = true,
                            ImageUrl = "https://cdn.mobygames.com/covers/6555565-metroid-prime-gamecube-front-cover.jpg",
                            Title = "Metroid Prime"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Building/Survival game available for many platforms",
                            Featured = false,
                            ImageUrl = "https://cdn.mobygames.com/covers/3364463-minecraft-nintendo-switch-front-cover.jpg",
                            Title = "Minecraft"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Description = "This hat is guaranteed to boost your confidence",
                            Featured = false,
                            ImageUrl = "https://stores.wholesalecentral.com/Images/NMJ6J950PK_892KUVGLGLO_CQQQWUF/5297112446201.jpg",
                            Title = "Cool Hat"
                        });
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nintendo Gamecube"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Playstation 1"
                        },
                        new
                        {
                            Id = 7,
                            Name = "250ml"
                        },
                        new
                        {
                            Id = 8,
                            Name = "500ml"
                        });
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 7,
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 8,
                            OriginalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 1,
                            OriginalPrice = 0m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 1,
                            OriginalPrice = 0m,
                            Price = 29.99m
                        });
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.Product", b =>
                {
                    b.HasOne("ECommBlazor1.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.ProductVariant", b =>
                {
                    b.HasOne("ECommBlazor1.Shared.Models.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommBlazor1.Shared.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("ECommBlazor1.Shared.Models.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
