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
    [Migration("20221017194307_AddingAsset1Table")]
    partial class AddingAsset1Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASSETTRACKING.Asset1", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Assets1");
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
                            Id = 1,
                            brand = "hp",
                            catagory = "Computer",
                            currency = "$",
                            exchangeRate = 50.0,
                            model = "2018",
                            office = "USA",
                            purchaseDate = 1997,
                            purchasePrice = 50.0
                        },
                        new
                        {
                            Id = 2,
                            brand = "hp",
                            catagory = "Computer",
                            currency = "$",
                            exchangeRate = 50.0,
                            model = "2018",
                            office = "USA",
                            purchaseDate = 1997,
                            purchasePrice = 50.0
                        },
                        new
                        {
                            Id = 3,
                            brand = "Asus",
                            catagory = "Computer",
                            currency = "$",
                            exchangeRate = 10.0,
                            model = "W234",
                            office = "USA",
                            purchaseDate = 1993,
                            purchasePrice = 1250.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}