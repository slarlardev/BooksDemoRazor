using BooksRazorDemo2.Data.Acces;
using BooksRazorDemo2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksRazorDemo2.Pages.Books
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book>? Books { get; set; }

        private AppDbContext _db { get; set; }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Books = _db.Books;
        }
    }
}
