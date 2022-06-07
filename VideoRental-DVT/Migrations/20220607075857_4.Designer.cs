﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoRental_DVT.Data;

namespace VideoRental_DVT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220607075857_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VideoRental_DVT.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Age = 21,
                            CustomerName = "Dirk"
                        });
                });

            modelBuilder.Entity("VideoRental_DVT.Models.Video", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("RentId")
                        .HasColumnType("int");

                    b.Property<bool>("Rented")
                        .HasColumnType("bit");

                    b.Property<int?>("RentedToCustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VideoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoId");

                    b.HasIndex("RentedToCustomerId");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            VideoId = 1,
                            Director = "Bob",
                            Price = 22.0,
                            RentId = 1,
                            Rented = true,
                            ReturnDate = new DateTime(2022, 7, 5, 9, 58, 56, 940, DateTimeKind.Local).AddTicks(707),
                            VideoName = "jumanji"
                        },
                        new
                        {
                            VideoId = 2,
                            Director = "David",
                            Price = 22.0,
                            RentId = 2,
                            Rented = true,
                            ReturnDate = new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5276),
                            VideoName = "WalkingDead"
                        },
                        new
                        {
                            VideoId = 3,
                            Director = "David",
                            Price = 15.0,
                            RentId = 3,
                            Rented = true,
                            ReturnDate = new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5316),
                            VideoName = "Goodplace"
                        },
                        new
                        {
                            VideoId = 4,
                            Director = "Bob Holand",
                            Price = 5.0,
                            RentId = 4,
                            Rented = true,
                            ReturnDate = new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5321),
                            VideoName = "HappyGilmore"
                        },
                        new
                        {
                            VideoId = 5,
                            Director = "Keenen Ivory Wayans",
                            Price = 9.9900000000000002,
                            RentId = 5,
                            Rented = true,
                            ReturnDate = new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5324),
                            VideoName = "White chicks"
                        },
                        new
                        {
                            VideoId = 6,
                            Director = "Todd Phillips",
                            Price = 8.0,
                            RentId = 6,
                            Rented = true,
                            ReturnDate = new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5327),
                            VideoName = "War dogs"
                        },
                        new
                        {
                            VideoId = 7,
                            Director = "Todd Phillips",
                            Price = 13.49,
                            Rented = false,
                            VideoName = "War dogs"
                        },
                        new
                        {
                            VideoId = 8,
                            Director = "Greg Mottola",
                            Price = 8.0,
                            Rented = false,
                            VideoName = "Superbad"
                        });
                });

            modelBuilder.Entity("VideoRental_DVT.Models.Video", b =>
                {
                    b.HasOne("VideoRental_DVT.Models.Customer", "RentedTo")
                        .WithMany("RentedVideos")
                        .HasForeignKey("RentedToCustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
