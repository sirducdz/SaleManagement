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
    public partial class ManageProduct : Form
    {
        ProductDAO pd = new ProductDAO();
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void lbUserLink_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
            this.Close();
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
            this.Close();
        }

        private void lbHomeLink_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void lbOrderLink_Click(object sender, EventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            mo.Show();
            this.Close();
        }

        private void pictureOrder_Click(object sender, EventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            mo.Show();
            this.Close();
        }

        private void pictureLogout_Click(object sender, EventArgs e)
        {
            User.u = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
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

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            cboProfile.Items.Clear();
            cboProfile.Items.Add(User.u.FullName);
            cboProfile.Items.Add("Edit profile");
            cboProfile.Items.Add("Logout");
            cboProfile.SelectedIndex = 0;

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
            lbHomeLink.ForeColor = Color.Teal;
            lbProductLink.ForeColor = Color.Red;

            cboCategoryProduct.Items.Clear();
            var listCategory = pd.getAllCategoryProduct();
            foreach (var item in listCategory)
            {
                cboCategoryProduct.Items.Add(item.Cp_name);
            }

            cboSort.SelectedIndex = 0;

            var listProduct = pd.getAllProduct(false);
            displayInDgv(listProduct);

        }

        private void displayInDgv(IEnumerable<Product> list)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("Product ID", typeof(string));
            dataTable.Columns.Add("Product Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            dataTable.Columns.Add("Unit Price", typeof(string));
            dataTable.Columns.Add("Date of import", typeof(DateTime));
            dataTable.Columns.Add("Category", typeof(string));


            foreach (var item in list)
            {
                DataRow row = dataTable.NewRow();
                row["Product ID"] = item.Product_id;
                row["Product Name"] = item.Product_name;
                row["Quantity"] = item.Quantity;
                row["Unit Price"] = item.Price;
                row["Date of import"] = DateTime.Parse(item.Updated_date.ToString());
                row["Category"] = item.Category.Cp_name;

                dataTable.Rows.Add(row);
            }
            dgvProduct.DataSource = dataTable;
            dgvProduct.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                dgvProduct.CurrentRow.Selected = true;
                lbProductID.Visible = true;
                lbValueProductID.Text = dgvProduct.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
                lbValueProductID.Visible = true;
                tbProductName.Text = dgvProduct.Rows[e.RowIndex].Cells["Product Name"].Value.ToString();
                tbQuantity.Text = dgvProduct.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                tbUnitPrice.Text = dgvProduct.Rows[e.RowIndex].Cells["Unit Price"].Value.ToString();
                cboCategoryProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["Category"].Value.ToString();

            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang được xử lí");
            string name = tbProductName.Text;
            int quantity = int.Parse(tbQuantity.Text);
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng không được <= 0");
            }
            else
            {
                int price = int.Parse(tbUnitPrice.Text);
                int cp_id = pd.getCategoryByName(cboCategoryProduct.Text).Cp_id;
                Product p = new Product(name, quantity, price, cp_id);
                pd.AddProduct(p);
                btnClear_Click(sender, e);
                ManageProduct_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (lbValueProductID.Text != "")
            {
                int product_id = int.Parse(lbValueProductID.Text);
                string name = tbProductName.Text;
                int quantity = int.Parse(tbQuantity.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Số lượng không được <= 0");
                }
                else
                {
                    int price = int.Parse(tbUnitPrice.Text);
                    int cp_id = pd.getCategoryByName(cboCategoryProduct.Text).Cp_id;

                    Product p = new Product(product_id, name, quantity, price, cp_id);
                    pd.UpdateProduct(p);
                    ManageProduct_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
            }

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            lbProductID.Visible = false;
            lbValueProductID.Text = string.Empty;
            lbValueProductID.Visible = false;
            tbProductName.Text = string.Empty;
            tbQuantity.Text = string.Empty;
            tbUnitPrice.Text = string.Empty;
            cboCategoryProduct.Text = string.Empty;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var list = pd.filter(tbSearch.Text.Trim(), cboSort.Text == "None" ? "" : cboSort.Text);
            displayInDgv(list);
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = pd.filter(tbSearch.Text.Trim(), cboSort.Text);
            displayInDgv(list);
        }

        private void button_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (lbValueProductID.Text != "")
            {

                int product_id = int.Parse(lbValueProductID.Text);
                Product product = pd.getProductByIDInorderDetail(product_id);
                if (product == null)
                    pd.removeProductByProductID(product_id);
                else
                    MessageBox.Show("Không thể xóa sản phẩm đã tồn tại trong đơn hàng!");
                //MessageBox.Show("chức năng đang xử lý", "Alert");
                //MessageBox.Show(Convert.ToString(product_id));
                ManageProduct_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
            }
        }
    }
}
