using LibraryBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class AddEBookcshtmlModel : PageModel
    {
        [BindProperty]
        public EBook? EBook { get; set; }


        [Display(Name = "File")]
        public IFormFile? FormFile { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (EBook != null)
                {
                    ILibrary library = new Library();
                    library.AddItem(EBook);
                    ViewData["Message"] = "Item with title" + EBook.Title + "and author " + EBook.Author + " has been successfully.";
                }
            }
        }

    }
}
