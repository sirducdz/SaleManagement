using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Model
{
	public class Order
	{
		public int Order_id { get; set; }

		public string CustomerName { get; set; }

		public int Seller_id { get; set; }

		public User Seller { get; set; }

		public int Total_cost { get; set; }
		public string Pay_method { get; set; }

		public string Phone { get; set; }

		public string Note { get; set; }

		public DateTime Sold_date { get; set; }

		public Order(string customerName, int seller_id, int total_cost, string pay_method, string phone)
		{
			CustomerName = customerName;
			Seller_id = seller_id;
			Total_cost = total_cost;
			Pay_method = pay_method;
			Phone = phone;
		}

		public Order(int order_id,string customerName,  string pay_method, string phone, string note,DateTime date)
		{
			Order_id = order_id;
			CustomerName = customerName;			
			Pay_method = pay_method;
			Phone = phone;
			Note = note;
			Sold_date= date;
		}

		public Order(int order_id, string customerName, int seller_id, int total_cost, string pay_method,
			string phone, string note, DateTime sold_date)
		{
			Order_id = order_id;
			CustomerName = customerName;
			Seller_id = seller_id;
			Total_cost = total_cost;
			Pay_method = pay_method;
			Phone = phone;
			Note = note;
			Sold_date = sold_date;
		}

		public Order(int order_id, string customerName, User seller, int total_cost, string pay_method, string phone, string note, DateTime sold_date)
		{
			Order_id = order_id;
			CustomerName = customerName;			
			Seller = seller;
			Total_cost = total_cost;
			Pay_method = pay_method;
			Phone = phone;
			Note = note;
			Sold_date = sold_date;
		}
	}
}
