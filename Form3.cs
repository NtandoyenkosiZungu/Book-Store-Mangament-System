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
            //Reading Customer Details from TextBoxes
            String fullName = txtAName.Text;
            String email = txtAEmail.Text;
            String phone = txtAPhone.Text;
            String password = txtAPassword.Text;

            //Inserting Customer Details into Database
            try
            {
                this.customersTableAdapter.AddCustomerQuery(fullName, email, password, phone);      // Add new customer to the database
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message

                // Clear input fields after successful addition
                txtAName.Clear();
                txtAEmail.Clear();
                txtAPhone.Clear();
                txtAPassword.Clear();
                this.customersTableAdapter.Fill(this.mainDB.Customers); // Refresh the customer list
                pnlAddCustomer.Visible = false;                 // Hide the add panel
            }
            catch (Exception error)
            {
                MessageBox.Show("Error adding customer: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             // Show error message if adding fails
            }
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

        private void bttnAddCancel_Click(object sender, EventArgs e)
        {
            // Confirm cancel action
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel adding a new customer?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                pnlAddCustomer.Visible = false;                 // Hide the add panel
                pnlMenu.Visible = true;                         // Show the main menu panel
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;            // Hide the main menu panel
            pnlAddCustomer.Visible = true;      // Show the add customer panel
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;            // Hide the main menu panel
            pnlAddCustomer.Visible = true;     // Show the add customer panel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;            // Hide the main menu panel
            pnlUpdateCustomer.Visible = true;   // Show the update customer panel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;             //Hide the main menu panel
            pnlDeleteCustomer.Visible = true;    //Show the update customer panel
        }
    }
}
