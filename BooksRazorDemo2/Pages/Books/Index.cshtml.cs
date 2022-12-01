using BooksRazorDemo2.Data.Acces;
using BooksRazorDemo2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksRazorDemo2.Pages.Books
{
    public class IndexModel : PageModel
    {
        public AppDbContext Db { get; set; }
        public IEnumerable<Book>? Books { get; set; }

        public IndexModel(AppDbContext db)
        {
            Db = db;
        }
        public void OnGet()
        {
            Books = Db.Books;
        }
    }
}
