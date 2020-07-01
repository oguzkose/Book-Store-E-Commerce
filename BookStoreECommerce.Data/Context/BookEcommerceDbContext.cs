using BookStoreECommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreECommerce.Data.Context
{
    public class BookEcommerceDbContext:DbContext
    {
        public BookEcommerceDbContext(DbContextOptions<BookEcommerceDbContext> options):base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
    }
}
