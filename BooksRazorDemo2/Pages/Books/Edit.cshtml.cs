using BooksRazorDemo2.Data.Acces;
using BooksRazorDemo2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksRazorDemo2.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Book? Book { get; set; }

        private AppDbContext _db;
        public EditModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Book = _db.Books.Find(id);
            //Book = _db.Books.FirstOrDefault(b => b.Id == id);
            //Book = _db.Books.SingleOrDefault(b => b.Id == id);
            //Book = _db.Books.Where(b => b.Id == id).FirstOrDefault();
        }

        public IActionResult OnPost()
        {
            // Veritabaný EF
            _db.Books.Update(Book);
            _db.SaveChanges();
            return RedirectToPage("Index") ;

        }
    }
}
