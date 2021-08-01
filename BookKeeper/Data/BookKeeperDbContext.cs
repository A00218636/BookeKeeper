using System;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Data
{
    public class BookKeeperDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
     

        public BookKeeperDbContext(DbContextOptions<BookKeeperDbContext> options)
           : base(options)
        {

        }
    }
}
