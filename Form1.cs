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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtAdmin.Text;
            String password = txtPassword.Text;

           

            var results = adminsTableAdapter1.CheckLogIn( username, password);

            if(results.Rows.Count > 0)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Login Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
