using BookService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Data
{
    public class BookServiceContext : DbContext
    {
        public BookServiceContext(DbContextOptions<BookServiceContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher(1, "IT-Publishers", "UK"),
                new Publisher(2, "FoodBooks", "Sweden")
                );

            modelBuilder.Entity<Author>().HasData(
                new Author(1, "James", "Sharp", new DateTime(1980, 5, 20)),
                new Author(2, "Sophie", "Netty", new DateTime(1992, 3, 4)),
                new Author(3, "Elisa", "Yammy", new DateTime(1996, 8, 12))
                );

            modelBuilder.Entity<Book>().HasData(
                new
                {
                    Id = 1,
                    ISBN = "123456789",
                    Title = "Learning C#",
                    NumberOfPages = 420,
                    FileName = "book1.jpg",
                    AuthorId = 1,
                    PublisherId = 1
                },
                new
                {
                    Id = 2,
                    ISBN = "45689132",
                    Title = "Mastering Linq",
                    NumberOfPages = 360,
                    FileName = "book2.jpg",
                    AuthorId = 2,
                    PublisherId = 1
                },
                new
                {
                    Id = 3,
                    ISBN = "15856135",
                    Title = "Mastering Xamarin",
                    NumberOfPages = 360,
                    FileName = "book3.jpg",
                    AuthorId = 1,
                    PublisherId = 1
                },
                new
                {
                    Id = 4,
                    ISBN = "56789564",
                    Title = "Exploring ASP.Net Core 2.0",
                    NumberOfPages = 360,
                    FileName = "book1.jpg",
                    AuthorId = 2,
                    PublisherId = 1
                },
                new
                {
                    Id = 5,
                    ISBN = "234546684",
                    Title = "Unity Game Development",
                    NumberOfPages = 420,
                    FileName = "book2.jpg",
                    AuthorId = 2,
                    PublisherId = 1
                },
                new
                {
                    Id = 6,
                    ISBN = "789456258",
                    Title = "Cooking is fun",
                    NumberOfPages = 40,
                    FileName = "book3.jpg",
                    AuthorId = 3,
                    PublisherId = 2
                },
                new
                {
                    Id = 7,
                    ISBN = "94521546",
                    Title = "Secret recipes",
                    NumberOfPages = 53,
                    FileName = "book3.jpg",
                    AuthorId = 3,
                    PublisherId = 2
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
