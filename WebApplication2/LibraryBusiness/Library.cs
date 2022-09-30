namespace LibraryBusiness
{
    public class Library : ILibrary
    {
        public bool AddItem(Item newItem)
        {
            if (newItem == null) return false;
            if (newItem!=null && newItem is Book)
            {
             return ItemManager.Instance.CreateNewBook(newItem.Title, newItem.Author, newItem.Publisher, newItem.Description, newItem.Genre, null, ((Book)newItem).Pages) is null;

            }
            if (newItem != null && newItem is EBook)
            {
                return ItemManager.Instance.CreateNewBook(newItem.Title, newItem.Author, newItem.Publisher, newItem.Description, newItem.Genre, null, ((EBook)newItem).DPI) is null;

            }
            return true;
        }

        public bool AddReview(Item item, Review review)
        {
            throw new NotImplementedException();
        }

        public bool AddUser(Person person)
        {
            return PersonManager.Instance.CreateNewPerson(person.Username,person.Password,person.Name,person.SurName,person.Address, new Role() { ID =new Guid( "5eb66051-fb47-4a9a-adba-e3a56bdb8f18" )}) is null;//regular user ID
        }

        public bool AlterItem(Item item)
        {
            throw new NotImplementedException();
        }

        public bool AlterReview(Review review)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Person person)
        {
            throw new NotImplementedException();
        }

        public bool EditUser(Person person)
        {
            return PersonManager.Instance.UpdateUser(person);
        }

        public List<Person> GetAllUsers()
        {
            return PersonManager.Instance.GetAll();
        }

        public List<Item> GetBooks()
        {
            return DatabaseInstance.Instance.GetBooks();
        }

        public Person Login(string username, string password)
        {
            return PersonManager.Instance.Login(username, password);
        }

        public bool RemoveItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}