namespace Novatra
{
    partial class CustomerForm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.bttnAddConfirm = new System.Windows.Forms.Button();
            this.bttnAddCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDeleteCustomer = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlCustID = new System.Windows.Forms.Label();
            this.bttnDeleteConfirm = new System.Windows.Forms.Button();
            this.bttnDeleteCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDB = new Novatra.MainDB2();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnUpdateCancel = new System.Windows.Forms.Button();
            this.bttnUpdateConfirm = new System.Windows.Forms.Button();
            this.txtUPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlUpdateCustomer = new System.Windows.Forms.Panel();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Novatra.MainDB2TableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Novatra.MainDB2TableAdapters.TableAdapterManager();
            this.numuCustID = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numdCustID = new System.Windows.Forms.NumericUpDown();
            this.pnlMenu.SuspendLayout();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlDeleteCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDB)).BeginInit();
            this.pnlUpdateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuCustID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdCustID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(1182, 112);
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
            this.pnlAddCustomer.Controls.Add(this.label4);
            this.pnlAddCustomer.Controls.Add(this.txtAPhone);
            this.pnlAddCustomer.Controls.Add(this.label3);
            this.pnlAddCustomer.Controls.Add(this.txtAEmail);
            this.pnlAddCustomer.Controls.Add(this.label15);
            this.pnlAddCustomer.Controls.Add(this.txtAName);
            this.pnlAddCustomer.Controls.Add(this.label2);
            this.pnlAddCustomer.Location = new System.Drawing.Point(960, 682);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(34, 104);
            this.pnlAddCustomer.TabIndex = 2;
            this.pnlAddCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddCustomer_Paint);
            // 
            // bttnAddConfirm
            // 
            this.bttnAddConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnAddConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnAddConfirm.Location = new System.Drawing.Point(316, 295);
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
            this.bttnAddCancel.Location = new System.Drawing.Point(49, 295);
            this.bttnAddCancel.Name = "bttnAddCancel";
            this.bttnAddCancel.Size = new System.Drawing.Size(213, 37);
            this.bttnAddCancel.TabIndex = 26;
            this.bttnAddCancel.Text = "Cancel";
            this.bttnAddCancel.UseVisualStyleBackColor = false;
            this.bttnAddCancel.Click += new System.EventHandler(this.bttnAddCancel_Click);
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
            this.label2.Size = new System.Drawing.Size(34, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlDeleteCustomer
            // 
            this.pnlDeleteCustomer.Controls.Add(this.numdCustID);
            this.pnlDeleteCustomer.Controls.Add(this.label16);
            this.pnlDeleteCustomer.Controls.Add(this.pnlCustID);
            this.pnlDeleteCustomer.Controls.Add(this.bttnDeleteConfirm);
            this.pnlDeleteCustomer.Controls.Add(this.bttnDeleteCancel);
            this.pnlDeleteCustomer.Location = new System.Drawing.Point(1211, 702);
            this.pnlDeleteCustomer.Name = "pnlDeleteCustomer";
            this.pnlDeleteCustomer.Size = new System.Drawing.Size(45, 91);
            this.pnlDeleteCustomer.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 34);
            this.label16.TabIndex = 19;
            this.label16.Text = "DELETE CUSTOMER";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bttnDeleteConfirm.Click += new System.EventHandler(this.bttnDeleteConfirm_Click_1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(883, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 48);
            this.panel1.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(667, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(217, 48);
            this.button7.TabIndex = 3;
            this.button7.Text = "Log Out";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(450, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 48);
            this.button6.TabIndex = 2;
            this.button6.Text = "Orders";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(233, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 48);
            this.button5.TabIndex = 0;
            this.button5.Text = "Books";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Location = new System.Drawing.Point(892, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 530);
            this.panel2.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.AccessibleDescription = "";
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 59);
            this.button8.TabIndex = 5;
            this.button8.Text = "Reset Order";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button17
            // 
            this.button17.AccessibleDescription = "";
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(0, 236);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(223, 59);
            this.button17.TabIndex = 4;
            this.button17.Text = "Order By Name (ASC)";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Top;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(0, 177);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(223, 59);
            this.button18.TabIndex = 3;
            this.button18.Text = "Go To Last";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Top;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(0, 118);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(223, 59);
            this.button19.TabIndex = 2;
            this.button19.Text = "Next";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Top;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(0, 59);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(223, 59);
            this.button20.TabIndex = 1;
            this.button20.Text = "Previous";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.AccessibleDescription = "";
            this.button21.Dock = System.Windows.Forms.DockStyle.Top;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(0, 0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(223, 59);
            this.button21.TabIndex = 0;
            this.button21.Text = "Go To First";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.customersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(886, 1007);
            this.customersDataGridView.TabIndex = 15;
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CellPhoneNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "CellPhoneNum";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
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
            // txtUName
            // 
            this.txtUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(45, 149);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(478, 28);
            this.txtUName.TabIndex = 18;
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
            // txtUEmail
            // 
            this.txtUEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUEmail.Location = new System.Drawing.Point(45, 217);
            this.txtUEmail.Name = "txtUEmail";
            this.txtUEmail.Size = new System.Drawing.Size(478, 28);
            this.txtUEmail.TabIndex = 20;
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
            // bttnUpdateCancel
            // 
            this.bttnUpdateCancel.BackColor = System.Drawing.Color.Red;
            this.bttnUpdateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnUpdateCancel.Location = new System.Drawing.Point(45, 357);
            this.bttnUpdateCancel.Name = "bttnUpdateCancel";
            this.bttnUpdateCancel.Size = new System.Drawing.Size(213, 37);
            this.bttnUpdateCancel.TabIndex = 26;
            this.bttnUpdateCancel.Text = "Cancel";
            this.bttnUpdateCancel.UseVisualStyleBackColor = false;
            this.bttnUpdateCancel.Click += new System.EventHandler(this.bttnUpdateCancel_Click);
            // 
            // bttnUpdateConfirm
            // 
            this.bttnUpdateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnUpdateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnUpdateConfirm.Location = new System.Drawing.Point(312, 357);
            this.bttnUpdateConfirm.Name = "bttnUpdateConfirm";
            this.bttnUpdateConfirm.Size = new System.Drawing.Size(211, 37);
            this.bttnUpdateConfirm.TabIndex = 27;
            this.bttnUpdateConfirm.Text = "Confirm";
            this.bttnUpdateConfirm.UseVisualStyleBackColor = false;
            this.bttnUpdateConfirm.Click += new System.EventHandler(this.bttnUpdateConfirm_Click);
            // 
            // txtUPhone
            // 
            this.txtUPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPhone.Location = new System.Drawing.Point(45, 283);
            this.txtUPhone.MaxLength = 10;
            this.txtUPhone.Name = "txtUPhone";
            this.txtUPhone.Size = new System.Drawing.Size(478, 28);
            this.txtUPhone.TabIndex = 22;
            this.txtUPhone.TextChanged += new System.EventHandler(this.txtUPhone_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 36);
            this.label10.TabIndex = 30;
            this.label10.Text = "Update Customer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUpdateCustomer
            // 
            this.pnlUpdateCustomer.Controls.Add(this.numuCustID);
            this.pnlUpdateCustomer.Controls.Add(this.label11);
            this.pnlUpdateCustomer.Controls.Add(this.label10);
            this.pnlUpdateCustomer.Controls.Add(this.label7);
            this.pnlUpdateCustomer.Controls.Add(this.txtUPhone);
            this.pnlUpdateCustomer.Controls.Add(this.bttnUpdateConfirm);
            this.pnlUpdateCustomer.Controls.Add(this.bttnUpdateCancel);
            this.pnlUpdateCustomer.Controls.Add(this.label8);
            this.pnlUpdateCustomer.Controls.Add(this.txtUEmail);
            this.pnlUpdateCustomer.Controls.Add(this.label9);
            this.pnlUpdateCustomer.Controls.Add(this.txtUName);
            this.pnlUpdateCustomer.Location = new System.Drawing.Point(1095, 672);
            this.pnlUpdateCustomer.Name = "pnlUpdateCustomer";
            this.pnlUpdateCustomer.Size = new System.Drawing.Size(42, 121);
            this.pnlUpdateCustomer.TabIndex = 3;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.mainDB;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Novatra.MainDB2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numuCustID
            // 
            this.numuCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numuCustID.Location = new System.Drawing.Point(47, 82);
            this.numuCustID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numuCustID.Name = "numuCustID";
            this.numuCustID.Size = new System.Drawing.Size(476, 27);
            this.numuCustID.TabIndex = 33;
            this.numuCustID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numuCustID.ValueChanged += new System.EventHandler(this.numuCustID_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Customer ID";
            // 
            // numdCustID
            // 
            this.numdCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdCustID.Location = new System.Drawing.Point(76, 113);
            this.numdCustID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numdCustID.Name = "numdCustID";
            this.numdCustID.Size = new System.Drawing.Size(438, 27);
            this.numdCustID.TabIndex = 34;
            this.numdCustID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1007);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDeleteCustomer);
            this.Controls.Add(this.pnlUpdateCustomer);
            this.Controls.Add(this.pnlAddCustomer);
            this.Controls.Add(this.pnlMenu);
            this.Name = "CustomerForm";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlDeleteCustomer.ResumeLayout(false);
            this.pnlDeleteCustomer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDB)).EndInit();
            this.pnlUpdateCustomer.ResumeLayout(false);
            this.pnlUpdateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuCustID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdCustID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MainDB2 mainDB;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MainDB2TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAPhone;
        private System.Windows.Forms.Button bttnAddConfirm;
        private System.Windows.Forms.Button bttnAddCancel;
        private System.Windows.Forms.Panel pnlDeleteCustomer;
        private System.Windows.Forms.Label pnlCustID;
        private System.Windows.Forms.Button bttnDeleteConfirm;
        private System.Windows.Forms.Button bttnDeleteCancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private MainDB2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel pnlUpdateCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUPhone;
        private System.Windows.Forms.Button bttnUpdateConfirm;
        private System.Windows.Forms.Button bttnUpdateCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown numuCustID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numdCustID;
    }
}