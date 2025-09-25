namespace Novatra
{
    partial class Form3
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.bttnAddConfirm = new System.Windows.Forms.Button();
            this.bttnAddCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpdateCustomer = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUCustID = new System.Windows.Forms.TextBox();
            this.bttnUpdateConfirm = new System.Windows.Forms.Button();
            this.bttnUpdateCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.pnlDeleteCustomer = new System.Windows.Forms.Panel();
            this.pnlCustID = new System.Windows.Forms.Label();
            this.txtDCustID = new System.Windows.Forms.TextBox();
            this.bttnDeleteConfirm = new System.Windows.Forms.Button();
            this.bttnDeleteCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDB = new Novatra.MainDB();
            this.customersTableAdapter = new Novatra.MainDBTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlUpdateCustomer.SuspendLayout();
            this.pnlDeleteCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 680);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(777, 79);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(576, 472);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(567, 87);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(567, 87);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Customer Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(567, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.bttnAddConfirm);
            this.pnlAddCustomer.Controls.Add(this.bttnAddCancel);
            this.pnlAddCustomer.Controls.Add(this.label5);
            this.pnlAddCustomer.Controls.Add(this.txtAPassword);
            this.pnlAddCustomer.Controls.Add(this.label4);
            this.pnlAddCustomer.Controls.Add(this.txtAPhone);
            this.pnlAddCustomer.Controls.Add(this.label3);
            this.pnlAddCustomer.Controls.Add(this.txtAEmail);
            this.pnlAddCustomer.Controls.Add(this.label15);
            this.pnlAddCustomer.Controls.Add(this.txtAName);
            this.pnlAddCustomer.Controls.Add(this.label2);
            this.pnlAddCustomer.Location = new System.Drawing.Point(41, 79);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(57, 56);
            this.pnlAddCustomer.TabIndex = 2;
            this.pnlAddCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddCustomer_Paint);
            // 
            // bttnAddConfirm
            // 
            this.bttnAddConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnAddConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnAddConfirm.Location = new System.Drawing.Point(316, 389);
            this.bttnAddConfirm.Name = "bttnAddConfirm";
            this.bttnAddConfirm.Size = new System.Drawing.Size(211, 37);
            this.bttnAddConfirm.TabIndex = 27;
            this.bttnAddConfirm.Text = "Confirm";
            this.bttnAddConfirm.UseVisualStyleBackColor = false;
            this.bttnAddConfirm.Click += new System.EventHandler(this.bttnDeleteConfirm_Click);
            // 
            // bttnAddCancel
            // 
            this.bttnAddCancel.BackColor = System.Drawing.Color.Red;
            this.bttnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnAddCancel.Location = new System.Drawing.Point(49, 389);
            this.bttnAddCancel.Name = "bttnAddCancel";
            this.bttnAddCancel.Size = new System.Drawing.Size(213, 37);
            this.bttnAddCancel.TabIndex = 26;
            this.bttnAddCancel.Text = "Cancel";
            this.bttnAddCancel.UseVisualStyleBackColor = false;
            this.bttnAddCancel.Click += new System.EventHandler(this.bttnAddCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password";
            // 
            // txtAPassword
            // 
            this.txtAPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPassword.Location = new System.Drawing.Point(49, 316);
            this.txtAPassword.Name = "txtAPassword";
            this.txtAPassword.Size = new System.Drawing.Size(478, 28);
            this.txtAPassword.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone Number";
            // 
            // txtAPhone
            // 
            this.txtAPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPhone.Location = new System.Drawing.Point(49, 242);
            this.txtAPhone.Name = "txtAPhone";
            this.txtAPhone.Size = new System.Drawing.Size(478, 28);
            this.txtAPhone.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAEmail
            // 
            this.txtAEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAEmail.Location = new System.Drawing.Point(49, 167);
            this.txtAEmail.Name = "txtAEmail";
            this.txtAEmail.Size = new System.Drawing.Size(478, 28);
            this.txtAEmail.TabIndex = 20;
            this.txtAEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "Full Name";
            // 
            // txtAName
            // 
            this.txtAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAName.Location = new System.Drawing.Point(49, 99);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(478, 28);
            this.txtAName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlUpdateCustomer
            // 
            this.pnlUpdateCustomer.Controls.Add(this.label10);
            this.pnlUpdateCustomer.Controls.Add(this.label11);
            this.pnlUpdateCustomer.Controls.Add(this.txtUCustID);
            this.pnlUpdateCustomer.Controls.Add(this.bttnUpdateConfirm);
            this.pnlUpdateCustomer.Controls.Add(this.bttnUpdateCancel);
            this.pnlUpdateCustomer.Controls.Add(this.label6);
            this.pnlUpdateCustomer.Controls.Add(this.txtUPassword);
            this.pnlUpdateCustomer.Controls.Add(this.label7);
            this.pnlUpdateCustomer.Controls.Add(this.txtUPhone);
            this.pnlUpdateCustomer.Controls.Add(this.label8);
            this.pnlUpdateCustomer.Controls.Add(this.txtUEmail);
            this.pnlUpdateCustomer.Controls.Add(this.label9);
            this.pnlUpdateCustomer.Controls.Add(this.txtUName);
            this.pnlUpdateCustomer.Location = new System.Drawing.Point(139, 79);
            this.pnlUpdateCustomer.Name = "pnlUpdateCustomer";
            this.pnlUpdateCustomer.Size = new System.Drawing.Size(57, 56);
            this.pnlUpdateCustomer.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Customer ID";
            // 
            // txtUCustID
            // 
            this.txtUCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCustID.Location = new System.Drawing.Point(45, 84);
            this.txtUCustID.Name = "txtUCustID";
            this.txtUCustID.Size = new System.Drawing.Size(478, 28);
            this.txtUCustID.TabIndex = 28;
            // 
            // bttnUpdateConfirm
            // 
            this.bttnUpdateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnUpdateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnUpdateConfirm.Location = new System.Drawing.Point(312, 444);
            this.bttnUpdateConfirm.Name = "bttnUpdateConfirm";
            this.bttnUpdateConfirm.Size = new System.Drawing.Size(211, 37);
            this.bttnUpdateConfirm.TabIndex = 27;
            this.bttnUpdateConfirm.Text = "Confirm";
            this.bttnUpdateConfirm.UseVisualStyleBackColor = false;
            // 
            // bttnUpdateCancel
            // 
            this.bttnUpdateCancel.BackColor = System.Drawing.Color.Red;
            this.bttnUpdateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnUpdateCancel.Location = new System.Drawing.Point(45, 444);
            this.bttnUpdateCancel.Name = "bttnUpdateCancel";
            this.bttnUpdateCancel.Size = new System.Drawing.Size(213, 37);
            this.bttnUpdateCancel.TabIndex = 26;
            this.bttnUpdateCancel.Text = "Cancel";
            this.bttnUpdateCancel.UseVisualStyleBackColor = false;
            this.bttnUpdateCancel.Click += new System.EventHandler(this.bttnUpdateCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password";
            // 
            // txtUPassword
            // 
            this.txtUPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPassword.Location = new System.Drawing.Point(45, 366);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(478, 28);
            this.txtUPassword.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phone Number";
            // 
            // txtUPhone
            // 
            this.txtUPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPhone.Location = new System.Drawing.Point(45, 292);
            this.txtUPhone.Name = "txtUPhone";
            this.txtUPhone.Size = new System.Drawing.Size(478, 28);
            this.txtUPhone.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // txtUEmail
            // 
            this.txtUEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUEmail.Location = new System.Drawing.Point(45, 217);
            this.txtUEmail.Name = "txtUEmail";
            this.txtUEmail.Size = new System.Drawing.Size(478, 28);
            this.txtUEmail.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Full Name";
            // 
            // txtUName
            // 
            this.txtUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(45, 149);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(478, 28);
            this.txtUName.TabIndex = 18;
            // 
            // pnlDeleteCustomer
            // 
            this.pnlDeleteCustomer.Controls.Add(this.label16);
            this.pnlDeleteCustomer.Controls.Add(this.pnlCustID);
            this.pnlDeleteCustomer.Controls.Add(this.txtDCustID);
            this.pnlDeleteCustomer.Controls.Add(this.bttnDeleteConfirm);
            this.pnlDeleteCustomer.Controls.Add(this.bttnDeleteCancel);
            this.pnlDeleteCustomer.Location = new System.Drawing.Point(226, 99);
            this.pnlDeleteCustomer.Name = "pnlDeleteCustomer";
            this.pnlDeleteCustomer.Size = new System.Drawing.Size(77, 61);
            this.pnlDeleteCustomer.TabIndex = 5;
            // 
            // pnlCustID
            // 
            this.pnlCustID.AutoSize = true;
            this.pnlCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCustID.Location = new System.Drawing.Point(72, 80);
            this.pnlCustID.Name = "pnlCustID";
            this.pnlCustID.Size = new System.Drawing.Size(120, 22);
            this.pnlCustID.TabIndex = 17;
            this.pnlCustID.Text = "Customer ID";
            // 
            // txtDCustID
            // 
            this.txtDCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCustID.Location = new System.Drawing.Point(76, 105);
            this.txtDCustID.Name = "txtDCustID";
            this.txtDCustID.Size = new System.Drawing.Size(438, 28);
            this.txtDCustID.TabIndex = 16;
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
            this.bttnDeleteCancel.Click += new System.EventHandler(this.bttnDeleteCancel_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 36);
            this.label10.TabIndex = 30;
            this.label10.Text = "Update Customer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 36);
            this.label16.TabIndex = 19;
            this.label16.Text = "DELETE CUSTOMER";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.mainDB;
            // 
            // mainDB
            // 
            this.mainDB.DataSetName = "MainDB";
            this.mainDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 680);
            this.Controls.Add(this.pnlDeleteCustomer);
            this.Controls.Add(this.pnlUpdateCustomer);
            this.Controls.Add(this.pnlAddCustomer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlUpdateCustomer.ResumeLayout(false);
            this.pnlUpdateCustomer.PerformLayout();
            this.pnlDeleteCustomer.ResumeLayout(false);
            this.pnlDeleteCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MainDB mainDB;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MainDBTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAPhone;
        private System.Windows.Forms.Button bttnAddConfirm;
        private System.Windows.Forms.Button bttnAddCancel;
        private System.Windows.Forms.Panel pnlUpdateCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUCustID;
        private System.Windows.Forms.Button bttnUpdateConfirm;
        private System.Windows.Forms.Button bttnUpdateCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Panel pnlDeleteCustomer;
        private System.Windows.Forms.Label pnlCustID;
        private System.Windows.Forms.TextBox txtDCustID;
        private System.Windows.Forms.Button bttnDeleteConfirm;
        private System.Windows.Forms.Button bttnDeleteCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
    }
}