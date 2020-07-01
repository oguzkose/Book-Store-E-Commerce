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

    }
}
