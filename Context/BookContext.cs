using Microsoft.EntityFrameworkCore;
using ZeissRestWebServiceDemo.Models;

namespace ZeissRestWebServiceDemo.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
