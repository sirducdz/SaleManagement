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
    public partial class AddUser : Form
    {
        UserDAO context = new UserDAO();
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            var dob = DateTime.Parse(dtpkDOB.Text);
            string gender = rbMale.Checked ? "male" : "female";
            string role = cboRole.Text;
            Role r = context.getRoleByName(role.ToLower());
            string status = cboStatus.Text;
            string username = tbUserName.Text;
            string password = tbPassword.Text;


            User user = new User(name, phone, email, password, username, dob, gender, status, r.Role_id);
            bool rs = context.AddUser(user);
            if (!rs) MessageBox.Show("Username đã tồn tại. Hãy tạo username khác");
            else
            {
                MessageBox.Show("Thêm thành công. Click quay lại để xem cập nhật!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
