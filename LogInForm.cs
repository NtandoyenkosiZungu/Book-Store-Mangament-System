using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novatra
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtAdmin.Text;
            String password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please fill in your username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdmin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password)) {
                MessageBox.Show("Please fill in your password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus(); 
                return;
            }

            var results = adminsTableAdapter2.LogIn(username, password);

            if(results.Rows.Count > 0)
            {
                BooksForm form2 = new BooksForm();
                form2.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Account Not Found, Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
