﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualShop.Data;

#nullable disable

namespace VirtualShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppRoleAppUser", b =>
                {
                    b.Property<string>("RolesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AppRoleAppUser");
                });

            modelBuilder.Entity("VirtualShop.Models.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AppRole");
                });

            modelBuilder.Entity("VirtualShop.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncryptedPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("VirtualShop.Models.Cart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique()
                        .HasFilter("[AppUserId] IS NOT NULL");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("VirtualShop.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("VirtualShop.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BrandId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("WishlistId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CartId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WishlistId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("VirtualShop.Models.ProductImage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("VirtualShop.Models.ProductViewModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductViewModel");
                });

            modelBuilder.Entity("VirtualShop.Models.Wishlist", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DbEntryTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Whishlists");
                });

            modelBuilder.Entity("AppRoleAppUser", b =>
                {
                    b.HasOne("VirtualShop.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtualShop.Models.Cart", b =>
                {
                    b.HasOne("VirtualShop.Models.AppUser", "AppUser")
                        .WithOne("Cart")
                        .HasForeignKey("VirtualShop.Models.Cart", "AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("VirtualShop.Models.Category", b =>
                {
                    b.HasOne("VirtualShop.Models.Category", "Parent")
                        .WithMany("Categories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("VirtualShop.Models.Product", b =>
                {
                    b.HasOne("VirtualShop.Models.Category", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("VirtualShop.Models.Cart", null)
                        .WithMany("Products")
                        .HasForeignKey("CartId");

                    b.HasOne("VirtualShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("VirtualShop.Models.Wishlist", null)
                        .WithMany("Products")
                        .HasForeignKey("WishlistId");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VirtualShop.Models.ProductImage", b =>
                {
                    b.HasOne("VirtualShop.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("VirtualShop.Models.Wishlist", b =>
                {
                    b.HasOne("VirtualShop.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("VirtualShop.Models.AppUser", b =>
                {
                    b.Navigation("Cart");
                });

            modelBuilder.Entity("VirtualShop.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("VirtualShop.Models.Category", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VirtualShop.Models.Product", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("VirtualShop.Models.Wishlist", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
