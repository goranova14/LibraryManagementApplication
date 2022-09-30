using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibraryBusiness;

namespace WebApplication2.Pages
{
    public class BooksModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ItemManager ItemManager { get; set; }
        public List<Item> Book { get; set; }
       
        public void OnGet()
        {
            ItemManager=new ItemManager();
            Book = ItemManager.GetBooks();
        }
    }
}
