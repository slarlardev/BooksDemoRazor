using BooksRazorDemo2.Data.Acces;
using BooksRazorDemo2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksRazorDemo2.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }

        private AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Veritabaný insert
                _db.Books.Add(Book);
                _db.SaveChanges();

                TempData["basariliKayitGiris"] = "Kitap kayýt giriþi yapýldý";

                return RedirectToPage("index");
            }

            return Page();

        }

    }
}
