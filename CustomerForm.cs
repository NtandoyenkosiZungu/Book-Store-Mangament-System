using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novatra
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
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


            // Maximize the form window
            this.WindowState = FormWindowState.Maximized;


        }

        

        //Method to check for email validity
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        //Method to check for cell phone number validity
        public bool IsValidCellNumber(string number)
        {
            string pattern = @"^0\d{9}$";
            return Regex.IsMatch(number, pattern);
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

            //Validating user input
            if (string.IsNullOrEmpty(fullName)) {
                MessageBox.Show("Invalid Customer Name", "RECORDING CUSTOMER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAName.Focus();
                return;
            }

            if(!IsValidEmail(email))
            {
                MessageBox.Show("Invalid Email", "RECORDING CUSTOMER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAEmail.Focus();
                return;
            }

            if (!IsValidCellNumber(phone)) {
                MessageBox.Show("Invalid Cellphone Number", "RECORDING CUSTOMER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAPhone.Focus();
                return;
            }

            //Inserting Customer Details into Database
            try
            {
                this.customersTableAdapter.Insert(fullName, email, phone);      // Add new customer to the database
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message

                // Clear input fields after successful addition
                txtAName.Clear();
                txtAEmail.Clear();
                txtAPhone.Clear();
                this.customersTableAdapter.Fill(this.mainDB.Customers); // Refresh the customer list
                pnlAddCustomer.Visible = false;                 // Hide the add panel
                pnlMenu.Visible = false;
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

        private void bttnUpdateConfirm_Click(object sender, EventArgs e)
        {
            //Reading Customer Details from TextBoxes
            int customerID = int.Parse(numuCustID.Value.ToString());
            String fullName = txtUName.Text;
            String email = txtUEmail.Text;
            String phone = txtUPhone.Text;

            //Data Validation
            if (string.IsNullOrEmpty(fullName)) {
                MessageBox.Show("Invalid Customer Name ", "UPDATING ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUName.Focus();
                return;
            }

            if (!IsValidCellNumber(phone))
            {
                MessageBox.Show("Invalid Cellphone Number", "UPDATING CUSTOMER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAPhone.Focus();
                return;
            }

            if (!IsValidEmail(email)) {
                MessageBox.Show("Invalid Email", "UPDATING CUSTOMER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUName.Focus();
                return;
            }


            //Updating Customer Details in Database
            try
            {
                this.customersTableAdapter.UpdateQuery(fullName, email, phone, customerID);           // Update customer details in the database
                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message


                // Clear input fields after successful update
                numuCustID.Value = 0;
                txtUName.Clear();
                txtUEmail.Clear();
                txtUPhone.Clear();

                this.customersTableAdapter.Fill(this.mainDB.Customers); // Refresh the customer list

            }
            catch (Exception error)
            {
                MessageBox.Show("Error updating customer: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             // Show error message if updating fails
            }
        }

        private void txtUPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String phone = txtUPhone.Text;

                if(phone.Length == 10)
                {
                    //Load customer details
                    MainDB2.CustomersDataTable customers = this.mainDB.Customers;

                    // Iterate through the customers to find a match
                    foreach (var customer in customers)
                    {
                        if (customer.CellPhoneNum != phone) continue;

                        // Populate the text boxes with customer details
                        numuCustID.Value = int.Parse( customer.CustomerID.ToString());
                        txtUName.Text = customer.CustomerName;
                        txtUEmail.Text = customer.Email;
                        break;
                    }

                }
            }
            catch (Exception error) {
                MessageBox.Show("Error updating data: " , error.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Navigate to Books Form
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Navigate to Orders Form
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            customersBindingSource.Sort = "CustomerName ASC";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveFirst();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveLast();
        }

        private void bttnDeleteConfirm_Click_1(object sender, EventArgs e)
        {
            try
            {
                int custID = int.Parse(numdCustID.Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer ", "DELETING CUSTOMER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {
                    customersTableAdapter.DeleteQuery(custID);
                    numdCustID.Value = 1;
                    this.customersTableAdapter.Fill(this.mainDB.Customers);
                    MessageBox.Show("Customer successfully deleted", "DELETING CUSTOMER");
                }
            }catch(Exception error)
            {
                MessageBox.Show("Deleting Customer Error: " + error.Message );
            }

            
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            customersBindingSource.Sort = "CustomerID ASC";
        }

        private void numuCustID_ValueChanged(object sender, EventArgs e)
        {
            int custID = int.Parse(numuCustID.Value.ToString());

            MainDB2.CustomersDataTable table = this.mainDB.Customers;

            customersTableAdapter.Fill(table);

            foreach(var row in table)
            {
                MessageBox.Show(""+row.CustomerID);
                if (row.CustomerID != custID) continue;

                txtUName.Text = row.CustomerName;
                txtUEmail.Text = row.Email.ToString();
                txtUPhone.Text = row.CellPhoneNum.ToString();
                break;
            }
        }

        private void numuCustID_ValueChanged_1(object sender, EventArgs e)
        {
            int custID = int.Parse(numuCustID.Value.ToString());

            MainDB2.CustomersDataTable table = this.mainDB.Customers;

            customersTableAdapter.Fill(table);

            foreach (var row in table)
            {
                if (row.CustomerID != custID) continue;

                txtUName.Text = row.CustomerName;
                txtUEmail.Text = row.Email.ToString();
                txtUPhone.Text = row.CellPhoneNum.ToString();
                break;
            }
        }
    }
}
