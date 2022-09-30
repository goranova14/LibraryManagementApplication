using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections;
using Org.BouncyCastle.Utilities.Collections;
using System.Xml.Linq;

namespace LibraryBusiness
{
    public class DatabaseInstance
    {
        public static DatabaseInstance Instance { get; } = new DatabaseInstance();
        private DatabaseInstance()
        {

        }

        internal bool InsertNewPerson(Person newPerson)
        {
            try
            {

                string sql = $@"
                        INSERT INTO PERSON (username,NAME, Surname, Address, Password, RoleID) VALUES
                        ('{newPerson.Username}','{newPerson.Name}', '{newPerson.SurName}', '{newPerson.Address}','{newPerson.Password}', '{newPerson.Role.ID}')
                    ";

                return ExecuteNonScalarSQL(sql);
            }
            catch
            {
                return false;
            }
        }
        public bool InsertNewItem(Item newItem)
        {
            try
            {
                if (newItem is Book)
                {

                    string sql = $@"
                        INSERT INTO Item (Title, Author, Publisher, Description, Genre, Pages) VALUES
                        ('{newItem.Title}', '{newItem.Author}', '{newItem.Publisher}','{newItem.Description}', '{newItem.Genre}' , '{((Book)newItem).Pages}')
                    ";

                    return ExecuteNonScalarSQL(sql);
                }
                if (newItem is EBook)
                {

                    string sql = $@"
                        INSERT INTO Item (Title, Author, Publisher, Description, Genre, DPI) VALUES
                        ('{newItem.Title}', '{newItem.Author}', '{newItem.Publisher}','{newItem.Description}', '{newItem.Genre}' , '{((EBook)newItem).DPI}')
                    ";

                    return ExecuteNonScalarSQL(sql);
                }

            }
            catch
            {
                return false;
            }
            return false;
        }


        private bool ExecuteNonScalarSQL(string sql)
        {
            using SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS02;Database=LibraryManagementSystem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");
            conn.Open();
            return new SqlCommand(sql, conn).ExecuteNonQuery() != 0;
            //Add finally to close conn
        }

        public DataTable GetPerson(string username)
        {
            string sql = $@"
                DECLARE @Username NVARCHAR(200) = '{username}';
                SELECT * FROM PERSON WHERE USERNAME = @Username
            ";
            return ExecuteSQL(sql);
        }
        public List<Item> GetBooks()
        {
            List<Item> books = new List<Item>();
            using SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS02;Database=LibraryManagementSystem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand($@"SELECT * FROM ITEM WHERE PAGES IS NOT NULL", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Item book = new Book();
                book.Author = (string)reader["Author"];
                book.Title = (string)reader["Title"];
                book.Genre = (string)reader["Genre"];
                ((Book)book).Pages = (int)reader["Pages"];
                book.Description = (string)reader["Description"];
                book.Publisher = (string)reader["Publisher"];

                books.Add(((Book)book));
            }
            return books;

        }

        private DataTable ExecuteSQL(string sql)
        {
            using SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS02;Database=LibraryManagementSystem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");
            DataTable tab = new DataTable();
            conn.Open();
            using (SqlDataAdapter comm = new SqlDataAdapter(sql, conn))
            {
                // Adapter fill table function
                comm.Fill(tab);
            }
            conn.Close();
            return tab;
        }

        public DataTable GetAllPersons()
        {
            return ExecuteSQL("SELECT * FROM person");
        }

        internal Role? GetRoleByID(Guid guid)
        {
            using SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS02;Database=LibraryManagementSystem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand($@"SELECT * FROM Roles where ID = @RoleID", conn);
            sqlCommand.Parameters.Add(new SqlParameter("@RoleID", guid));
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Role role = new Role();
            while (reader.Read())
            {
                role.ID = (Guid)reader["ID"];
                role.Name = (string)reader["Name"];
                role.AccessLevel = (int)reader["AccessLevel"];
            }
            return role;
        }
        internal bool UpdateUser(Person person)
        {
            using SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS02;Database=LibraryManagementSystem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand($@"UPDATE person
                                                                SET 
                                                                    UserName = @Username,
                                                                    Name = @Name,
                                                                    SurName = @SurName,
                                                                    Address = @Address
                                                                WHERE ID = @ID ", conn);
            sqlCommand.Parameters.Add(new SqlParameter("@ID", person.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@Username", person.Username));
            sqlCommand.Parameters.Add(new SqlParameter("@Name", person.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@SurName", person.SurName));
            sqlCommand.Parameters.Add(new SqlParameter("@Address", person.Address));
            return sqlCommand.ExecuteNonQuery() != 0;
        }
    }
}
