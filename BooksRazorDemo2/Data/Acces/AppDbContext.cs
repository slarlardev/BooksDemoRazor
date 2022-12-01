using BooksRazorDemo2.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BooksRazorDemo2.Data.Acces
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>  options)
            : base(options)
        {

        }

        public DbSet<Book>? Books { get; set; }
    }
}
