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
    public partial class OrderDetails : Form
    {
        OrderDAO od = new OrderDAO();
        public OrderDetails()
        {
            InitializeComponent();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manage_Order mo = new Manage_Order();

            mo.Show();
            this.Close();
        }

        private void displayInDgv(IEnumerable<OrderDetail> list)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("Order ID", typeof(int));
            dataTable.Columns.Add("Product ID", typeof(int));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Total Cost", typeof(int));

            foreach (var item in list)
            {
                DataRow row = dataTable.NewRow();
                row["Order ID"] = item.Order_id;
                row["Product ID"] = item.Product_id;
                row["Price"] = item.Price;
                row["Quantity"] = item.Quantity;
                row["Total Cost"] = item.Total;
                dataTable.Rows.Add(row);
            }
            dgvOrderDetails.DataSource = dataTable;
            dgvOrderDetails.AllowUserToAddRows = false;
        }



        private void OrderDetails_Load(object sender, EventArgs e)
        {
            var list = od.getAllOrderDetail(OrderDetail.OrderID);
            lbOrder_id.Text = OrderDetail.OrderID.ToString();
            displayInDgv(list);


        }
    }
}
