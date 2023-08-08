using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Model
{
	public class Product
	{
		public int Product_id { get; set; }

		public string Product_name { get; set; }

		public int Quantity { get; set; }

		public int Price { get; set; }

		public DateTime Updated_date { get; set; }

		public int Cp_id { get; set; }	

		public CategoryProduct Category { get; set; }

		public Product(int product_id, string product_name)
		{
			Product_id = product_id;
			Product_name = product_name;
		}
		public Product(int product_id,string product_name, int quantity, int price, int cp_id)
		{
			Product_id = product_id;
			Product_name = product_name;
			Quantity = quantity;
			Price = price;
			Cp_id = cp_id;
		}

		public Product(string product_name, int quantity, int price,  int cp_id)
		{
			Product_name = product_name;
			Quantity = quantity;
			Price = price;		
			Cp_id = cp_id;
		}

		public Product(int product_id, string product_name, int quantity, int price, DateTime updated_date, CategoryProduct category)
		{
			Product_id = product_id;
			Product_name = product_name;
			Quantity = quantity;
			Price = price;
			Updated_date = updated_date;
			Category = category;
		}
	}
}
