using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        DbSet<Book> Books { get; set; }
    }
}