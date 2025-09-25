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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDB.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mainDB.Customers);

            // Initialize panel visibility, sizes and locations

            pnlAddCustomer.Visible = false;
            pnlUpdateCustomer.Visible = false;
            pnlDeleteCustomer.Visible = false;
            pnlMenu.Visible = true;

            pnlAddCustomer.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlUpdateCustomer.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlDeleteCustomer.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);

            pnlAddCustomer.Size = new Size(pnlMenu.Size.Width, 540);
            pnlUpdateCustomer.Size = new Size(pnlMenu.Size.Width, 540);
            pnlDeleteCustomer.Size = new Size(pnlMenu.Size.Width, 235);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bttnDeleteConfirm_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAddCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnDeleteCancel_Click(object sender, EventArgs e)
        {
            // Confirm cancel action
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel deleting a customer?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                pnlDeleteCustomer.Visible = false;                  // Hide the delete panel
                pnlMenu.Visible = true;                             // Show the main menu panel
            }
        }

        private void bttnUpdateCancel_Click(object sender, EventArgs e)
        {
            // Confirm cancel action
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel updating a customer?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                pnlUpdateCustomer.Visible = false;              // Hide the update panel
                pnlMenu.Visible = true;                         // Show the main menu panel
            }
        }
    }
}
