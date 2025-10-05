using Novatra.MainDB2TableAdapters;
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
    public partial class OrderForm : Form
    {
        private object Custdata, bookData;
        private int customerID, bookID, originalBookQuantiy, selectedQuantiy;
        private decimal total;
        private bool isCustBinding, isBookBinding;
        private DataRowView selectedBookRow;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDB2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.mainDB2.Orders);

            //Setting up initial visibility
            pnlMenu.Visible = true;
            pnlCreateOrder.Visible = false;
            pnlUpdateStatus.Visible = false;
            pnlAnalytics.Visible = false;

            //Setting up sizes and locations of panels
            pnlCreateOrder.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlCreateOrder.Size = new Size(900, 860);

            pnlUpdateStatus.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlUpdateStatus.Size = new Size(650, 730);

            pnlAnalytics.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlAnalytics.Size = new Size(960, 810);
            //Maximize the form window
            this.WindowState = FormWindowState.Maximized;

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Navigate to Books Form
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Navigate to Customers Form
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCreateOrder.Visible = true;      // Show the create order panel
            pnlMenu.Visible = false;            // Hide the main menu panel
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Cancel creating order and return to main menu

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel creating a new order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                pnlCreateOrder.Visible = false;     // Hide the create order panel
                pnlMenu.Visible = true;             // Show the main menu panel
            }

        }

        private void bttnDeleteConfirm_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;


        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            isCustBinding = true;
            Custdata = customersTableAdapter1.GetCustomerByPhoneNum(txtPhoneNumber.Text);
            lsbCustomers.DataSource = Custdata;
            lsbCustomers.DisplayMember = "CustomerName";
            lsbCustomers.ValueMember = "CustomerID";

            lsbCustomers.SelectedIndex = -1;
            isCustBinding = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int quantity = (int) numQuantity.Value;
            int bookQuantiy = originalBookQuantiy - quantity;




            booksTableAdapter1.UpdateQuantityQuery(bookQuantiy, bookID);      //Updating the book quantity
            ordersTableAdapter.Insert(customerID, bookID, quantity, total, "no");               //Create Order record in the Orders Table             
            this.ordersTableAdapter.Fill(this.mainDB2.Orders);
            MessageBox.Show("Order Created Successfully");

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtBookAuthor.Text = string.Empty;
            txtBookTitle.Text = string.Empty;
            txtBookTitle2.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtCustPhone.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtTotal.Text = string.Empty;
            numQuantity.Value = 1;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(numOrderID.Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this order record", "DELETING ORDER RECORD", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            
            if(dialogResult == DialogResult.Yes)
            {
                this.ordersTableAdapter.DeleteQuery(orderID);
                this.ordersTableAdapter.Fill(this.mainDB2.Orders);
                MessageBox.Show("Order Record Deleted", "DELETING ORDER RECORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            var table = this.ordersTableAdapter.getTotalRows();

            numOrderID.Maximum = table.Value;
        }

        private void txtuBookID_TextChanged(object sender, EventArgs e)
        {
            int bookID = int.Parse(txtuBookID.Text);
            var table = this.booksTableAdapter1.getBookById(bookID);

            if (table.Rows.Count != 0) {
                var row = (MainDB2.BooksRow) table.Rows[0];
                txtuBookTitle.Text = row.BookTitle;
            }
        }

        private void txtuCustID_TextChanged(object sender, EventArgs e)
        {
            int custID = int.Parse(txtuCustID.Text);
            var table = this.customersTableAdapter1.getCustomerById(custID);

            if(table.Rows.Count != 0)
            {
                var row = (MainDB2.CustomersRow) table.Rows[0];
                txtuCustName.Text = row.CustomerName;
            }
        }

        private void numericUpDown1_ValueChanged_2(object sender, EventArgs e)
        {
            if (numOrderID.Value < 1) return;
            try
            {
                int orderID = int.Parse(numOrderID.Value.ToString());
                MainDB2.OrdersDataTable ordersTable = this.mainDB2.Orders;

                ordersTableAdapter.Fill(ordersTable);

                foreach (var order in ordersTable)
                {
                    if (orderID != order.OrderID) continue;

                    txtuBookID.Text = order.BookID.ToString();
                    txtuCustID.Text = order.CustomerID.ToString();
                    txtuQuantity.Text = order.BookQuantity.ToString();
                    txtuTotal.Text = "R" + order.OrderTotal;
                    cmbOrderStatus.Text = order.Completed;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Confirm Cancellation
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this operation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) { 
                pnlUpdateStatus.Visible = false;
                pnlMenu.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlUpdateStatus.Visible = true;
        }

        private void numdOrderID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(numOrderID.Value.ToString());
            string status = cmbOrderStatus.Text;

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in status detail");
                return;
            }

            this.ordersTableAdapter.UpdateStatusQuery(status, orderID);
            this.ordersTableAdapter.Fill(this.mainDB2.Orders);
            MessageBox.Show("Status update successful", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var table = customersTableAdapter1.GetTopSpendingCustomers();
            OrderGridView.DataSource = table;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Display books based on highest revenu generated
            var table = booksTableAdapter1.GetMostRevenueBook();
            OrderGridView.DataSource = table;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Display books based on highest number of copies sold

            var table = booksTableAdapter1.GetTopSelling();
            OrderGridView.DataSource = table;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlAnalytics.Visible = true;
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            pnlAnalytics.Visible =false;
            pnlMenu.Visible=true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveFirst();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MovePrevious();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveNext();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveLast();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ordersBindingSource.Sort = "BookQuantity DESC";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ordersBindingSource.Sort = "Total DESC";
        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            selectedQuantiy = (int)numQuantity.Value;

            if (txtPrice.Text.Length < 2) return;
            decimal price = decimal.Parse(txtPrice.Text.Substring(1));
            total = price * selectedQuantiy;

            txtTotal.Text = "R" + total.ToString();
        }

        private void lsbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isBookBinding) return;
            
            selectedBookRow = (DataRowView)lsbBooks.SelectedItem;
            try
            {
                txtBookTitle2.Text = selectedBookRow["BookTitle"].ToString();
                txtBookAuthor.Text = selectedBookRow["Author"].ToString();
                txtCategory.Text = selectedBookRow["CategoryID"].ToString();
                txtPrice.Text = "R" + selectedBookRow["Price"].ToString();

                originalBookQuantiy = int.Parse(selectedBookRow["Quantity"].ToString());
                numQuantity.Minimum = 1;
                numQuantity.Maximum = originalBookQuantiy;

                bookID = int.Parse(selectedBookRow["BookID"].ToString());
            }
            catch (Exception error) {
                //This error occurs when the user selects an empty item in the listbox and can be ignored
                if (error.Message.Equals("Object reference not set to an instance of an object.")) return;   

                //Otherwise we alert the user of the error
                MessageBox.Show(error.Message + "\n Could not read selected item data", "Record Selction Error");
            }
        }

        private void lsbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCustBinding) return;


            // Cast the selected item to DataRowView
            DataRowView selectedRow = (DataRowView)lsbCustomers.SelectedItem;

            // Fill the text boxes with the customer info
            txtCustName.Text = selectedRow["CustomerName"].ToString();
            txtCustPhone.Text = selectedRow["CellPhoneNum"].ToString();

            //Store the customerID
            customerID = int.Parse(selectedRow["CustomerID"].ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isBookBinding = true;
            bookData = booksTableAdapter1.GetBookByTitle(txtBookTitle.Text);
            lsbBooks.DataSource = bookData;
            lsbBooks.DisplayMember = "BookTitle";
            lsbBooks.ValueMember = "BookID";

            lsbBooks.SelectedIndex = -1;
            isBookBinding = false;
        }
    }
}
