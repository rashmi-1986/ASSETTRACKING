﻿// <auto-generated />
using ASSETTRACKING;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASSETTRACKING.Migrations
{
    [DbContext(typeof(myDbcontext1))]
    [Migration("20221018041304_Item")]
    partial class Item
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASSETTRACKING.Asset", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            id = 2,
                            name = "Company"
                        });
                });

            modelBuilder.Entity("ASSETTRACKING.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("catagory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("exchangeRate")
                        .HasColumnType("float");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("purchaseDate")
                        .HasColumnType("int");

                    b.Property<double>("purchasePrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            brand = "apple",
                            catagory = "Phone",
                            currency = "EUR",
                            exchangeRate = 24.699999999999999,
                            model = "2022",
                            office = "Spain",
                            purchaseDate = 1995,
                            purchasePrice = 2470.0
                        },
                        new
                        {
                            Id = 1,
                            brand = "apple",
                            catagory = "Phone",
                            currency = "SEK",
                            exchangeRate = 54.700000000000003,
                            model = "2022",
                            office = "Sweden",
                            purchaseDate = 1995,
                            purchasePrice = 5470.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
