using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SaleManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.DAO
{
	public class BaseDAL
	{

		public DataProvider dataProvider { get; set; } = null;
		public SqlConnection connection = null;
		public BaseDAL()
		{
			var connectionString = GetConnectionString();

			dataProvider = new DataProvider(connectionString);
		}
		public string GetConnectionString()
		{
			IConfiguration config = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", true, true)
			.Build();
			return config["ConnectionStrings:DB"];

		}
		public void CloseConnection() => dataProvider.CloseConnection(connection);
	}

}
