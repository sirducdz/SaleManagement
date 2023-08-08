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

    public partial class AddOrder : Form
    {


        OrderDAO od = new OrderDAO();
        ProductDAO pd = new ProductDAO();
        public AddOrder()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            var listCategory = pd.getAllCategoryProduct();
            cboCategory.Items.Clear();
            foreach (var item in listCategory)
            {
                cboCategory.Items.Add(item.Cp_name);
            }
            numUD.Minimum = 1;
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.ReadOnly = true;
        }

        static int index = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(numUD.Value.ToString());
            Product p = pd.getProductByName(cboProduct.Text);
            int product_id = p.Product_id;

            bool flag = false;
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) == product_id)
                {
                    flag = true;
                    if (p.Quantity >= (int.Parse(row.Cells[5].Value.ToString()) + quantity))
                    {
                        row.Cells[5].Value = int.Parse(row.Cells[5].Value.ToString()) + quantity;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng " + cboProduct.Text + " còn lại trong kho không đủ");
                    }
                    break;
                }


            }


            if (!flag)
            {
                if (p.Quantity < quantity)
                {
                    MessageBox.Show("Số lượng " + cboProduct.Text + " còn lại trong kho không đủ");
                }
                else
                {
                    string customer_name = tbCustomerName.Text;
                    string phone = tbPhone.Text;
                    string category = cboCategory.Text;
                    int unitprice = int.Parse(lbunitPrice.Text);
                    int total = int.Parse(lbTotal.Text);
                    string pay_method = rbOnline.Checked ? "online" : "offline";
                    OrderDetail orderDetail = new OrderDetail(product_id, unitprice, quantity, total);
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvOrderDetails);
                    row.Cells[0].Value = index.ToString();
                    row.Cells[1].Value = product_id;
                    row.Cells[2].Value = pd.getProductByID(product_id).Product_name;
                    row.Cells[3].Value = category;
                    row.Cells[4].Value = unitprice;
                    row.Cells[5].Value = quantity;
                    row.Cells[6].Value = total;
                    row.Cells[7].Value = pay_method;

                    lbSellerValue.Text = User.u.FullName;
                    dgvOrderDetails.Rows.Add(row);
                    tbCustomerName.ReadOnly = true;
                    tbPhone.ReadOnly = true;


                    int total_cost = int.Parse(lbTotalCost.Text) + total;
                    lbTotalCost.Text = (total_cost).ToString();
                    index++;
                }
            }

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manage_Order mo = new Manage_Order();
            mo.ShowDialog();
            this.Hide();
        }


        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProduct.Items.Clear();
            if (cboProduct.Text != "")
            {
                cboProduct.Text = string.Empty;
            }
            numUD.Value = 1;
            lbTotal.Text = "0";
            lbunitPrice.Text = "0";
            int cp_id = pd.getCategoryByName(cboCategory.Text).Cp_id;
            var list = pd.GetProductsByCategory(cp_id);
            foreach (var item in list)
            {
                cboProduct.Items.Add(item.Product_name);
            }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = pd.getProductByName(cboProduct.Text);
            int product_id = p.Product_id;
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) == product_id)
                {
                    if (row.Cells[7].Value.ToString() == "online")
                    {
                        rbOnline.Checked = true;
                    }
                    else
                    {
                        rbOffline.Checked = true;
                    }
                    break;
                }
            }

            lbunitPrice.Text = p.Price.ToString();
            int rs = int.Parse(lbunitPrice.Text) * int.Parse(numUD.Value.ToString());
            lbTotal.Text = rs.ToString();
            btnUpdate.Visible = false;
        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            int rs = int.Parse(lbunitPrice.Text) * int.Parse(numUD.Value.ToString());
            lbTotal.Text = rs.ToString();

        }

        private void numUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số nguyên", "Thông báo");
            }

        }


        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvOrderDetails.CurrentRow.Selected = true;
                lbIDValue.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                lbID.Visible = true;
                lbIDValue.Visible = true;
                cboCategory.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                cboProduct.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                numUD.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                lbunitPrice.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                lbTotal.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                if (dgvOrderDetails.Rows[e.RowIndex].Cells["PayMethod"].Value.ToString() == "online")
                {
                    rbOnline.Checked = true;
                }
                else
                {
                    rbOffline.Checked = true;
                }
                btnUpdate.Visible = true;
                tbCustomerName.ReadOnly = false;
                tbPhone.ReadOnly = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lbIDValue.Text);
            string customer_name = tbCustomerName.Text;
            string phone = tbPhone.Text;
            int product_id = pd.getProductByName(cboProduct.Text).Product_id;
            string category = cboCategory.Text;
            int unitprice = int.Parse(lbunitPrice.Text);
            int quantity = int.Parse(numUD.Value.ToString());
            int total = int.Parse(lbTotal.Text);
            string pay_method = rbOnline.Checked ? "online" : "offline";

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) == ID)
                {
                    // Cập nhật giá trị của các ô trong hàng tương ứng bằng các giá trị đã nhập từ các trường nhập liệu
                    row.Cells[1].Value = product_id;
                    row.Cells[2].Value = pd.getProductByID(product_id).Product_name;
                    row.Cells[3].Value = category;
                    row.Cells[4].Value = unitprice;
                    row.Cells[5].Value = quantity;
                    row.Cells[6].Value = total;
                    row.Cells[7].Value = pay_method;

                    // Thoát khỏi vòng lặp nếu tìm thấy hàng tương ứng
                    break;
                }
            }

            int totalMoney = 0;
            if (dgvOrderDetails.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    string cellValue = row.Cells[6].Value.ToString();
                    if (int.TryParse(cellValue, out int cellIntValue))
                    {
                        totalMoney += cellIntValue;
                    }
                }
                lbTotalCost.Text = totalMoney.ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lbIDValue.Text);
            if (dgvOrderDetails.Rows.Count > 0)
            {
                int tmp = -1;
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) == ID)
                    {
                        tmp = int.Parse(row.Cells[0].Value.ToString()) + 1;
                        dgvOrderDetails.Rows.Remove(row);
                        pd.updateQuantity(int.Parse(row.Cells[1].Value.ToString()), int.Parse(row.Cells[5].Value.ToString()));
                        // Thoát khỏi vòng lặp nếu tìm thấy hàng tương ứng
                        break;
                    }
                }
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    if (int.Parse(row.Cells[0].Value.ToString()) == tmp)
                    {
                        row.Cells["ID"].Value = tmp - 1;
                        tmp++;
                    }
                }


                int totalMoney = 0;
                if (dgvOrderDetails.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                    {
                        string cellValue = row.Cells[6].Value.ToString();
                        if (int.TryParse(cellValue, out int cellIntValue))
                        {
                            totalMoney += cellIntValue;
                        }
                    }
                    lbTotalCost.Text = totalMoney.ToString();
                }
            }

            index = dgvOrderDetails.Rows.Count;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customer_name = tbCustomerName.Text;
            string phone = tbPhone.Text;
            string pay_method = rbOnline.Checked ? "online" : "offline";
            int total_cost = int.Parse(lbTotalCost.Text);

            Order order = new Order(customer_name, User.u.User_id, total_cost, pay_method, phone);
            od.addNewOrder(order);

            int order_id = od.getListOrderID();
            if (dgvOrderDetails.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    pd.updateQuantity(int.Parse(row.Cells["ProductID"].Value.ToString()), int.Parse(row.Cells["Quantity"].Value.ToString()) * -1);
                    OrderDetail orderDetail = new OrderDetail(order_id, int.Parse(row.Cells["ProductID"].Value.ToString()),
                        int.Parse(row.Cells["UnitPrice"].Value.ToString()), int.Parse(row.Cells["Quantity"].Value.ToString()),
                        int.Parse(row.Cells["Total"].Value.ToString()));

                    od.addOrderDetail(orderDetail);
                }
            }
            if (MessageBox.Show("Thêm order thành công. Quay lại để xem cập nhật?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Manage_Order mo = new Manage_Order();
                mo.Show();
                this.Close();
            }
            else
            {
                dgvOrderDetails.Rows.Clear();
            }
        }
    }
}
