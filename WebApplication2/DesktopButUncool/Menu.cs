using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopButUncool
{
    public partial class Menu : Form
    {
        private ILibrary Library { get; }
        public Menu()
        {
            InitializeComponent();
            Library = new LibraryBusiness.Library();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                listView1.Columns.Add(new ColumnHeader() { Width = 0, Text = "ID" });
                listView1.Columns.Add(new ColumnHeader() { Width = 100, Text = "Deni's favorite people" });
                listView1.Columns.Add(new ColumnHeader() { Width = 100, Text = "Name" });
                listView1.Columns.Add(new ColumnHeader() { Width = 100, Text = "Surname" });
                listView1.Columns.Add(new ColumnHeader() { Width = 100, Text = "Address" });
                listView1.Columns.Add(new ColumnHeader() { Width = 100, Text = "Role" });
                UpdateListView();
            }
            catch
            {

            }
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (Person person in Library.GetAllUsers())
                listView1.Items.Add(new ListViewItem(new String[] { person.ID.ToString(), person.Username, person.Name, person.SurName, person.Address, person.Role.Name }));

        }
        Person Person { get; set; }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                Person = Library.GetAllUsers().First(x => x.ID.ToString() == item.Text.ToString());
                tbFirstName.Text = Person.Name;
                tbLastName.Text = Person.SurName;
                tbAddress.Text = Person.Address;
                tbUsername.Text = Person.Username;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Person.Name = tbFirstName.Text;
            Person.SurName = tbLastName.Text;
            Person.Address = tbAddress.Text;
            Person.Username = tbUsername.Text;

            Library.EditUser(Person);
            UpdateListView();
        }
    }
}
