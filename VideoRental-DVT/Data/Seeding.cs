using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using VideoRental_DVT.Models;

namespace VideoRental_DVT.Data
{
    public static class Seeding
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Video>()
                   .HasData(new Video
                   {
                       VideoId = 1,
                       VideoName = "jumanji",
                       Director = "Bob",
                       Price = 22,
                       Rented = true,
                       RentId = 1,
                       ReturnDate = new DateTime(2022, 1, 18),
                   },
                   new Video
                   {
                       VideoId = 2,
                       VideoName = "WalkingDead",
                       Director = "David",
                       Price = 12,
                       Rented = true,
                       RentId = 2,
                       ReturnDate = new DateTime(2021, 6, 28)
                   },
                   new Video
                   {
                       VideoId = 3,
                       VideoName = "Goodplace",
                       Director = "David",
                       Price = 15,
                       Rented = true,
                       RentId = 3,
                       ReturnDate = new DateTime(2022, 2, 22)
                   },
                   new Video
                   {
                       VideoId = 4,
                       VideoName = "HappyGilmore",
                       Director = "Bob Holand",
                       Price = 5,
                       Rented = true,
                       RentId = 4,
                       ReturnDate = new DateTime(2021, 1, 31)
                   },
                   new Video
                   {
                       VideoId = 5,
                       VideoName = "White chicks",
                       Director = "Keenen Ivory Wayans",
                       Price = 9.99,
                       Rented = true,
                       RentId = 5,
                       ReturnDate = new DateTime(2021, 7, 12) + TimeSpan.FromDays(28),
                   },
                   new Video
                   {
                       VideoId = 6,
                       VideoName = "War dogs",
                       Director = "Todd Phillips",
                       Price = 8,
                       Rented = true,
                       RentId = 6,
                       ReturnDate = new DateTime(2021, 9, 9)
                   },
                   new Video
                   {
                       VideoId = 7,
                       VideoName = "8 Mile",
                       Director = "Curtis Hanson",
                       Price = 13.49 ,
                       Rented = false,
                   },
                   new Video
                   {
                       VideoId = 8,
                       VideoName = "Superbad",
                       Director = "Greg Mottola",
                       Price = 9.80,
                       Rented = false,
                   },
                   new Video
                   {
                       VideoId = 9,
                       VideoName = "21",
                       Director = "Robert Luketic",
                       Price = 12.10,
                       Rented = true,
                       RentId = 7,
                       ReturnDate = new DateTime(2022,1,18)
                   },
                   new Video
                   {
                       VideoId = 10,
                       VideoName = "21 Jumpstreet",
                       Director = "Phil Lord",
                       Price = 14.50,
                       Rented = false,
                   }, 
                   new Video
                   {
                       VideoId = 11,
                       VideoName = "Up In Smoke",
                       Director = "Lou Adler",
                       Price = 20,
                       Rented = true,
                       RentId = 8,

                   },
                   new Video
                   {
                       VideoId = 12,
                       VideoName = "A Very Harold & Kumar Christmas",
                       Director = "Todd Strauss-Schulson",
                       Price = 8,
                       Rented = true,
                       RentId = 9,
                   },
                   new Video
                   {
                       VideoId = 13,
                       VideoName = "The wolf of wallstreet",
                       Director = "Martin Scorsese",
                       Price = 8,
                       Rented = false,
                   });
            modelbuilder.Entity<Customer>()
                .HasData(new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Dirk",
                    Age = 33,
                    RentIds = new List<int> { 1, 3, 5 }
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Jeff",
                    Age = 25,
                    RentIds = new List<int> { 2}
                },
                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Shara",
                    Age = 18,
                    RentIds = new List<int> {  6,9 }
                },
                new Customer
                {
                    CustomerId = 4,
                    CustomerName = "Amber",
                    Age = 21,
                    RentIds = new List<int> { 7,8 }
                }
                );


        }
    }
}
