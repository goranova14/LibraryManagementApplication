using LibraryBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel

    {
        [BindProperty]
        public Person Person { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            ILibrary library = new Library();

            if (library.Login(Person.Username, Person.Password) is Person p)
            {
               return Redirect("/HomepageA");
                
            }
            else
            {
                ViewData["MessageAlert"] = "Wrong password or username";
            }

            return null;
        }
    }
}