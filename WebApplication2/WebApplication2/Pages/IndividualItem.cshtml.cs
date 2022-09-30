using LibraryBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndividualItemModel : PageModel
    {
        public ItemManager ItemManager { get; set; }
        public Item Item { get; set; }
        public void OnGet(int id)
        {
            ItemManager = new ItemManager();
            Item = ItemManager.GetItemByID(id);
        }
    }
}
