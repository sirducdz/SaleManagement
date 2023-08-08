using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Model
{
	public class Role
	{
		public int Role_id { get; set; }
		public string Role_name { get; set; }

		public List<User> Users { get; set; }
		public Role() { }

		public Role(int role_id, string role_name)
		{
			Role_id = role_id;
			Role_name = role_name;
		}
	}
}
