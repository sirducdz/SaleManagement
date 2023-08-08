
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SaleManagement
{
    public partial class Home : Form
    {
        OrderDAO od = new OrderDAO();
        ProductDAO pd = new ProductDAO();
        public Home()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureLogout_Click(object sender, EventArgs e)
        {
            User.u = null;
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
        }

        private void lbLogoutLink_Click(object sender, EventArgs e)
        {
            User.u = null;
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
        }



        private void Home_Load(object sender, EventArgs e)
        {
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
            lbOrderLink.ForeColor = Color.Teal;
            lbHomeLink.ForeColor = Color.Red;
            cboProfile.Items.Clear();
            cboProfile.Items.Add(User.u.FullName);
            cboProfile.Items.Add("Edit profile");
            cboProfile.Items.Add("Logout");
            cboProfile.SelectedIndex = 0;

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).Day;

            DateTime dateFrom = new DateTime(year, month, 1);
            DateTime dateTo = DateTime.Now;

            from.Text = dateFrom.ToString();
            to.Text = dateTo.ToString();
            var listProduct = pd.getAllProduct(false);
            var listOrderDetail = od.getListOrderDetailByDate(dateFrom, dateTo);
            dgv.AllowUserToAddRows = false;
            int revenue = 0;
            foreach (var product in listProduct)
            {
                int totalSold = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = product.Product_id;
                row.Cells[1].Value = product.Product_name;
                row.Cells[2].Value = product.Price;
                foreach (var orderDetail in listOrderDetail)
                {
                    if (product.Product_id == orderDetail.Product_id)
                    {
                        totalSold += orderDetail.Quantity;
                    }
                }
                row.Cells[3].Value = product.Quantity + totalSold;
                row.Cells[4].Value = totalSold;
                row.Cells[5].Value = totalSold * product.Price;
                row.Cells[6].Value = product.Quantity;
                revenue += (totalSold * product.Price);
                dgv.Rows.Add(row);
            }
            totalRevenue.Text = revenue.ToString();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            User.u = null;
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
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

        private void pictureUser_Click_1(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            this.Close();
            mu.Show();
        }

        private void lbUserLink_Click_1(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            this.Close();
            mu.Show();
        }

        private void lbOrderLink_Click_1(object sender, EventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            this.Close();
            mo.Show();
        }

        private void pictureOrder_Click_1(object sender, EventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            this.Close();
            mo.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            DateTime dateFrom = DateTime.Parse(from.Text);
            DateTime dateTo = DateTime.Parse(to.Text);
            var listProduct = pd.getAllProduct(false);
            var listOrderDetail = od.getListOrderDetailByDate(dateFrom, dateTo);
            dgv.AllowUserToAddRows = false;
            int revenue = 0;
            foreach (var product in listProduct)
            {
                int totalSold = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = product.Product_id;
                row.Cells[1].Value = product.Product_name;
                row.Cells[2].Value = product.Price;
                foreach (var orderDetail in listOrderDetail)
                {
                    if (product.Product_id == orderDetail.Product_id)
                    {
                        totalSold += orderDetail.Quantity;
                    }
                }
                row.Cells[3].Value = product.Quantity + totalSold;
                row.Cells[4].Value = totalSold;
                row.Cells[5].Value = totalSold * product.Price;
                row.Cells[6].Value = product.Quantity;
                revenue += (totalSold * product.Price);
                dgv.Rows.Add(row);
            }
            totalRevenue.Text = revenue.ToString();
        }
    }
}
