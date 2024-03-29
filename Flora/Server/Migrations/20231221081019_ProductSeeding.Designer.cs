﻿// <auto-generated />
using Flora.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Flora.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231221081019_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Flora.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bursting with Christmas spirit, this lush rose bouquet is accented with candy canes and pine cones for a touch of festive fun.Red roses, white snapdragons, and white cushion spray chrysanthemums are wrapped in a variegated aspidistra leaf and accented with seeded eucalyptus, lemon leaf, flat cedar, white pine, candy canes, and small frosted pinecones. Delivered in a clear glass cylinder vase.",
                            ImageURL = "https://assets.eflorist.com/assets/products/PZM_/TWR14-4A.jpg?impolicy=hero&impolicy=hero",
                            Price = 9.99m,
                            Title = "Festive Pines Bouquet"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Free their spirits with this fabulous array of pink flowers in a chic glass cylinder vase. As breezy and fun as a classic Gene Kelly movie, it will brighten their entire week.The lush bouquet includes dark pink hydrangea, pink roses and pink carnations accented with red ti leaves.",
                            ImageURL = "https://assets.eflorist.com/assets/products/PZM_/T553-1A.jpg?impolicy=hero&impolicy=hero",
                            Price = 7.99m,
                            Title = "On The Town"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Show impeccable taste when you send this stylish bouquet of hot pink roses, pale pink lilies and mixed blossoms, arranged in a modern glass cube vase. Pretty, posh and perfectly high-class!Hot pink roses and Matsumoto asters, pink LA hybrid lilies and burgundy stock arrive in a clear glass Teleflora cube vase lined with variegated ti leaves.",
                            ImageURL = "https://assets.eflorist.com/assets/products/PZM_/T05N100A.jpg?impolicy=hero&impolicy=hero   ",
                            Price = 8.99m,
                            Title = "Posh Pinks"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
