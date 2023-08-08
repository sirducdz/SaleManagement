namespace SaleManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            button1 = new Button();
            pictureLogout = new PictureBox();
            cboProfile = new ComboBox();
            lbProductLink = new Label();
            pictureProductLink = new PictureBox();
            lbOrderLink = new Label();
            pictureOrder = new PictureBox();
            lbUserLink = new Label();
            pictureUser = new PictureBox();
            lbHomeLink = new Label();
            pictureHome = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            from = new DateTimePicker();
            to = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            dgv = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Sold = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Remaining = new DataGridViewTextBoxColumn();
            label4 = new Label();
            totalRevenue = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProductLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 800);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(67, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1333, 125);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(450, 49);
            label5.Name = "label5";
            label5.Size = new Size(270, 28);
            label5.TabIndex = 94;
            label5.Text = "Hệ thống quản lý bán hàng";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1294, -1);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 93;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureLogout
            // 
            pictureLogout.Image = (Image)resources.GetObject("pictureLogout.Image");
            pictureLogout.Location = new Point(1164, 125);
            pictureLogout.Name = "pictureLogout";
            pictureLogout.Size = new Size(73, 39);
            pictureLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogout.TabIndex = 91;
            pictureLogout.TabStop = false;
            pictureLogout.Click += pictureLogout_Click;
            // 
            // cboProfile
            // 
            cboProfile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            cboProfile.FormattingEnabled = true;
            cboProfile.Location = new Point(1239, 126);
            cboProfile.Name = "cboProfile";
            cboProfile.Size = new Size(161, 39);
            cboProfile.TabIndex = 92;
            cboProfile.SelectedIndexChanged += cboProfile_SelectedIndexChanged;
            // 
            // lbProductLink
            // 
            lbProductLink.AutoSize = true;
            lbProductLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductLink.ForeColor = Color.Teal;
            lbProductLink.Location = new Point(788, 131);
            lbProductLink.Name = "lbProductLink";
            lbProductLink.Size = new Size(99, 31);
            lbProductLink.TabIndex = 151;
            lbProductLink.Text = "Product";
            lbProductLink.Click += lbProductLink_Click;
            // 
            // pictureProductLink
            // 
            pictureProductLink.Image = (Image)resources.GetObject("pictureProductLink.Image");
            pictureProductLink.Location = new Point(733, 125);
            pictureProductLink.Name = "pictureProductLink";
            pictureProductLink.Size = new Size(67, 40);
            pictureProductLink.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProductLink.TabIndex = 150;
            pictureProductLink.TabStop = false;
            pictureProductLink.Click += pictureProductLink_Click;
            // 
            // lbOrderLink
            // 
            lbOrderLink.AutoSize = true;
            lbOrderLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderLink.ForeColor = Color.Teal;
            lbOrderLink.Location = new Point(1012, 131);
            lbOrderLink.Name = "lbOrderLink";
            lbOrderLink.Size = new Size(75, 31);
            lbOrderLink.TabIndex = 149;
            lbOrderLink.Text = "Order";
            lbOrderLink.Click += lbOrderLink_Click_1;
            // 
            // pictureOrder
            // 
            pictureOrder.Image = (Image)resources.GetObject("pictureOrder.Image");
            pictureOrder.Location = new Point(954, 125);
            pictureOrder.Name = "pictureOrder";
            pictureOrder.Size = new Size(73, 39);
            pictureOrder.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOrder.TabIndex = 148;
            pictureOrder.TabStop = false;
            pictureOrder.Click += pictureOrder_Click_1;
            // 
            // lbUserLink
            // 
            lbUserLink.AutoSize = true;
            lbUserLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserLink.ForeColor = Color.Teal;
            lbUserLink.Location = new Point(622, 132);
            lbUserLink.Name = "lbUserLink";
            lbUserLink.Size = new Size(62, 31);
            lbUserLink.TabIndex = 147;
            lbUserLink.Text = "User";
            lbUserLink.Click += lbUserLink_Click_1;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(563, 126);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(73, 39);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 146;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click_1;
            // 
            // lbHomeLink
            // 
            lbHomeLink.AutoSize = true;
            lbHomeLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbHomeLink.ForeColor = Color.Teal;
            lbHomeLink.Location = new Point(450, 131);
            lbHomeLink.Name = "lbHomeLink";
            lbHomeLink.Size = new Size(79, 31);
            lbHomeLink.TabIndex = 145;
            lbHomeLink.Text = "Home";
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(394, 126);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(73, 39);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 144;
            pictureHome.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(68, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(1333, 90);
            panel3.TabIndex = 152;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(449, 25);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 0;
            label1.Text = "Thống kê doanh thu";
            // 
            // from
            // 
            from.CalendarForeColor = SystemColors.ActiveCaption;
            from.CalendarMonthBackground = SystemColors.HotTrack;
            from.Location = new Point(76, 343);
            from.Name = "from";
            from.Size = new Size(250, 27);
            from.TabIndex = 153;
            // 
            // to
            // 
            to.CalendarForeColor = SystemColors.ActiveCaption;
            to.CalendarMonthBackground = SystemColors.HotTrack;
            to.Location = new Point(76, 413);
            to.Name = "to";
            to.Size = new Size(250, 27);
            to.TabIndex = 154;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(77, 314);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 155;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(76, 383);
            label3.Name = "label3";
            label3.Size = new Size(34, 28);
            label3.TabIndex = 156;
            label3.Text = "To";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(123, 478);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 49);
            btnSearch.TabIndex = 157;
            btnSearch.Text = "Thống kê";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, UnitPrice, Stock, Sold, TotalPrice, Remaining });
            dgv.Location = new Point(540, 314);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(769, 456);
            dgv.TabIndex = 158;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Total in stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // Sold
            // 
            Sold.HeaderText = "Amount sold";
            Sold.MinimumWidth = 6;
            Sold.Name = "Sold";
            Sold.ReadOnly = true;
            Sold.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 125;
            // 
            // Remaining
            // 
            Remaining.HeaderText = "Amount remaining";
            Remaining.MinimumWidth = 6;
            Remaining.Name = "Remaining";
            Remaining.ReadOnly = true;
            Remaining.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(81, 586);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 159;
            label4.Text = "Tổng doanh thu:";
            // 
            // totalRevenue
            // 
            totalRevenue.AutoSize = true;
            totalRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalRevenue.ForeColor = Color.Red;
            totalRevenue.Location = new Point(269, 588);
            totalRevenue.Name = "totalRevenue";
            totalRevenue.Size = new Size(24, 28);
            totalRevenue.TabIndex = 160;
            totalRevenue.Text = "0";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(totalRevenue);
            Controls.Add(label4);
            Controls.Add(dgv);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(to);
            Controls.Add(from);
            Controls.Add(panel3);
            Controls.Add(lbProductLink);
            Controls.Add(pictureProductLink);
            Controls.Add(lbOrderLink);
            Controls.Add(pictureOrder);
            Controls.Add(lbUserLink);
            Controls.Add(pictureUser);
            Controls.Add(lbHomeLink);
            Controls.Add(pictureHome);
            Controls.Add(cboProfile);
            Controls.Add(pictureLogout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProductLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureLogout;
        private Button button1;
        private ComboBox cboProfile;
        private Label lbProductLink;
        private PictureBox pictureProductLink;
        private Label lbOrderLink;
        private PictureBox pictureOrder;
        private Label lbUserLink;
        private PictureBox pictureUser;
        private Label lbHomeLink;
        private PictureBox pictureHome;
        private Panel panel3;
        private Label label1;
        private DateTimePicker from;
        private DateTimePicker to;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Sold;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Remaining;
        private Label label4;
        private Label totalRevenue;
        private Label label5;
    }
}