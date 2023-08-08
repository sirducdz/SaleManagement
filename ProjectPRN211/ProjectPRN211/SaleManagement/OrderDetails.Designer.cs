namespace SaleManagement
{
    partial class OrderDetails
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
            panel1 = new Panel();
            dgvOrderDetails = new DataGridView();
            label2 = new Label();
            lbOrder_id = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 900);
            panel1.TabIndex = 0;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.BackgroundColor = Color.White;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(422, 162);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(923, 474);
            dgvOrderDetails.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(636, 59);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 46;
            label2.Text = "Details of Order";
            // 
            // lbOrder_id
            // 
            lbOrder_id.AutoSize = true;
            lbOrder_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrder_id.ForeColor = Color.FromArgb(255, 128, 128);
            lbOrder_id.Location = new Point(868, 64);
            lbOrder_id.Name = "lbOrder_id";
            lbOrder_id.Size = new Size(184, 31);
            lbOrder_id.TabIndex = 48;
            lbOrder_id.Text = "Details of Order";
            lbOrder_id.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(422, 692);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 28);
            linkLabel1.TabIndex = 56;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quay lại";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 900);
            Controls.Add(linkLabel1);
            Controls.Add(lbOrder_id);
            Controls.Add(dgvOrderDetails);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "OrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetails";
            Load += OrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvOrderDetails;
        private Label label2;
        private Label lbOrder_id;
        private LinkLabel linkLabel1;
    }
}