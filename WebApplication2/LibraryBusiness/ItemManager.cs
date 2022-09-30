using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryBusiness
{
    public class ItemManager
    {
        List<Item> items;
        public static ItemManager Instance { get; } = new ItemManager();
        public ItemManager()
        {
            items = new List<Item>();
            GetBooks();
        }
        public Item CreateNewBook(string title, string author, string publisher, string description, string genre, byte[] image, int pages)
        {
           
            Item newBook = new Book()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                Description = description,
                Genre = genre,
                Image = image,
                Pages = pages

            };
                DatabaseInstance.Instance.InsertNewItem(newBook);
            return newBook;
        }
        public Item CreateNewEBook(string title, string author, string publisher, string description, string genre, byte[] image, int DPI)
        {
            Item newBook = new EBook()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                Description = description,
                Genre = genre,
                Image = image,
                DPI = DPI

            };
            DatabaseInstance.Instance.InsertNewItem(newBook);
            return newBook;
        }
        public List<Item> GetBooks()
        {

            items= DatabaseInstance.Instance.GetBooks();
            return items;
        }
        public Item GetItemByID(int id)
        {
            return items[id - 1];
        }
      
    }
}
