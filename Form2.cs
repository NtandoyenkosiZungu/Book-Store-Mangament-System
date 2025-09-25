using Novatra.MainDBTableAdapters;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            pnlMenu.Visible = true;
            pnlAddBook.Visible = false;
            pnlUpdateBook.Visible = false;
            pnlDeleteBook.Visible = false;

            pnlDeleteBook.Size = new Size(pnlMenu.Size.Width, 234);
            pnlUpdateBook.Size = new Size(pnlMenu.Size.Width, 505);
            pnlAddBook.Size = new Size(pnlMenu.Size.Width, 505);

            pnlAddBook.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlUpdateBook.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
            pnlDeleteBook.Location = new Point(pnlMenu.Location.X, pnlMenu.Location.Y);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDB.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.mainDB.Books);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlDeleteBook.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel adding a new book?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                pnlAddBook.Visible = false;
                pnlMenu.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlAddBook.Visible = true;
        }

        private void bttnAddBookConfirm_Click(object sender, EventArgs e)
        {
            String bookTitle = txtaBookTitle.Text;                                  //Get book title from textbox
            String bookAuthor = txtaBookAuthor.Text;                                //Get book author from textbox
            String bookGenre = cmbaCategory.Text;

            //Reading Category ID from ComboBox selection
            int categoryId = int.Parse(""+bookGenre[0]);                        //We know the first character of the genre string is the category ID


            decimal price = decimal.Parse(maPrice.Text.Replace("R", "").Trim());   //Remove "R" and trim any whitespace before parsing

            int quantity = (int) numaQuantiy.Value;                             //Get quantity from NumericUpDown

            //Inserting new book into database
            try
            {
                booksTableAdapter.AddBook(bookTitle, bookAuthor, price, quantity, categoryId);
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clear input fields after successful addition
                txtaBookTitle.Clear();
                txtaBookAuthor.Clear();
                cmbaCategory.SelectedIndex = -1;
                numaQuantiy.Value = 1;
                maPrice.Text = "R0.00";

                this.booksTableAdapter.Fill(this.mainDB.Books); // Refresh the book list
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred while adding the book: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel updating book information?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                pnlUpdateBook.Visible = false;
                pnlMenu.Visible = true;
            }

            
        }

        private void bttnUpdateBook_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlUpdateBook.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel deleting a book?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                pnlDeleteBook.Visible = false;
                pnlMenu.Visible = true;
            }
        }

        private void bttnDeleteConfirm_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtdBookID.Text);

            try
            {
                booksTableAdapter.DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdBookID.Clear();                           // Clear input field after successful deletion
                this.booksTableAdapter.Fill(this.mainDB.Books); // Refresh the book list
            }
            catch(Exception error)
            {
                MessageBox.Show("An error occurred while deleting the book: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnUpdateBookConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = int.Parse(txtuBookID.Text);
                String bookTitle = txtuBookTitle.Text;                                           //Get book title from textbox
                String bookAuthor = txtuBookAuthor.Text;                                        //Get book author from textbox
                String bookGenre = cmbuGenre.Text;

                //Reading Category ID from ComboBox selection
                int categoryId = int.Parse(bookGenre[0].ToString());                             //We know the first character of the genre string is the category ID

                decimal price = decimal.Parse(txtuPrice.Text.Replace("R", "").Trim());          //Remove "R" and trim any whitespace before parsing

                int quantity = (int)numuQuantity.Value;                                         //Get quantity from NumericUpDown

                booksTableAdapter.UpdateBook(bookTitle, bookAuthor, price, quantity, categoryId, bookId);

                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Clear input fields after successful update
                txtuBookID.Clear();
                txtuBookTitle.Clear();
                txtuBookAuthor.Clear();
                cmbuGenre.SelectedIndex = -1;
                numuQuantity.Value = 1;
                txtuPrice.Text = "R0.00";

                this.booksTableAdapter.Fill(this.mainDB.Books); // Refresh the book list

            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred while updating the book: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void txtuBookID_TextChanged(object sender, EventArgs e)
        {
            try { 
                int bookId = int.Parse(txtuBookID.Text);
                MainDB.BooksDataTable bookTable = this.mainDB.Books;

                booksTableAdapter.Fill(bookTable);

                foreach (var book in bookTable)
                {
                    if (bookId != book.BookID) { continue; }

                    txtuBookTitle.Text = book.Title;
                    txtuBookAuthor.Text = book.Author;
                    cmbuGenre.SelectedIndex = book.CategoryID - 1;
                    numuQuantity.Value = book.Quantity;
                    txtuPrice.Text = "R" + book.Price.ToString();
                }
            }catch(Exception error)
            {
                txtaBookTitle.Text = "";
                txtaBookAuthor.Text = "";
                cmbaCategory.SelectedIndex = -1;
                numaQuantiy.Value = 1;
                txtuPrice.Text = "R0.00";
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Navigate back to Form3 (Customer Form)
            this.Hide();
            Form3 customerForm = new Form3();
            customerForm.Show();


        }
    }
}
