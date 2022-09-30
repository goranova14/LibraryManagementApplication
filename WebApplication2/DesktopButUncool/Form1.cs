using LibraryBusiness;

namespace DesktopButUncool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateUser(object sender, EventArgs e)
        {
            ILibrary library = new Library();
            library.AddUser(new Person()
            {
                Name = txtFirstName.Text,
                Password = txtPassword.Text,
                Username = txtUsername.Text,
                SurName = txtSurname.Text,
                Address = txtCity.Text,
            });
            MessageBox.Show("Good jobby!!!");
        }
    }
}