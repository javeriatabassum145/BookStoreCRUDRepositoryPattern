using Microsoft.EntityFrameworkCore;
using CRUDRepositoryPattern.Models;

namespace CRUDRepositoryPattern.DAL
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
        : base(options)
        { }

        public DbSet<Book> Books
        {
            get;set;
        }
    }
}
