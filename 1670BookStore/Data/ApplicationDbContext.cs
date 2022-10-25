using _1670BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1670BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreOwner> StoreOwner { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            PopulateCategory(builder);
            SeedBook(builder);
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    BookId = "B01",
                    BookTitle = "The frog is coming",
                    BookQuantity = 12,
                    BookPrice = 6.5,
                    BookAuthor = "William",
                    BookImage = "https://i.pinimg.com/originals/5f/e7/84/5fe784a563c1b5385fda215faa0edc27.jpg",
                    BookDescription = "Th frog is coming, all people worry about it.",
                    CategoryId = 1
                }
                );
        }

        private void PopulateCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CatId = "CAT1",
                    CatName = "Kids",
                    CatDescription = "This book type will talk about the thing around kid"
                }
                );
        }
    }
}
