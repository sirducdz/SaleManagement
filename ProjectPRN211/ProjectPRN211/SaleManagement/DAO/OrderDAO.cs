using Microsoft.Data.SqlClient;
using SaleManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaleManagement.DAO
{
	public class OrderDAO : BaseDAL
	{
		//Using Singleton Pattern
		private static OrderDAO instance = null;
		private static readonly object instanceLock = new object();
		public OrderDAO() { }
		public static OrderDAO Instance
		{
			get
			{
				lock (instanceLock)
				{
					if (instance == null)
					{
						instance = new OrderDAO();
					}
					return instance;
				}
			}
		}

		public IEnumerable<Order> getAllOrders(string search = "", string sold_date = "")
		{
			var list = new List<Order>();
			string sql = "select * from [Order] ";
			if (search != "") sql += " where phone like'%" + search + "%'";
			if (sold_date != "None")
			{
				if (sold_date == "Oldest")
				{
					sql += " order by sold_date desc";
				}
				else
				{
					sql += " order by sold_date asc";
				}
			}
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				while (dr.Read())
				{
					User u = new UserDAO().getUserByID(int.Parse(dr["seller_id"].ToString()));
					Order c = new Order(int.Parse(dr["order_id"].ToString()), dr["customer_name"].ToString(), u, int.Parse(dr["total_cost"].ToString()),
						dr["pay_method"].ToString(), dr["phone"].ToString(), dr["note"].ToString(), DateTime.Parse(dr["sold_date"].ToString()));

					list.Add(c);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				dr.Close();
				CloseConnection();
			}
			return list;
		}

		public void addOrderDetail(OrderDetail orderDetail)
		{
			try
			{
				string sqlInsert = "insert into  [Order_Detail] values(@order_id,@product_id, @price, @quantity, @total_cost)";
				var parameters = new List<SqlParameter>();
				parameters.Add(dataProvider.CreateParameter("@order_id", 4, orderDetail.Order_id, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@product_id", 4, orderDetail.Product_id, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@price", 4, orderDetail.Price, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@quantity", 4, orderDetail.Quantity, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@total_cost", 4, orderDetail.Total, DbType.Int32));

				dataProvider.Insert(sqlInsert, CommandType.Text, parameters.ToArray());


			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally { CloseConnection(); }
		}

		public void addNewOrder(Order order)
		{

			try
			{
				string sqlInsert = "insert into  [Order] values(@customer_name, @seller_id, @total_cost, @pay_method," +
					" @phone, '', getdate())";
				var parameters = new List<SqlParameter>();
				parameters.Add(dataProvider.CreateParameter("@customer_name", 50, order.CustomerName, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@seller_id", 4, order.Seller_id, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@total_cost", 4, order.Total_cost, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@pay_method", 50, order.Pay_method, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@phone", 50, order.Phone, DbType.String));

				dataProvider.Insert(sqlInsert, CommandType.Text, parameters.ToArray());

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			//finally { CloseConnection(); }
		}

		public int getListOrderID()
		{

			string sql = "SELECT IDENT_CURRENT('Order') as LastIndex ";

			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				if (dr.Read())
				{
					return int.Parse(dr["LastIndex"].ToString());
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				dr.Close();
				CloseConnection();
			}
			return -1;
		}

		public void updateOrder(Order order)
		{
			try
			{
				string sqlUpdate = "update [Order] set  customer_name = @customer_name," +
				 " pay_method = @pay_method, phone = @phone, note = @note,sold_date = @sold_date  where order_id = @order_id";
				var parameters = new List<SqlParameter>();
				parameters.Add(dataProvider.CreateParameter("@customer_name", 50, order.CustomerName, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@pay_method", 50, order.Pay_method, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@phone", 50, order.Phone, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@sold_date", 50, order.Sold_date, DbType.DateTime));
				parameters.Add(dataProvider.CreateParameter("@note", 50, order.Note, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@order_id", 4, order.Order_id, DbType.Int32));
				dataProvider.Update(sqlUpdate, CommandType.Text, parameters.ToArray());
			}
			catch (Exception ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}

		public void removeFromOrderDetail(int order_id)
		{
			try
			{
				string sql = "DELETE FROM [Order_Detail] WHERE order_id = @order_id;";
				var parameters = new List<SqlParameter>();
				parameters.Add(dataProvider.CreateParameter("@order_id", 50, order_id, DbType.Int32));
				dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
			}
			catch (Exception ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}

		internal void removeFromOrder(int order_id)
		{
			try
			{
				string sql = "DELETE FROM [Order] WHERE order_id = @order_id;";
				var parameters = new List<SqlParameter>();
				parameters.Add(dataProvider.CreateParameter("@order_id", 50, order_id, DbType.Int32));
				dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
			}
			catch (Exception ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}

		public IEnumerable<OrderDetail> getAllOrderDetail(int order_id)
		{
			var list = new List<OrderDetail>();
			string sql = "select * from [Order_Detail] where order_id ='" + order_id + "'";

			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				while (dr.Read())
				{

					OrderDetail c = new OrderDetail(int.Parse(dr["order_id"].ToString()), int.Parse(dr["product_id"].ToString()),
						int.Parse(dr["price"].ToString()), int.Parse(dr["quantity"].ToString()), int.Parse(dr["total_cost"].ToString()));

					list.Add(c);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				dr.Close();
				CloseConnection();
			}
			return list;
		}

		public int getTotalProductSold(int product_id)
		{
			string sql = "select isnull(sum(quantity),0) as Total from Order_Detail where product_id ='" + product_id + "'";
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				if (dr.Read())
				{

					return int.Parse(dr["Total"].ToString());
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				dr.Close();
				CloseConnection();
			}
			return 0;
		}

		public IEnumerable<OrderDetail> getListOrderDetailByDate(DateTime dateFrom, DateTime dateTo)
		{
			
			var list = new List<OrderDetail>();
			string sql = "select * from Order_Detail where order_id = any (select order_id from [Order] " +
				"where sold_date between '" + dateFrom + "' and '" + dateTo + "')";
			IDataReader dr = null;
			try
			{
				
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
			
				while (dr.Read())
				{
					OrderDetail order_detail = new OrderDetail(int.Parse(dr["product_id"].ToString()),
						int.Parse(dr["price"].ToString()), int.Parse(dr["quantity"].ToString()), int.Parse(dr["total_cost"].ToString()));
					list.Add(order_detail);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				dr.Close();
				CloseConnection();
			}

			return list;
		}
	}
}
