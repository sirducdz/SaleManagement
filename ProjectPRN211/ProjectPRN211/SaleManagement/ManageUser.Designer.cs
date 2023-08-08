namespace SaleManagement
{
    partial class ManageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUser));
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboProfile = new System.Windows.Forms.ComboBox();
            this.pictureLogout = new System.Windows.Forms.PictureBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.addUser = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbProductLink = new System.Windows.Forms.Label();
            this.pictureProductLink = new System.Windows.Forms.PictureBox();
            this.lbOrderLink = new System.Windows.Forms.Label();
            this.pictureOrder = new System.Windows.Forms.PictureBox();
            this.lbUserLink = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lbHomeLink = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.GridColor = System.Drawing.Color.White;
            this.dgvUser.Location = new System.Drawing.Point(465, 314);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(923, 474);
            this.dgvUser.TabIndex = 56;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(94, 736);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 39);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(33, 678);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.cboStatus.Location = new System.Drawing.Point(104, 670);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(178, 31);
            this.cboStatus.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(34, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "Role";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMale.Location = new System.Drawing.Point(112, 555);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 27);
            this.rbMale.TabIndex = 47;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(33, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(31, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Date of birth";
            // 
            // dtpkDOB
            // 
            this.dtpkDOB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpkDOB.Location = new System.Drawing.Point(31, 506);
            this.dtpkDOB.Name = "dtpkDOB";
            this.dtpkDOB.Size = new System.Drawing.Size(250, 25);
            this.dtpkDOB.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(31, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(31, 439);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(251, 30);
            this.tbEmail.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(26, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPhone.Location = new System.Drawing.Point(26, 372);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(251, 30);
            this.tbPhone.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(19, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "FullName";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(19, 309);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 30);
            this.tbName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(840, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = "Manage User";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1361, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Management System v1.0";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFemale.Location = new System.Drawing.Point(193, 555);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(88, 27);
            this.rbFemale.TabIndex = 48;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 125);
            this.panel1.TabIndex = 36;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(282, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 30);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboProfile
            // 
            this.cboProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboProfile.FormattingEnabled = true;
            this.cboProfile.Location = new System.Drawing.Point(1238, 126);
            this.cboProfile.Name = "cboProfile";
            this.cboProfile.Size = new System.Drawing.Size(161, 39);
            this.cboProfile.TabIndex = 100;
            this.cboProfile.SelectedIndexChanged += new System.EventHandler(this.cboProfile_SelectedIndexChanged);
            // 
            // pictureLogout
            // 
            this.pictureLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogout.Image")));
            this.pictureLogout.Location = new System.Drawing.Point(1169, 125);
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.Size = new System.Drawing.Size(73, 39);
            this.pictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogout.TabIndex = 99;
            this.pictureLogout.TabStop = false;
            this.pictureLogout.Click += new System.EventHandler(this.pictureLogout_Click);
            // 
            // cboRole
            // 
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.cboRole.Location = new System.Drawing.Point(41, 619);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(241, 31);
            this.cboRole.TabIndex = 101;
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Location = new System.Drawing.Point(283, 370);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(89, 28);
            this.addUser.TabIndex = 102;
            this.addUser.TabStop = true;
            this.addUser.Text = "Add new";
            this.addUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addUser_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(20, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 28);
            this.label10.TabIndex = 103;
            this.label10.Text = "User ID";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUserID.ForeColor = System.Drawing.Color.Red;
            this.lbUserID.Location = new System.Drawing.Point(133, 241);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(81, 28);
            this.lbUserID.TabIndex = 104;
            this.lbUserID.Text = "User ID";
            this.lbUserID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(465, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 23);
            this.label12.TabIndex = 108;
            this.label12.Text = "Filter by status";
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(465, 255);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(179, 36);
            this.cboFilter.TabIndex = 107;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(1094, 255);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Enter name of user ";
            this.tbSearch.Size = new System.Drawing.Size(294, 34);
            this.tbSearch.TabIndex = 109;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbProductLink
            // 
            this.lbProductLink.AutoSize = true;
            this.lbProductLink.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductLink.ForeColor = System.Drawing.Color.Teal;
            this.lbProductLink.Location = new System.Drawing.Point(821, 131);
            this.lbProductLink.Name = "lbProductLink";
            this.lbProductLink.Size = new System.Drawing.Size(99, 31);
            this.lbProductLink.TabIndex = 151;
            this.lbProductLink.Text = "Product";
            this.lbProductLink.Click += new System.EventHandler(this.lbProductLink_Click);
            // 
            // pictureProductLink
            // 
            this.pictureProductLink.Image = ((System.Drawing.Image)(resources.GetObject("pictureProductLink.Image")));
            this.pictureProductLink.Location = new System.Drawing.Point(771, 125);
            this.pictureProductLink.Name = "pictureProductLink";
            this.pictureProductLink.Size = new System.Drawing.Size(67, 40);
            this.pictureProductLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProductLink.TabIndex = 150;
            this.pictureProductLink.TabStop = false;
            this.pictureProductLink.Click += new System.EventHandler(this.pictureProductLink_Click);
            // 
            // lbOrderLink
            // 
            this.lbOrderLink.AutoSize = true;
            this.lbOrderLink.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderLink.ForeColor = System.Drawing.Color.Teal;
            this.lbOrderLink.Location = new System.Drawing.Point(1054, 131);
            this.lbOrderLink.Name = "lbOrderLink";
            this.lbOrderLink.Size = new System.Drawing.Size(75, 31);
            this.lbOrderLink.TabIndex = 149;
            this.lbOrderLink.Text = "Order";
            this.lbOrderLink.Click += new System.EventHandler(this.lbOrderLink_Click_1);
            // 
            // pictureOrder
            // 
            this.pictureOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureOrder.Image")));
            this.pictureOrder.Location = new System.Drawing.Point(1000, 125);
            this.pictureOrder.Name = "pictureOrder";
            this.pictureOrder.Size = new System.Drawing.Size(73, 39);
            this.pictureOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOrder.TabIndex = 148;
            this.pictureOrder.TabStop = false;
            this.pictureOrder.Click += new System.EventHandler(this.pictureOrder_Click_1);
            // 
            // lbUserLink
            // 
            this.lbUserLink.AutoSize = true;
            this.lbUserLink.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUserLink.ForeColor = System.Drawing.Color.Teal;
            this.lbUserLink.Location = new System.Drawing.Point(654, 131);
            this.lbUserLink.Name = "lbUserLink";
            this.lbUserLink.Size = new System.Drawing.Size(62, 31);
            this.lbUserLink.TabIndex = 147;
            this.lbUserLink.Text = "User";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(600, 125);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(73, 39);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 146;
            this.pictureUser.TabStop = false;
            // 
            // lbHomeLink
            // 
            this.lbHomeLink.AutoSize = true;
            this.lbHomeLink.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHomeLink.ForeColor = System.Drawing.Color.Teal;
            this.lbHomeLink.Location = new System.Drawing.Point(465, 131);
            this.lbHomeLink.Name = "lbHomeLink";
            this.lbHomeLink.Size = new System.Drawing.Size(79, 31);
            this.lbHomeLink.TabIndex = 145;
            this.lbHomeLink.Text = "Home";
            this.lbHomeLink.Click += new System.EventHandler(this.lbHomeLink_Click_1);
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(411, 125);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(73, 39);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 144;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click_1);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lbProductLink);
            this.Controls.Add(this.pictureProductLink);
            this.Controls.Add(this.lbOrderLink);
            this.Controls.Add(this.pictureOrder);
            this.Controls.Add(this.lbUserLink);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.lbHomeLink);
            this.Controls.Add(this.pictureHome);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.cboProfile);
            this.Controls.Add(this.pictureLogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpkDOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvUser;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Label label9;
        private ComboBox cboStatus;
        private Label label8;
        private RadioButton rbMale;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpkDOB;
        private Label label5;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbPhone;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private Button button1;
        private Label label1;
        private RadioButton rbFemale;
        private Panel panel1;
        private Button btnClear;
        private ComboBox cboProfile;
        private PictureBox pictureLogout;
        private ComboBox cboRole;
        private LinkLabel addUser;
        private Label label10;
        private Label lbUserID;
        private Label label12;
        private ComboBox cboFilter;
        private TextBox tbSearch;
        private Label lbProductLink;
        private PictureBox pictureProductLink;
        private Label lbOrderLink;
        private PictureBox pictureOrder;
        private Label lbUserLink;
        private PictureBox pictureUser;
        private Label lbHomeLink;
        private PictureBox pictureHome;
    }
}