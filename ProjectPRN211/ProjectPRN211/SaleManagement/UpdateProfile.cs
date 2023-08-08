using SaleManagement.DAO;
using SaleManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class UpdateProfile : Form
    {
        UserDAO ud = new UserDAO();
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void picButton_Click(object sender, EventArgs e)
        {
            tbPassword.ReadOnly = !tbPassword.ReadOnly;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            tbName.Text = User.u.FullName;
            tbPhone.Text = User.u.Phone;
            tbEmail.Text = User.u.Email;
            dtpkDOB.Text = User.u.Dob.ToString();
            if (User.u.Gender == "male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            tbRole.Text = User.u.Role.Role_name;
            tbPassword.Text = User.u.Password;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User u = new User(User.u.User_id, tbName.Text.Trim(), tbPhone.Text.Trim(), tbEmail.Text.Trim(), DateTime.Parse(dtpkDOB.Text),
                rbMale.Checked ? "male" : "female", tbPassword.Text.Trim(), "active", User.u.Role.Role_id);
            ud.updateUser(u);
            if (MessageBox.Show("Update thành công! Hãy đăng nhập lại!", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                User.u = null;
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}
