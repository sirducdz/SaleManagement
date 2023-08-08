using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Model
{
	public class CategoryProduct
	{
		public int Cp_id { get; set; }

		public string Cp_name { get; set; }

		public List<Product> Products { get; set;}


		public CategoryProduct() { }

		public CategoryProduct(int cp_id, string cp_name)
		{
			Cp_id = cp_id;
			Cp_name = cp_name;
		}
	}
}
