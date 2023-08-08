namespace SaleManagement
{
    partial class Manage_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Order));
            dgvOrder = new DataGridView();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            lbPhone = new Label();
            tbPhone = new TextBox();
            label4 = new Label();
            tbCustomerName = new TextBox();
            label3 = new Label();
            tbOrderID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtpkOrderDate = new DateTimePicker();
            panel1 = new Panel();
            button1 = new Button();
            lbOrderLink = new Label();
            pictureOrder = new PictureBox();
            lbUserLink = new Label();
            pictureUser = new PictureBox();
            lbHomeLink = new Label();
            pictureHome = new PictureBox();
            btnDelete = new Button();
            btnClear = new Button();
            label5 = new Label();
            lbTotalCostOrder = new Label();
            cboProfile = new ComboBox();
            pictureLogout = new PictureBox();
            linkAdd = new LinkLabel();
            cboSoldDate = new ComboBox();
            label7 = new Label();
            tbSearch = new TextBox();
            pictureProductLink = new PictureBox();
            lbProductLink = new Label();
            tbSeller = new TextBox();
            label10 = new Label();
            tbNote = new TextBox();
            rbOnline = new RadioButton();
            rbOffline = new RadioButton();
            detailLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProductLink).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrder.BackgroundColor = Color.White;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(465, 314);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(923, 474);
            dgvOrder.TabIndex = 45;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(21, 748);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 39);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(21, 575);
            label9.Name = "label9";
            label9.Size = new Size(55, 23);
            label9.TabIndex = 41;
            label9.Text = "Seller";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(21, 499);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 39;
            label8.Text = "Pay method";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(22, 442);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 34;
            label6.Text = "OrderDate";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.ForeColor = Color.Teal;
            lbPhone.Location = new Point(21, 378);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(59, 23);
            lbPhone.TabIndex = 32;
            lbPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhone.Location = new Point(21, 401);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(230, 30);
            tbPhone.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(22, 314);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 30;
            label4.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbCustomerName.Location = new Point(22, 337);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(230, 30);
            tbCustomerName.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(21, 231);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 28;
            label3.Text = "OrderID";
            // 
            // tbOrderID
            // 
            tbOrderID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbOrderID.Location = new Point(21, 254);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.ReadOnly = true;
            tbOrderID.Size = new Size(230, 30);
            tbOrderID.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(821, 180);
            label2.Name = "label2";
            label2.Size = new Size(206, 38);
            label2.TabIndex = 26;
            label2.Text = "Manage Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(509, 31);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý bán hàng";
            // 
            // dtpkOrderDate
            // 
            dtpkOrderDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtpkOrderDate.Location = new Point(22, 465);
            dtpkOrderDate.Name = "dtpkOrderDate";
            dtpkOrderDate.Size = new Size(230, 25);
            dtpkOrderDate.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Teal;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 125);
            panel1.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1364, -1);
            button1.Name = "button1";
            button1.Size = new Size(37, 40);
            button1.TabIndex = 54;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbOrderLink
            // 
            lbOrderLink.AutoSize = true;
            lbOrderLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderLink.ForeColor = Color.Teal;
            lbOrderLink.Location = new Point(1054, 131);
            lbOrderLink.Name = "lbOrderLink";
            lbOrderLink.Size = new Size(75, 31);
            lbOrderLink.TabIndex = 51;
            lbOrderLink.Text = "Order";
            // 
            // pictureOrder
            // 
            pictureOrder.Image = (Image)resources.GetObject("pictureOrder.Image");
            pictureOrder.Location = new Point(1000, 125);
            pictureOrder.Name = "pictureOrder";
            pictureOrder.Size = new Size(67, 39);
            pictureOrder.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOrder.TabIndex = 50;
            pictureOrder.TabStop = false;
            // 
            // lbUserLink
            // 
            lbUserLink.AutoSize = true;
            lbUserLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserLink.ForeColor = Color.Teal;
            lbUserLink.Location = new Point(654, 131);
            lbUserLink.Name = "lbUserLink";
            lbUserLink.Size = new Size(62, 31);
            lbUserLink.TabIndex = 49;
            lbUserLink.Text = "User";
            lbUserLink.Click += lbUserLink_Click;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(600, 125);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(67, 39);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 48;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click_1;
            // 
            // lbHomeLink
            // 
            lbHomeLink.AutoSize = true;
            lbHomeLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbHomeLink.ForeColor = Color.Teal;
            lbHomeLink.Location = new Point(465, 131);
            lbHomeLink.Name = "lbHomeLink";
            lbHomeLink.Size = new Size(79, 31);
            lbHomeLink.TabIndex = 47;
            lbHomeLink.Text = "Home";
            lbHomeLink.Click += lbHomeLink_Click;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(411, 125);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(67, 39);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 46;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(152, 748);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 39);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.Location = new Point(278, 331);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 39);
            btnClear.TabIndex = 55;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(21, 621);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 57;
            label5.Text = "Total cost:";
            // 
            // lbTotalCostOrder
            // 
            lbTotalCostOrder.AutoSize = true;
            lbTotalCostOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalCostOrder.ForeColor = Color.Red;
            lbTotalCostOrder.Location = new Point(127, 621);
            lbTotalCostOrder.Name = "lbTotalCostOrder";
            lbTotalCostOrder.Size = new Size(48, 23);
            lbTotalCostOrder.TabIndex = 58;
            lbTotalCostOrder.Text = "total";
            lbTotalCostOrder.Visible = false;
            // 
            // cboProfile
            // 
            cboProfile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            cboProfile.FormattingEnabled = true;
            cboProfile.Location = new Point(1252, 126);
            cboProfile.Name = "cboProfile";
            cboProfile.Size = new Size(148, 39);
            cboProfile.TabIndex = 102;
            cboProfile.SelectedIndexChanged += cboProfile_SelectedIndexChanged;
            // 
            // pictureLogout
            // 
            pictureLogout.Image = (Image)resources.GetObject("pictureLogout.Image");
            pictureLogout.Location = new Point(1183, 125);
            pictureLogout.Name = "pictureLogout";
            pictureLogout.Size = new Size(67, 39);
            pictureLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogout.TabIndex = 101;
            pictureLogout.TabStop = false;
            pictureLogout.Click += pictureLogout_Click_1;
            // 
            // linkAdd
            // 
            linkAdd.AutoSize = true;
            linkAdd.Location = new Point(278, 254);
            linkAdd.Name = "linkAdd";
            linkAdd.Size = new Size(93, 28);
            linkAdd.TabIndex = 103;
            linkAdd.TabStop = true;
            linkAdd.Text = "Add new";
            linkAdd.LinkClicked += linkAdd_LinkClicked;
            // 
            // cboSoldDate
            // 
            cboSoldDate.FormattingEnabled = true;
            cboSoldDate.Items.AddRange(new object[] { "None", "Newest", "Oldest" });
            cboSoldDate.Location = new Point(1240, 254);
            cboSoldDate.Name = "cboSoldDate";
            cboSoldDate.Size = new Size(139, 36);
            cboSoldDate.TabIndex = 104;
            cboSoldDate.SelectedIndexChanged += cboSoldDate_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(1240, 230);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 105;
            label7.Text = "Sort by";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(465, 256);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter phone number";
            tbSearch.Size = new Size(290, 34);
            tbSearch.TabIndex = 106;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // pictureProductLink
            // 
            pictureProductLink.Image = (Image)resources.GetObject("pictureProductLink.Image");
            pictureProductLink.Location = new Point(771, 125);
            pictureProductLink.Name = "pictureProductLink";
            pictureProductLink.Size = new Size(61, 40);
            pictureProductLink.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProductLink.TabIndex = 107;
            pictureProductLink.TabStop = false;
            pictureProductLink.Click += pictureProductLink_Click;
            // 
            // lbProductLink
            // 
            lbProductLink.AutoSize = true;
            lbProductLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductLink.ForeColor = Color.Teal;
            lbProductLink.Location = new Point(821, 131);
            lbProductLink.Name = "lbProductLink";
            lbProductLink.Size = new Size(99, 31);
            lbProductLink.TabIndex = 108;
            lbProductLink.Text = "Product";
            lbProductLink.Click += lbProductLink_Click;
            // 
            // tbSeller
            // 
            tbSeller.Location = new Point(104, 569);
            tbSeller.Name = "tbSeller";
            tbSeller.ReadOnly = true;
            tbSeller.Size = new Size(148, 34);
            tbSeller.TabIndex = 109;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(20, 667);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 111;
            label10.Text = "Note";
            // 
            // tbNote
            // 
            tbNote.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbNote.Location = new Point(21, 690);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(230, 30);
            tbNote.TabIndex = 110;
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Location = new Point(27, 521);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(90, 32);
            rbOnline.TabIndex = 112;
            rbOnline.TabStop = true;
            rbOnline.Text = "online";
            rbOnline.UseVisualStyleBackColor = true;
            // 
            // rbOffline
            // 
            rbOffline.AutoSize = true;
            rbOffline.Location = new Point(161, 521);
            rbOffline.Name = "rbOffline";
            rbOffline.Size = new Size(92, 32);
            rbOffline.TabIndex = 113;
            rbOffline.TabStop = true;
            rbOffline.Text = "offline";
            rbOffline.UseVisualStyleBackColor = true;
            // 
            // detailLink
            // 
            detailLink.AutoSize = true;
            detailLink.Location = new Point(281, 293);
            detailLink.Name = "detailLink";
            detailLink.Size = new Size(64, 28);
            detailLink.TabIndex = 114;
            detailLink.TabStop = true;
            detailLink.Text = "Detail";
            detailLink.Visible = false;
            detailLink.LinkClicked += detailLink_LinkClicked;
            // 
            // Manage_Order
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(detailLink);
            Controls.Add(rbOffline);
            Controls.Add(rbOnline);
            Controls.Add(label10);
            Controls.Add(tbNote);
            Controls.Add(tbSeller);
            Controls.Add(lbProductLink);
            Controls.Add(pictureProductLink);
            Controls.Add(tbSearch);
            Controls.Add(label7);
            Controls.Add(cboSoldDate);
            Controls.Add(linkAdd);
            Controls.Add(cboProfile);
            Controls.Add(pictureLogout);
            Controls.Add(lbTotalCostOrder);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lbOrderLink);
            Controls.Add(pictureOrder);
            Controls.Add(lbUserLink);
            Controls.Add(pictureUser);
            Controls.Add(lbHomeLink);
            Controls.Add(pictureHome);
            Controls.Add(dgvOrder);
            Controls.Add(btnUpdate);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(lbPhone);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            Controls.Add(tbCustomerName);
            Controls.Add(label3);
            Controls.Add(tbOrderID);
            Controls.Add(label2);
            Controls.Add(dtpkOrderDate);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Manage_Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Order";
            Load += Manage_Order_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProductLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label lbPhone;
        private TextBox tbPhone;
        private Label label4;
        private TextBox tbCustomerName;
        private Label label3;
        private TextBox tbOrderID;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpkOrderDate;
        private Panel panel1;
        private Label lbOrderLink;
        private PictureBox pictureOrder;
        private Label lbUserLink;
        private PictureBox pictureUser;
        private Label lbHomeLink;
        private PictureBox pictureHome;
        private Button button1;
        private Button btnDelete;
        private Button btnClear;
        private Label label5;
        private Label lbTotalCostOrder;
        private ComboBox cboProfile;
        private PictureBox pictureLogout;
        private LinkLabel linkAdd;
        private ComboBox cboSoldDate;
        private Label label7;
        private TextBox tbSearch;
        private PictureBox pictureProductLink;
        private Label lbProductLink;
        private TextBox tbSeller;
        private Label label10;
        private TextBox tbNote;
        private RadioButton rbOnline;
        private RadioButton rbOffline;
        private LinkLabel detailLink;
    }
}