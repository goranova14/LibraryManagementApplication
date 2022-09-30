using LibraryBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Person Person { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Person != null)
                {
                    ILibrary library = new Library();
                    library.AddUser(Person);
                    ViewData["Message"] = "User with username" + Person.Username + " has been successfully.";
                }
                else
                {
                    ViewData["Message"] = "User was not created, try again.";
                }
            }
        }
    }
}
