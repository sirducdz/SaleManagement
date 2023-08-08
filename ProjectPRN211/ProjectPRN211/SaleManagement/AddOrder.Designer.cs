namespace SaleManagement
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            button1 = new Button();
            label1 = new Label();
            dgvOrderDetails = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            PayMethod = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lbPhone = new Label();
            tbPhone = new TextBox();
            label4 = new Label();
            tbCustomerName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            cboCategory = new ComboBox();
            label7 = new Label();
            lbTotal = new Label();
            label11 = new Label();
            btnDelete = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            numUD = new NumericUpDown();
            label5 = new Label();
            cboProduct = new ComboBox();
            label3 = new Label();
            lbunitPrice = new Label();
            label9 = new Label();
            lbTotalCost = new Label();
            label12 = new Label();
            rbOnline = new RadioButton();
            rbOffline = new RadioButton();
            lbSeller = new Label();
            lbSellerValue = new Label();
            lbID = new Label();
            lbIDValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1360, -1);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 54;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(450, 43);
            label1.Name = "label1";
            label1.Size = new Size(306, 31);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý bán hàng";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderDetails.BackgroundColor = Color.White;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Columns.AddRange(new DataGridViewColumn[] { ID, ProductID, ProductName, Category, UnitPrice, Quantity, Total, PayMethod });
            dgvOrderDetails.GridColor = Color.White;
            dgvOrderDetails.Location = new Point(494, 219);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(894, 519);
            dgvOrderDetails.TabIndex = 76;
            dgvOrderDetails.CellClick += dgvOrderDetails_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // PayMethod
            // 
            PayMethod.HeaderText = "PayMethod";
            PayMethod.MinimumWidth = 6;
            PayMethod.Name = "PayMethod";
            PayMethod.Width = 125;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(281, 699);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 39);
            btnUpdate.TabIndex = 75;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 699);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 39);
            btnAdd.TabIndex = 74;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(26, 627);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 70;
            label8.Text = "Pay method";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.ForeColor = Color.Teal;
            lbPhone.Location = new Point(14, 321);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(59, 23);
            lbPhone.TabIndex = 66;
            lbPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhone.Location = new Point(14, 344);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(441, 30);
            tbPhone.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(14, 243);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 64;
            label4.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbCustomerName.Location = new Point(14, 266);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(441, 30);
            tbCustomerName.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(841, 144);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 60;
            label2.Text = "Order Details";
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
            panel1.TabIndex = 59;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(24, 433);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(204, 28);
            cboCategory.TabIndex = 89;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(24, 531);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 92;
            label7.Text = "Quantity";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.FromArgb(192, 64, 0);
            lbTotal.Location = new Point(123, 576);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(24, 28);
            lbTotal.TabIndex = 94;
            lbTotal.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(24, 581);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 93;
            label11.Text = "Total cost:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(158, 699);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 85;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(787, 773);
            button2.Name = "button2";
            button2.Size = new Size(186, 69);
            button2.TabIndex = 97;
            button2.Text = "Save Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(844, 851);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 28);
            linkLabel1.TabIndex = 123;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // numUD
            // 
            numUD.Location = new Point(118, 531);
            numUD.Name = "numUD";
            numUD.Size = new Size(150, 27);
            numUD.TabIndex = 124;
            numUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUD.ValueChanged += numUD_ValueChanged;
            numUD.KeyPress += numUD_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(24, 407);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 125;
            label5.Text = "Category";
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(259, 433);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(206, 28);
            cboProduct.TabIndex = 126;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(259, 407);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 127;
            label3.Text = "Product";
            // 
            // lbunitPrice
            // 
            lbunitPrice.AutoSize = true;
            lbunitPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbunitPrice.ForeColor = Color.FromArgb(128, 128, 255);
            lbunitPrice.Location = new Point(358, 471);
            lbunitPrice.Name = "lbunitPrice";
            lbunitPrice.Size = new Size(20, 23);
            lbunitPrice.TabIndex = 129;
            lbunitPrice.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(259, 471);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 128;
            label9.Text = "Unit Price:";
            // 
            // lbTotalCost
            // 
            lbTotalCost.AutoSize = true;
            lbTotalCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalCost.ForeColor = Color.Red;
            lbTotalCost.Location = new Point(1067, 823);
            lbTotalCost.Name = "lbTotalCost";
            lbTotalCost.Size = new Size(24, 28);
            lbTotalCost.TabIndex = 131;
            lbTotalCost.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(1029, 792);
            label12.Name = "label12";
            label12.Size = new Size(225, 31);
            label12.TabIndex = 130;
            label12.Text = "Total money to pay:";
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Location = new Point(144, 630);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(71, 24);
            rbOnline.TabIndex = 132;
            rbOnline.TabStop = true;
            rbOnline.Text = "online";
            rbOnline.UseVisualStyleBackColor = true;
            // 
            // rbOffline
            // 
            rbOffline.AutoSize = true;
            rbOffline.Location = new Point(266, 630);
            rbOffline.Name = "rbOffline";
            rbOffline.Size = new Size(73, 24);
            rbOffline.TabIndex = 133;
            rbOffline.TabStop = true;
            rbOffline.Text = "offline";
            rbOffline.UseVisualStyleBackColor = true;
            // 
            // lbSeller
            // 
            lbSeller.AutoSize = true;
            lbSeller.Location = new Point(1039, 192);
            lbSeller.Name = "lbSeller";
            lbSeller.Size = new Size(49, 20);
            lbSeller.TabIndex = 134;
            lbSeller.Text = "Seller:";
            // 
            // lbSellerValue
            // 
            lbSellerValue.AutoSize = true;
            lbSellerValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSellerValue.ForeColor = SystemColors.ActiveCaption;
            lbSellerValue.Location = new Point(1107, 194);
            lbSellerValue.Name = "lbSellerValue";
            lbSellerValue.Size = new Size(0, 28);
            lbSellerValue.TabIndex = 135;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.ForeColor = Color.Red;
            lbID.Location = new Point(18, 194);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 20);
            lbID.TabIndex = 136;
            lbID.Text = "#";
            lbID.Visible = false;
            // 
            // lbIDValue
            // 
            lbIDValue.AutoSize = true;
            lbIDValue.ForeColor = Color.Red;
            lbIDValue.Location = new Point(32, 195);
            lbIDValue.Name = "lbIDValue";
            lbIDValue.Size = new Size(0, 20);
            lbIDValue.TabIndex = 137;
            lbIDValue.Visible = false;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 900);
            Controls.Add(lbIDValue);
            Controls.Add(lbID);
            Controls.Add(lbSellerValue);
            Controls.Add(lbSeller);
            Controls.Add(rbOffline);
            Controls.Add(rbOnline);
            Controls.Add(lbTotalCost);
            Controls.Add(label12);
            Controls.Add(lbunitPrice);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(cboProduct);
            Controls.Add(label5);
            Controls.Add(numUD);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(lbTotal);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(cboCategory);
            Controls.Add(btnDelete);
            Controls.Add(dgvOrderDetails);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lbPhone);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            Controls.Add(tbCustomerName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddOrder";
            Load += AddOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private DataGridView dgvOrderDetails;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private Label label8;
        private Label lbPhone;
        private TextBox tbPhone;
        private Label label4;
        private TextBox tbCustomerName;
        private Label label2;
        private Panel panel1;
        private ComboBox cboCategory;
        private Label label7;
        private Label lbTotal;
        private Label label11;
        private Button btnDelete;
        private Button button2;
        private LinkLabel linkLabel1;
        private NumericUpDown numUD;
        private Label label5;
        private ComboBox cboProduct;
        private Label label3;
        private Label lbunitPrice;
        private Label label9;
        private Label lbTotalCost;
        private Label label12;
        private RadioButton rbOnline;
        private RadioButton rbOffline;
        private Label lbSeller;
        private Label lbSellerValue;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn PayMethod;
        private Label lbID;
        private Label lbIDValue;
    }
}