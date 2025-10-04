namespace Novatra
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDB = new Novatra.MainDB2();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnDeleteBook = new System.Windows.Forms.Button();
            this.bttnUpdateBook = new System.Windows.Forms.Button();
            this.bttnAddBook = new System.Windows.Forms.Button();
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.maPrice = new System.Windows.Forms.MaskedTextBox();
            this.numaQuantiy = new System.Windows.Forms.NumericUpDown();
            this.cmbaCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.bttnAddBookConfirm = new System.Windows.Forms.Button();
            this.bttnAddBookCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaBookAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaBookTitle = new System.Windows.Forms.TextBox();
            this.pnlUpdateBook = new System.Windows.Forms.Panel();
            this.txtuPrice = new System.Windows.Forms.TextBox();
            this.numuQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbuGenre = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtuBookID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnUpdateBookConfirm = new System.Windows.Forms.Button();
            this.bttnUpdateBookCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtuBookAuthor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtuBookTitle = new System.Windows.Forms.TextBox();
            this.pnlDeleteBook = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdBookID = new System.Windows.Forms.TextBox();
            this.bttnDeleteConfirm = new System.Windows.Forms.Button();
            this.bttnDeleteCancel = new System.Windows.Forms.Button();
            this.booksTableAdapter = new Novatra.MainDB2TableAdapters.BooksTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.categoriesTableAdapter1 = new Novatra.MainDB2TableAdapters.CategoriesTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDB)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaQuantiy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.pnlUpdateBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuQuantity)).BeginInit();
            this.pnlDeleteBook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 682);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.mainDB;
            // 
            // mainDB
            // 
            this.mainDB.DataSetName = "MainDB";
            this.mainDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.bttnDeleteBook);
            this.pnlMenu.Controls.Add(this.bttnUpdateBook);
            this.pnlMenu.Controls.Add(this.bttnAddBook);
            this.pnlMenu.Location = new System.Drawing.Point(822, 100);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(569, 480);
            this.pnlMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnDeleteBook
            // 
            this.bttnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDeleteBook.Location = new System.Drawing.Point(0, 350);
            this.bttnDeleteBook.Name = "bttnDeleteBook";
            this.bttnDeleteBook.Size = new System.Drawing.Size(569, 111);
            this.bttnDeleteBook.TabIndex = 2;
            this.bttnDeleteBook.Text = "Delete Book";
            this.bttnDeleteBook.UseVisualStyleBackColor = true;
            this.bttnDeleteBook.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnUpdateBook
            // 
            this.bttnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateBook.Location = new System.Drawing.Point(0, 233);
            this.bttnUpdateBook.Name = "bttnUpdateBook";
            this.bttnUpdateBook.Size = new System.Drawing.Size(569, 111);
            this.bttnUpdateBook.TabIndex = 1;
            this.bttnUpdateBook.Text = "Update Book";
            this.bttnUpdateBook.UseVisualStyleBackColor = true;
            this.bttnUpdateBook.Click += new System.EventHandler(this.bttnUpdateBook_Click);
            // 
            // bttnAddBook
            // 
            this.bttnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddBook.Location = new System.Drawing.Point(0, 117);
            this.bttnAddBook.Name = "bttnAddBook";
            this.bttnAddBook.Size = new System.Drawing.Size(569, 111);
            this.bttnAddBook.TabIndex = 0;
            this.bttnAddBook.Text = "Add Book";
            this.bttnAddBook.UseVisualStyleBackColor = true;
            this.bttnAddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.Controls.Add(this.maPrice);
            this.pnlAddBook.Controls.Add(this.numaQuantiy);
            this.pnlAddBook.Controls.Add(this.cmbaCategory);
            this.pnlAddBook.Controls.Add(this.label7);
            this.pnlAddBook.Controls.Add(this.bttnAddBookConfirm);
            this.pnlAddBook.Controls.Add(this.bttnAddBookCancel);
            this.pnlAddBook.Controls.Add(this.label6);
            this.pnlAddBook.Controls.Add(this.label5);
            this.pnlAddBook.Controls.Add(this.label4);
            this.pnlAddBook.Controls.Add(this.label3);
            this.pnlAddBook.Controls.Add(this.txtaBookAuthor);
            this.pnlAddBook.Controls.Add(this.label2);
            this.pnlAddBook.Controls.Add(this.txtaBookTitle);
            this.pnlAddBook.Location = new System.Drawing.Point(76, 100);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(53, 47);
            this.pnlAddBook.TabIndex = 2;
            this.pnlAddBook.Visible = false;
            this.pnlAddBook.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // maPrice
            // 
            this.maPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maPrice.Location = new System.Drawing.Point(92, 360);
            this.maPrice.Mask = "R 9999.99";
            this.maPrice.Name = "maPrice";
            this.maPrice.Size = new System.Drawing.Size(438, 28);
            this.maPrice.TabIndex = 15;
            // 
            // numaQuantiy
            // 
            this.numaQuantiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numaQuantiy.Location = new System.Drawing.Point(92, 295);
            this.numaQuantiy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numaQuantiy.Name = "numaQuantiy";
            this.numaQuantiy.Size = new System.Drawing.Size(438, 28);
            this.numaQuantiy.TabIndex = 14;
            this.numaQuantiy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbaCategory
            // 
            this.cmbaCategory.DataSource = this.categoryBindingSource;
            this.cmbaCategory.DisplayMember = "CategoryName";
            this.cmbaCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaCategory.FormattingEnabled = true;
            this.cmbaCategory.Location = new System.Drawing.Point(92, 231);
            this.cmbaCategory.Name = "cmbaCategory";
            this.cmbaCategory.Size = new System.Drawing.Size(438, 30);
            this.cmbaCategory.TabIndex = 13;
            this.cmbaCategory.ValueMember = "CategoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Categories";
            this.categoryBindingSource.DataSource = this.mainDB;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "ADD BOOK";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnAddBookConfirm
            // 
            this.bttnAddBookConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnAddBookConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddBookConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnAddBookConfirm.Location = new System.Drawing.Point(341, 424);
            this.bttnAddBookConfirm.Name = "bttnAddBookConfirm";
            this.bttnAddBookConfirm.Size = new System.Drawing.Size(189, 37);
            this.bttnAddBookConfirm.TabIndex = 11;
            this.bttnAddBookConfirm.Text = "Confirm";
            this.bttnAddBookConfirm.UseVisualStyleBackColor = false;
            this.bttnAddBookConfirm.Click += new System.EventHandler(this.bttnAddBookConfirm_Click);
            // 
            // bttnAddBookCancel
            // 
            this.bttnAddBookCancel.BackColor = System.Drawing.Color.Red;
            this.bttnAddBookCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddBookCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnAddBookCancel.Location = new System.Drawing.Point(92, 424);
            this.bttnAddBookCancel.Name = "bttnAddBookCancel";
            this.bttnAddBookCancel.Size = new System.Drawing.Size(191, 37);
            this.bttnAddBookCancel.TabIndex = 10;
            this.bttnAddBookCancel.Text = "Cancel";
            this.bttnAddBookCancel.UseVisualStyleBackColor = false;
            this.bttnAddBookCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Book Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // txtaBookAuthor
            // 
            this.txtaBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaBookAuthor.Location = new System.Drawing.Point(92, 165);
            this.txtaBookAuthor.Name = "txtaBookAuthor";
            this.txtaBookAuthor.Size = new System.Drawing.Size(438, 28);
            this.txtaBookAuthor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book TItle";
            // 
            // txtaBookTitle
            // 
            this.txtaBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaBookTitle.Location = new System.Drawing.Point(92, 97);
            this.txtaBookTitle.Name = "txtaBookTitle";
            this.txtaBookTitle.Size = new System.Drawing.Size(438, 28);
            this.txtaBookTitle.TabIndex = 0;
            // 
            // pnlUpdateBook
            // 
            this.pnlUpdateBook.Controls.Add(this.txtuPrice);
            this.pnlUpdateBook.Controls.Add(this.numuQuantity);
            this.pnlUpdateBook.Controls.Add(this.cmbuGenre);
            this.pnlUpdateBook.Controls.Add(this.label14);
            this.pnlUpdateBook.Controls.Add(this.txtuBookID);
            this.pnlUpdateBook.Controls.Add(this.label8);
            this.pnlUpdateBook.Controls.Add(this.bttnUpdateBookConfirm);
            this.pnlUpdateBook.Controls.Add(this.bttnUpdateBookCancel);
            this.pnlUpdateBook.Controls.Add(this.label9);
            this.pnlUpdateBook.Controls.Add(this.label10);
            this.pnlUpdateBook.Controls.Add(this.label11);
            this.pnlUpdateBook.Controls.Add(this.label12);
            this.pnlUpdateBook.Controls.Add(this.txtuBookAuthor);
            this.pnlUpdateBook.Controls.Add(this.label13);
            this.pnlUpdateBook.Controls.Add(this.txtuBookTitle);
            this.pnlUpdateBook.Location = new System.Drawing.Point(349, 140);
            this.pnlUpdateBook.Name = "pnlUpdateBook";
            this.pnlUpdateBook.Size = new System.Drawing.Size(43, 70);
            this.pnlUpdateBook.TabIndex = 3;
            this.pnlUpdateBook.Visible = false;
            this.pnlUpdateBook.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtuPrice
            // 
            this.txtuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuPrice.Location = new System.Drawing.Point(92, 400);
            this.txtuPrice.Name = "txtuPrice";
            this.txtuPrice.Size = new System.Drawing.Size(438, 28);
            this.txtuPrice.TabIndex = 17;
            // 
            // numuQuantity
            // 
            this.numuQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numuQuantity.Location = new System.Drawing.Point(92, 335);
            this.numuQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numuQuantity.Name = "numuQuantity";
            this.numuQuantity.Size = new System.Drawing.Size(438, 28);
            this.numuQuantity.TabIndex = 16;
            this.numuQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbuGenre
            // 
            this.cmbuGenre.DataSource = this.categoryBindingSource;
            this.cmbuGenre.DisplayMember = "CategoryName";
            this.cmbuGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbuGenre.FormattingEnabled = true;
            this.cmbuGenre.Location = new System.Drawing.Point(92, 270);
            this.cmbuGenre.Name = "cmbuGenre";
            this.cmbuGenre.Size = new System.Drawing.Size(438, 30);
            this.cmbuGenre.TabIndex = 15;
            this.cmbuGenre.ValueMember = "CategoryID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(88, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Book ID";
            // 
            // txtuBookID
            // 
            this.txtuBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuBookID.Location = new System.Drawing.Point(92, 80);
            this.txtuBookID.Name = "txtuBookID";
            this.txtuBookID.Size = new System.Drawing.Size(438, 28);
            this.txtuBookID.TabIndex = 13;
            this.txtuBookID.TextChanged += new System.EventHandler(this.txtuBookID_TextChanged);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = "UPDATE BOOK";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnUpdateBookConfirm
            // 
            this.bttnUpdateBookConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnUpdateBookConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateBookConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnUpdateBookConfirm.Location = new System.Drawing.Point(341, 448);
            this.bttnUpdateBookConfirm.Name = "bttnUpdateBookConfirm";
            this.bttnUpdateBookConfirm.Size = new System.Drawing.Size(189, 37);
            this.bttnUpdateBookConfirm.TabIndex = 11;
            this.bttnUpdateBookConfirm.Text = "Confirm";
            this.bttnUpdateBookConfirm.UseVisualStyleBackColor = false;
            this.bttnUpdateBookConfirm.Click += new System.EventHandler(this.bttnUpdateBookConfirm_Click);
            // 
            // bttnUpdateBookCancel
            // 
            this.bttnUpdateBookCancel.BackColor = System.Drawing.Color.Red;
            this.bttnUpdateBookCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateBookCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnUpdateBookCancel.Location = new System.Drawing.Point(92, 448);
            this.bttnUpdateBookCancel.Name = "bttnUpdateBookCancel";
            this.bttnUpdateBookCancel.Size = new System.Drawing.Size(191, 37);
            this.bttnUpdateBookCancel.TabIndex = 10;
            this.bttnUpdateBookCancel.Text = "Cancel";
            this.bttnUpdateBookCancel.UseVisualStyleBackColor = false;
            this.bttnUpdateBookCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Book Genre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "Author";
            // 
            // txtuBookAuthor
            // 
            this.txtuBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuBookAuthor.Location = new System.Drawing.Point(92, 204);
            this.txtuBookAuthor.Name = "txtuBookAuthor";
            this.txtuBookAuthor.Size = new System.Drawing.Size(438, 28);
            this.txtuBookAuthor.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(88, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "Book TItle";
            // 
            // txtuBookTitle
            // 
            this.txtuBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuBookTitle.Location = new System.Drawing.Point(92, 136);
            this.txtuBookTitle.Name = "txtuBookTitle";
            this.txtuBookTitle.Size = new System.Drawing.Size(438, 28);
            this.txtuBookTitle.TabIndex = 0;
            // 
            // pnlDeleteBook
            // 
            this.pnlDeleteBook.Controls.Add(this.label16);
            this.pnlDeleteBook.Controls.Add(this.label15);
            this.pnlDeleteBook.Controls.Add(this.txtdBookID);
            this.pnlDeleteBook.Controls.Add(this.bttnDeleteConfirm);
            this.pnlDeleteBook.Controls.Add(this.bttnDeleteCancel);
            this.pnlDeleteBook.Location = new System.Drawing.Point(240, 196);
            this.pnlDeleteBook.Name = "pnlDeleteBook";
            this.pnlDeleteBook.Size = new System.Drawing.Size(59, 60);
            this.pnlDeleteBook.TabIndex = 4;
            this.pnlDeleteBook.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 36);
            this.label16.TabIndex = 18;
            this.label16.Text = "DELETE BOOK";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(72, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 17;
            this.label15.Text = "Book ID";
            // 
            // txtdBookID
            // 
            this.txtdBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdBookID.Location = new System.Drawing.Point(76, 105);
            this.txtdBookID.Name = "txtdBookID";
            this.txtdBookID.Size = new System.Drawing.Size(438, 28);
            this.txtdBookID.TabIndex = 16;
            // 
            // bttnDeleteConfirm
            // 
            this.bttnDeleteConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnDeleteConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDeleteConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnDeleteConfirm.Location = new System.Drawing.Point(325, 153);
            this.bttnDeleteConfirm.Name = "bttnDeleteConfirm";
            this.bttnDeleteConfirm.Size = new System.Drawing.Size(189, 37);
            this.bttnDeleteConfirm.TabIndex = 13;
            this.bttnDeleteConfirm.Text = "Confirm";
            this.bttnDeleteConfirm.UseVisualStyleBackColor = false;
            this.bttnDeleteConfirm.Click += new System.EventHandler(this.bttnDeleteConfirm_Click);
            // 
            // bttnDeleteCancel
            // 
            this.bttnDeleteCancel.BackColor = System.Drawing.Color.Red;
            this.bttnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDeleteCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnDeleteCancel.Location = new System.Drawing.Point(76, 153);
            this.bttnDeleteCancel.Name = "bttnDeleteCancel";
            this.bttnDeleteCancel.Size = new System.Drawing.Size(191, 37);
            this.bttnDeleteCancel.TabIndex = 12;
            this.bttnDeleteCancel.Text = "Cancel";
            this.bttnDeleteCancel.UseVisualStyleBackColor = false;
            this.bttnDeleteCancel.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(802, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 48);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDeleteBook);
            this.Controls.Add(this.pnlUpdateBook);
            this.Controls.Add(this.pnlAddBook);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BooksForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDB)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaQuantiy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.pnlUpdateBook.ResumeLayout(false);
            this.pnlUpdateBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuQuantity)).EndInit();
            this.pnlDeleteBook.ResumeLayout(false);
            this.pnlDeleteBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MainDB2 mainDB;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private MainDB2TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button bttnDeleteBook;
        private System.Windows.Forms.Button bttnUpdateBook;
        private System.Windows.Forms.Button bttnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaBookTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaBookAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnAddBookConfirm;
        private System.Windows.Forms.Button bttnAddBookCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlUpdateBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtuBookID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnUpdateBookConfirm;
        private System.Windows.Forms.Button bttnUpdateBookCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtuBookAuthor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtuBookTitle;
        private System.Windows.Forms.Panel pnlDeleteBook;
        private System.Windows.Forms.Button bttnDeleteConfirm;
        private System.Windows.Forms.Button bttnDeleteCancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtdBookID;
        private System.Windows.Forms.ComboBox cmbaCategory;
        private System.Windows.Forms.MaskedTextBox maPrice;
        private System.Windows.Forms.NumericUpDown numaQuantiy;
        private System.Windows.Forms.NumericUpDown numuQuantity;
        private System.Windows.Forms.ComboBox cmbuGenre;
        private System.Windows.Forms.TextBox txtuPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MainDB2TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}