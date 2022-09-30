using LibraryBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication2.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public Book? Book { get; set; }
     

        [Display(Name = "File")]
        public IFormFile? FormFile { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Book != null)
                {
                    ILibrary library = new Library();
                    library.AddItem(Book);
                    ViewData["Message"] = "Item with title" +Book.Title + "and author "+Book.Author+" has been successfully.";
                }
            }
        }
    }
}
