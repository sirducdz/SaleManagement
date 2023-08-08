using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Model
{
	public class OrderDetail
	{
		public static int OrderID { get; set; }
		public int Od_id { get; set; }
		public int Order_id { get; set; }

		public Order Order { get; set; }

		public int Product_id { get; set; }

		public Product Product { get; set; }

		public int Price { get; set; }
		public int Quantity { get; set; }

		public int Total { get; set; }

		public OrderDetail(int product_id, int price, int quantity, int total)
		{
			Product_id = product_id;
			Price = price;
			Quantity = quantity;
			Total = total;
		}

		public OrderDetail(int order_id, int product_id, int price, int quantity, int total)
		{
			Order_id = order_id;
			Product_id = product_id;
			Price = price;
			Quantity = quantity;
			Total = total;
		}


	}
}
