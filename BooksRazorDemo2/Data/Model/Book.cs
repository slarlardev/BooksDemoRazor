using System.ComponentModel.DataAnnotations;

namespace BooksRazorDemo2.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; }
        
        [Required]
        [Range(2000, 2022,ErrorMessage ="2000-2022 arası deger giriniz" )]
        [Display(Name = "Yayınlanma Tarihi")]
        public int PublishedYear { get; set; }
    }
}
