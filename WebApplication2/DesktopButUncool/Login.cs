using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBusiness;

namespace DesktopButUncool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ILibrary library = new Library();
            string password = tbPassword.Text;
            string username = tbUsername.Text;

            if (library.Login(username, password) is Person p)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or username");
            }
        }
    }
}
