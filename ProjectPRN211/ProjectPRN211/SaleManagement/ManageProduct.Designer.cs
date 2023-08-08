namespace SaleManagement
{
    partial class ManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            lbProductLink = new Label();
            pictureProductLink = new PictureBox();
            tbSearch = new TextBox();
            label7 = new Label();
            cboSort = new ComboBox();
            cboProfile = new ComboBox();
            pictureLogout = new PictureBox();
            btnClear = new Button();
            lbOrderLink = new Label();
            pictureOrder = new PictureBox();
            lbUserLink = new Label();
            pictureUser = new PictureBox();
            lbHomeLink = new Label();
            pictureHome = new PictureBox();
            button1 = new Button();
            dgvProduct = new DataGridView();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            tbUnitPrice = new TextBox();
            lbPhone = new Label();
            tbQuantity = new TextBox();
            label4 = new Label();
            tbProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            cboCategoryProduct = new ComboBox();
            label5 = new Label();
            btnAddProduct = new Button();
            lbProductID = new Label();
            lbValueProductID = new Label();
            button_DeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureProductLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbProductLink
            // 
            lbProductLink.AutoSize = true;
            lbProductLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductLink.ForeColor = Color.Teal;
            lbProductLink.Location = new Point(824, 132);
            lbProductLink.Name = "lbProductLink";
            lbProductLink.Size = new Size(99, 31);
            lbProductLink.TabIndex = 143;
            lbProductLink.Text = "Product";
            // 
            // pictureProductLink
            // 
            pictureProductLink.Image = (Image)resources.GetObject("pictureProductLink.Image");
            pictureProductLink.Location = new Point(769, 126);
            pictureProductLink.Name = "pictureProductLink";
            pictureProductLink.Size = new Size(67, 40);
            pictureProductLink.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProductLink.TabIndex = 142;
            pictureProductLink.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(465, 257);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter product name";
            tbSearch.Size = new Size(316, 34);
            tbSearch.TabIndex = 141;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(1237, 233);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 140;
            label7.Text = "Sort by";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "None", "Price", "Newest", "Oldest" });
            cboSort.Location = new Point(1237, 257);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(151, 36);
            cboSort.TabIndex = 139;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // cboProfile
            // 
            cboProfile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            cboProfile.FormattingEnabled = true;
            cboProfile.Location = new Point(1238, 126);
            cboProfile.Name = "cboProfile";
            cboProfile.Size = new Size(161, 39);
            cboProfile.TabIndex = 137;
            cboProfile.SelectedIndexChanged += cboProfile_SelectedIndexChanged;
            // 
            // pictureLogout
            // 
            pictureLogout.Image = (Image)resources.GetObject("pictureLogout.Image");
            pictureLogout.Location = new Point(1163, 125);
            pictureLogout.Name = "pictureLogout";
            pictureLogout.Size = new Size(73, 39);
            pictureLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogout.TabIndex = 136;
            pictureLogout.TabStop = false;
            pictureLogout.Click += pictureLogout_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.Location = new Point(295, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 39);
            btnClear.TabIndex = 133;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lbOrderLink
            // 
            lbOrderLink.AutoSize = true;
            lbOrderLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderLink.ForeColor = Color.Teal;
            lbOrderLink.Location = new Point(1031, 131);
            lbOrderLink.Name = "lbOrderLink";
            lbOrderLink.Size = new Size(75, 31);
            lbOrderLink.TabIndex = 131;
            lbOrderLink.Text = "Order";
            lbOrderLink.Click += lbOrderLink_Click;
            // 
            // pictureOrder
            // 
            pictureOrder.Image = (Image)resources.GetObject("pictureOrder.Image");
            pictureOrder.Location = new Point(973, 125);
            pictureOrder.Name = "pictureOrder";
            pictureOrder.Size = new Size(73, 39);
            pictureOrder.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOrder.TabIndex = 130;
            pictureOrder.TabStop = false;
            pictureOrder.Click += pictureOrder_Click;
            // 
            // lbUserLink
            // 
            lbUserLink.AutoSize = true;
            lbUserLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserLink.ForeColor = Color.Teal;
            lbUserLink.Location = new Point(669, 132);
            lbUserLink.Name = "lbUserLink";
            lbUserLink.Size = new Size(62, 31);
            lbUserLink.TabIndex = 129;
            lbUserLink.Text = "User";
            lbUserLink.Click += lbUserLink_Click;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(610, 126);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(73, 39);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 128;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // lbHomeLink
            // 
            lbHomeLink.AutoSize = true;
            lbHomeLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbHomeLink.ForeColor = Color.Teal;
            lbHomeLink.Location = new Point(482, 132);
            lbHomeLink.Name = "lbHomeLink";
            lbHomeLink.Size = new Size(79, 31);
            lbHomeLink.TabIndex = 127;
            lbHomeLink.Text = "Home";
            lbHomeLink.Click += lbHomeLink_Click;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(423, 126);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(73, 39);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 126;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1360, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 54;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(465, 315);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(923, 573);
            dgvProduct.TabIndex = 125;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(28, 750);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 39);
            btnUpdate.TabIndex = 124;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 123;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(23, 520);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 120;
            label8.Text = "Unit Price";
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbUnitPrice.Location = new Point(24, 543);
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(251, 30);
            tbUnitPrice.TabIndex = 119;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.ForeColor = Color.Teal;
            lbPhone.Location = new Point(23, 424);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(80, 23);
            lbPhone.TabIndex = 116;
            lbPhone.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuantity.Location = new Point(23, 447);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(251, 30);
            tbQuantity.TabIndex = 115;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(23, 334);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 114;
            label4.Text = "Product Name";
            // 
            // tbProductName
            // 
            tbProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductName.Location = new Point(23, 357);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(251, 30);
            tbProductName.TabIndex = 113;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(824, 184);
            label2.Name = "label2";
            label2.Size = new Size(234, 38);
            label2.TabIndex = 110;
            label2.Text = "Manage Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(461, 42);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý bán hàng";
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
            panel1.TabIndex = 109;
            // 
            // cboCategoryProduct
            // 
            cboCategoryProduct.FormattingEnabled = true;
            cboCategoryProduct.Location = new Point(28, 627);
            cboCategoryProduct.Name = "cboCategoryProduct";
            cboCategoryProduct.Size = new Size(250, 36);
            cboCategoryProduct.TabIndex = 144;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(28, 602);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 145;
            label5.Text = "Category";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Teal;
            btnAddProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.WhiteSmoke;
            btnAddProduct.Location = new Point(170, 750);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(108, 39);
            btnAddProduct.TabIndex = 146;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductID.ForeColor = Color.Teal;
            lbProductID.Location = new Point(24, 290);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(96, 23);
            lbProductID.TabIndex = 147;
            lbProductID.Text = "Product ID";
            lbProductID.Visible = false;
            // 
            // lbValueProductID
            // 
            lbValueProductID.AutoSize = true;
            lbValueProductID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbValueProductID.ForeColor = Color.Red;
            lbValueProductID.Location = new Point(138, 290);
            lbValueProductID.Name = "lbValueProductID";
            lbValueProductID.Size = new Size(96, 23);
            lbValueProductID.TabIndex = 148;
            lbValueProductID.Text = "Product ID";
            lbValueProductID.Visible = false;
            // 
            // button_DeleteProduct
            // 
            button_DeleteProduct.Location = new Point(303, 414);
            button_DeleteProduct.Name = "button_DeleteProduct";
            button_DeleteProduct.Size = new Size(94, 44);
            button_DeleteProduct.TabIndex = 149;
            button_DeleteProduct.Text = "Delete";
            button_DeleteProduct.UseVisualStyleBackColor = true;
            button_DeleteProduct.Click += button_DeleteProduct_Click;
            // 
            // ManageProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 900);
            Controls.Add(button_DeleteProduct);
            Controls.Add(lbValueProductID);
            Controls.Add(lbProductID);
            Controls.Add(btnAddProduct);
            Controls.Add(label5);
            Controls.Add(cboCategoryProduct);
            Controls.Add(lbProductLink);
            Controls.Add(pictureProductLink);
            Controls.Add(tbSearch);
            Controls.Add(label7);
            Controls.Add(cboSort);
            Controls.Add(cboProfile);
            Controls.Add(pictureLogout);
            Controls.Add(btnClear);
            Controls.Add(lbOrderLink);
            Controls.Add(pictureOrder);
            Controls.Add(lbUserLink);
            Controls.Add(pictureUser);
            Controls.Add(lbHomeLink);
            Controls.Add(pictureHome);
            Controls.Add(dgvProduct);
            Controls.Add(btnUpdate);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(tbUnitPrice);
            Controls.Add(lbPhone);
            Controls.Add(tbQuantity);
            Controls.Add(label4);
            Controls.Add(tbProductName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ManageProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProduct";
            Load += ManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureProductLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductLink;
        private PictureBox pictureProductLink;
        private TextBox tbSearch;
        private Label label7;
        private ComboBox cboSort;
        private ComboBox cboProfile;
        private PictureBox pictureLogout;
        private Button btnClear;
        private Label lbOrderLink;
        private PictureBox pictureOrder;
        private Label lbUserLink;
        private PictureBox pictureUser;
        private Label lbHomeLink;
        private PictureBox pictureHome;
        private Button button1;
        private DataGridView dgvProduct;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Label label8;
        private TextBox tbUnitPrice;
        private Label lbPhone;
        private TextBox tbQuantity;
        private Label label4;
        private TextBox tbProductName;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private ComboBox cboCategoryProduct;
        private Label label5;
        private Button btnAddProduct;
        private Label lbProductID;
        private Label lbValueProductID;
        private Button button_DeleteProduct;
    }
}