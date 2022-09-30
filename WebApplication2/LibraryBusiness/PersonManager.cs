using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
    public class PersonManager
    {
        public static PersonManager Instance { get; } = new PersonManager();
        public PersonManager()
        {

        }
        public Person CreateNewPerson(string username, string password, string name, string surname, string address, Role role)
        {
            // Password should be hashed before here on client side as otherwise the string might be caught in traffic.
            Person newPerson = new Person()
            {
                Username = username,
                Password = BCrypt.Net.BCrypt.HashPassword(password),
                Name = name,
                SurName = surname,
                Address = address,
                Role = role

            };
            DatabaseInstance.Instance.InsertNewPerson(newPerson);

            return newPerson;
        }

        public Person Login(string username, string password)
        {
            try
            {
            if (DatabaseInstance.Instance.GetPerson(username).Rows[0] is DataRow personRow)
            {
                if (BCrypt.Net.BCrypt.Verify(password, personRow[nameof(Person.Password)].ToString()))
                {
                    return new Person(personRow);
                }
                return null;
            }

            }
            catch (Exception)
            {

            }
            return null;

        }

        internal List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            foreach (DataRow row in DatabaseInstance.Instance.GetAllPersons().Rows)
            {
                persons.Add(new Person(row));
            }
            return persons;
        }

        internal bool UpdateUser(Person person)
        {
            return DatabaseInstance.Instance.UpdateUser(person);
        }
    }
}
