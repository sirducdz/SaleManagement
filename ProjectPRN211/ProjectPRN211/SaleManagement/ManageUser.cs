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
    public partial class ManageUser : Form
    {

        UserDAO context = new UserDAO();
        public ManageUser()
        {
            InitializeComponent();
        }



        private void ManageUser_Load(object sender, EventArgs e)
        {
            cboProfile.Items.Clear();
            cboProfile.Items.Add(User.u.FullName);
            cboProfile.Items.Add("Edit profile");
            cboProfile.Items.Add("Logout");
            cboProfile.SelectedIndex = 0;


            cboFilter.Items.Clear();
            cboFilter.Items.Add("All");
            cboFilter.Items.Add("Active");
            cboFilter.Items.Add("Inactive");
            cboFilter.SelectedIndex = 0;

            lbHomeLink.ForeColor = Color.Teal;
            lbOrderLink.ForeColor = Color.Teal;
            lbUserLink.ForeColor = Color.Red;
            lbProductLink.ForeColor = Color.Teal;

            var list = context.getAllUsers(User.u.User_id);
            displayInDgv(list);


        }







        private void dgvUser_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                dgvUser.CurrentRow.Selected = true;
                lbUserID.Text = dgvUser.Rows[e.RowIndex].Cells["User ID"].Value.ToString();
                lbUserID.Visible = true;
                tbName.Text = dgvUser.Rows[e.RowIndex].Cells["FullName"].Value.ToString();

                tbPhone.Text = dgvUser.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                tbEmail.Text = dgvUser.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                if (dgvUser.Rows[e.RowIndex].Cells["Gender"].Value.ToString() == "male")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                dtpkDOB.Text = dgvUser.Rows[e.RowIndex].Cells["Dob"].Value.ToString();
                cboRole.Text = dgvUser.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                cboStatus.Text = dgvUser.Rows[e.RowIndex].Cells["Status"].Value.ToString();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbUserID.Text = "";
            lbUserID.Visible = false;
            tbName.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbEmail.Text = string.Empty;
            dtpkDOB.Text = DateTime.Now.ToString();
            cboRole.Text = string.Empty;
            cboStatus.Text = string.Empty;
        }






        private void cboProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mục được chọn
            string selectedItem = cboProfile.SelectedItem.ToString();

            if (selectedItem == "Edit profile")
            {
                UpdateProfile up = new UpdateProfile();
                this.Close();
                up.Show();
            }
            else if (selectedItem == "Logout")
            {
                User.u = null;
                LoginForm login = new LoginForm();
                this.Close();
                login.Show();
            }

        }

        private void addUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser addUser = new AddUser();
            this.Close();
            addUser.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userID = lbUserID.Text;
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            var dob = DateTime.Parse(dtpkDOB.Text);
            string gender = rbMale.Checked ? rbMale.Text : rbFemale.Text;
            string role = cboRole.Text;
            Role r = context.getRoleByName(role);
            string status = cboStatus.Text;

            User u = new User(int.Parse(userID), name, phone, email, dob, gender, status, r.Role_id);
            context.updateUser(u);
            ManageUser_Load(sender, e);
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = (string)cboFilter.SelectedItem;
            if (filter == "All") filter = "";
            else filter = filter.ToLower();
            var list = context.getAllUsers(User.u.User_id, filter, tbSearch.Text.Trim());
            displayInDgv(list);
        }

        private void displayInDgv(IEnumerable<User> list)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("User ID", typeof(string));
            dataTable.Columns.Add("FullName", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Dob", typeof(DateTime));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Role", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            foreach (var item in list)
            {
                DataRow row = dataTable.NewRow();
                row["User ID"] = item.User_id;
                row["FullName"] = item.FullName;
                row["Phone"] = item.Phone;
                row["Email"] = item.Email;
                row["Dob"] = DateTime.Parse(item.Dob.ToString());
                row["Gender"] = item.Gender;
                row["Role"] = item.Role.Role_name;
                row["Status"] = item.Status;
                dataTable.Rows.Add(row);
            }


            dgvUser.DataSource = dataTable;
            dgvUser.AllowUserToAddRows = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = (string)cboFilter.SelectedItem;
            if (filter == "All") filter = "";
            else filter = filter.ToLower();
            var list = context.getAllUsers(User.u.User_id, filter, tbSearch.Text.Trim());
            displayInDgv(list);
        }

        private void pictureHome_Click_1(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void lbHomeLink_Click_1(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void pictureProductLink_Click(object sender, EventArgs e)
        {
            ManageProduct mp = new ManageProduct();
            mp.Show();
            this.Close();
        }

        private void lbProductLink_Click(object sender, EventArgs e)
        {
            ManageProduct mp = new ManageProduct();
            mp.Show();
            this.Close();
        }

        private void pictureOrder_Click_1(object sender, EventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            mo.Show();
            this.Close();
        }

        private void lbOrderLink_Click_1(object sender, EventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            mo.Show();
            this.Close();
        }

        private void pictureLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
