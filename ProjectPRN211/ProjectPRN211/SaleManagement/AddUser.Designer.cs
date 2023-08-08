namespace SaleManagement
{
    partial class AddUser
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
            label1 = new Label();
            cboRole = new ComboBox();
            label9 = new Label();
            cboStatus = new ComboBox();
            label8 = new Label();
            rbMale = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            dtpkDOB = new DateTimePicker();
            label5 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbPhone = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            rbFemale = new RadioButton();
            label2 = new Label();
            tbPassword = new TextBox();
            label10 = new Label();
            tbUserName = new TextBox();
            btnAddUser = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 800);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(805, 22);
            label1.Name = "label1";
            label1.Size = new Size(148, 41);
            label1.TabIndex = 1;
            label1.Text = "Add User";
            label1.Click += label1_Click;
            // 
            // cboRole
            // 
            cboRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "admin", "staff" });
            cboRole.Location = new Point(963, 282);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(241, 31);
            cboRole.TabIndex = 116;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(481, 435);
            label9.Name = "label9";
            label9.Size = new Size(60, 23);
            label9.TabIndex = 115;
            label9.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "active", "inactive" });
            cboStatus.Location = new Point(552, 427);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(178, 31);
            cboStatus.TabIndex = 114;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(956, 256);
            label8.Name = "label8";
            label8.Size = new Size(45, 23);
            label8.TabIndex = 113;
            label8.Text = "Role";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rbMale.Location = new Point(575, 282);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(70, 27);
            rbMale.TabIndex = 111;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(496, 281);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 110;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(963, 185);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 109;
            label6.Text = "Date of birth";
            // 
            // dtpkDOB
            // 
            dtpkDOB.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtpkDOB.Location = new Point(963, 208);
            dtpkDOB.Name = "dtpkDOB";
            dtpkDOB.Size = new Size(250, 25);
            dtpkDOB.TabIndex = 108;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(489, 173);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 107;
            label5.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(489, 196);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(251, 30);
            tbEmail.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(970, 98);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 105;
            label4.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhone.Location = new Point(970, 121);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(251, 30);
            tbPhone.TabIndex = 104;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(496, 98);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 103;
            label3.Text = "FullName";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(496, 121);
            tbName.Name = "tbName";
            tbName.Size = new Size(251, 30);
            tbName.TabIndex = 102;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rbFemale.Location = new Point(656, 282);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(88, 27);
            rbFemale.TabIndex = 112;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(955, 335);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 120;
            label2.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(955, 358);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(251, 30);
            tbPassword.TabIndex = 119;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(481, 335);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 118;
            label10.Text = "Username";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserName.Location = new Point(481, 358);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(251, 30);
            tbUserName.TabIndex = 117;
            // 
            // btnAddUser
            // 
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.ForeColor = Color.Teal;
            btnAddUser.Location = new Point(805, 523);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(135, 57);
            btnAddUser.TabIndex = 121;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(805, 620);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 28);
            linkLabel1.TabIndex = 122;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quay lại";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(linkLabel1);
            Controls.Add(btnAddUser);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(label10);
            Controls.Add(tbUserName);
            Controls.Add(cboRole);
            Controls.Add(label9);
            Controls.Add(cboStatus);
            Controls.Add(label8);
            Controls.Add(rbMale);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpkDOB);
            Controls.Add(label5);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbPhone);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(rbFemale);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cboRole;
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
        private RadioButton rbFemale;
        private Label label2;
        private TextBox tbPassword;
        private Label label10;
        private TextBox tbUserName;
        private Button btnAddUser;
        private LinkLabel linkLabel1;
    }
}