using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
    public interface ILibrary
    {
        public List<Item> GetBooks();
        public bool AddItem(Item newItem);
        public bool AlterItem(Item item);
        public bool RemoveItem(Item item);

        public bool AddReview(Item item, Review review);
        public bool AlterReview(Review review);
        public bool DeleteReview(Review review);

        public bool AddUser(Person person);
        public bool EditUser(Person person);
        public bool DeleteUser(Person person);
        public List<Person> GetAllUsers();
        public Person Login(string username, string password);
    }
}
