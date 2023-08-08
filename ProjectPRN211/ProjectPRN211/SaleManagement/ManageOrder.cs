
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
using System.Xml.Linq;

namespace SaleManagement
{
    public partial class Manage_Order : Form
    {
        OrderDAO context = new OrderDAO();
        UserDAO ud = new UserDAO();

        public Manage_Order()
        {
            InitializeComponent();
        }



        private void Manage_Order_Load(object sender, EventArgs e)
        {
            cboProfile.Items.Clear();
            cboProfile.Items.Add(User.u.FullName);
            cboProfile.Items.Add("Edit profile");
            cboProfile.Items.Add("Logout");
            cboProfile.SelectedIndex = 0;
            cboSoldDate.SelectedIndex = 0;
            if (User.u.Role.Role_id == 1)
            {
                lbUserLink.Visible = true;
                pictureUser.Visible = true;
                lbUserLink.ForeColor = Color.Teal;
            }
            else
            {
                pictureUser.Visible = false;
                lbUserLink.Visible = false;
                lbHomeLink.Location = new Point(lbUserLink.Location.X, lbUserLink.Location.Y);
                pictureHome.Location = new Point(pictureUser.Location.X, pictureUser.Location.Y);
            }

            lbHomeLink.ForeColor = Color.Teal;
            lbOrderLink.ForeColor = Color.Red;
            lbProductLink.ForeColor = Color.Teal;

            detailLink.Visible = false;
            var list = context.getAllOrders(tbSearch.Text, cboSoldDate.Text);
            displayInDgv(list);
        }

        private void displayInDgv(IEnumerable<Order> list)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("Order ID", typeof(int));
            dataTable.Columns.Add("Customer Name", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Total Cost", typeof(int));
            dataTable.Columns.Add("Pay Method", typeof(string));
            dataTable.Columns.Add("Seller", typeof(string));
            dataTable.Columns.Add("Note", typeof(string));
            dataTable.Columns.Add("Sold Date", typeof(DateTime));

            foreach (var item in list)
            {
                DataRow row = dataTable.NewRow();
                row["Order ID"] = item.Order_id;
                row["Customer Name"] = item.CustomerName;
                row["Phone"] = item.Phone;
                row["Total Cost"] = item.Total_cost;
                row["Pay Method"] = item.Pay_method;
                row["Seller"] = item.Seller.FullName;
                row["Note"] = item.Note;
                row["Sold Date"] = item.Sold_date;
                dataTable.Rows.Add(row);
            }
            dgvOrder.DataSource = dataTable;
            dgvOrder.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbHomeLink_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            //this.Close();
            home.Show();
            this.Close();
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            //	this.Close();
            mu.Show();
            this.Close();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Close();
        }

        private void lbUserLink_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            //this.Close();
            mu.Show();
            this.Close();
        }

        private void lbLogoutLink_Click(object sender, EventArgs e)
        {
            User.u = null;
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void pictureLogout_Click(object sender, EventArgs e)
        {
            User.u = null;
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void pictureLogout_Click_1(object sender, EventArgs e)
        {
            User.u = null;
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void pictureUser_Click_1(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
            this.Close();
        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AddOrder ao = new AddOrder();
            //ao.Show();
            //this.Close();
            MessageBox.Show("Chức năng chưa được xử lí", "Alert");
        }

        private void lbProductLink_Click(object sender, EventArgs e)
        {
            ManageProduct mp = new ManageProduct();
            mp.Show();
            this.Close();
        }

        private void pictureProductLink_Click(object sender, EventArgs e)
        {
            ManageProduct mp = new ManageProduct();
            mp.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Order order = new Order(int.Parse(tbOrderID.Text), tbCustomerName.Text,
                rbOnline.Checked ? "online" : "offline", tbPhone.Text, tbNote.Text, DateTime.Parse(dtpkOrderDate.Text));
            context.updateOrder(order);
            MessageBox.Show("Cập nhật thành công!");
            Manage_Order_Load(sender, e);
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvOrder.CurrentRow.Selected = true;
                tbOrderID.Text = dgvOrder.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
                tbCustomerName.Text = dgvOrder.Rows[e.RowIndex].Cells["Customer Name"].Value.ToString();
                tbPhone.Text = dgvOrder.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                dtpkOrderDate.Text = dgvOrder.Rows[e.RowIndex].Cells["Sold Date"].Value.ToString();
                if (dgvOrder.Rows[e.RowIndex].Cells["Pay Method"].Value.ToString() == "online")
                {
                    rbOnline.Checked = true;
                }
                else
                {
                    rbOffline.Checked = true;
                }

                tbSeller.Text = dgvOrder.Rows[e.RowIndex].Cells["Seller"].Value.ToString();
                lbTotalCostOrder.Text = dgvOrder.Rows[e.RowIndex].Cells["Total Cost"].Value.ToString();
                tbNote.Text = dgvOrder.Rows[e.RowIndex].Cells["Note"].Value.ToString();

                detailLink.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang trong quá trình xử lí", "Alert");
            if (tbOrderID.Text.Length > 0)
            {
                int order_id = int.Parse(tbOrderID.Text);
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.removeFromOrderDetail(order_id);
                    context.removeFromOrder(order_id);
                    Manage_Order_Load(sender, e);
                    btnClear_Click(sender, e);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOrderID.Text = string.Empty;
            tbCustomerName.Text = string.Empty;
            tbPhone.Text = string.Empty;
            dtpkOrderDate.Text = DateTime.Now.ToString();

            rbOnline.Checked = false;
            rbOffline.Checked = false;
            tbSeller.Text = string.Empty;
            lbTotalCostOrder.Text = "0";
            tbNote.Text = string.Empty;
            detailLink.Visible = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var list = context.getAllOrders(tbSearch.Text.Trim(), cboSoldDate.Text);
            displayInDgv(list);
        }

        private void cboSoldDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = context.getAllOrders(tbSearch.Text.Trim(), cboSoldDate.Text);
            displayInDgv(list);
        }

        private void detailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrderDetail.OrderID = int.Parse(tbOrderID.Text);
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.ShowDialog();
            this.Hide();
        }

        private void cboProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
