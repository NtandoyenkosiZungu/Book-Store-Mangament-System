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



            var results = adminsTableAdapter2.LogIn(username, password);

            if(results.Rows.Count > 0)
            {
                BooksForm form2 = new BooksForm();
                form2.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Login Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
