using Microsoft.Data.SqlClient;
using SaleManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SaleManagement.DAO
{
	public class UserDAO : BaseDAL
	{
		//Using Singleton Pattern
		private static UserDAO instance = null;
		private static readonly object instanceLock = new object();
		public UserDAO() { }
		public static UserDAO Instance
		{
			get
			{
				lock (instanceLock)
				{
					if (instance == null)
					{
						instance = new UserDAO();
					}
					return instance;
				}
			}
		}

		public Role getRoleByID(int role_id = 0)
		{

			string sql = "select * from [Role] where role_id ='" + role_id + "'";
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				if (dr.Read())
				{
					return new Role(int.Parse(dr["role_id"].ToString()), dr["role_name"].ToString());
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
			return null;
		}

		public User getUserByID(int id)
		{

			string sql = "select * from [User] where user_id ='" + id + "'";
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				if (dr.Read())
				{
					Role role = getRoleByID(int.Parse(dr["role_id"].ToString()));
					User c = new User(int.Parse(dr["user_id"].ToString()), dr["username"].ToString(), dr["password"].ToString(),
						dr["fullName"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), DateTime.Parse(dr["dob"].ToString()),
						dr["gender"].ToString(), dr["status"].ToString(), DateTime.Parse(dr["updated_date"].ToString()), role);
					return c;
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
			return null;
		}

		public IEnumerable<User> getAllUsers(int user_id, string filter = "", string tbSearch = "")
		{

			var list = new List<User>();
			string sql = "select * from [User] where user_id !='" + user_id + "'";
			if (filter != "")
			{
				sql += " and status='" + filter + "'";
			}

			sql += " and fullName like '%" + tbSearch + "%'";

			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				while (dr.Read())
				{
					Role role = getRoleByID(int.Parse(dr["role_id"].ToString()));
					User c = new User(int.Parse(dr["user_id"].ToString()), dr["username"].ToString(), dr["password"].ToString(),
						dr["fullName"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), DateTime.Parse(dr["dob"].ToString()),
						dr["gender"].ToString(), dr["status"].ToString(), DateTime.Parse(dr["updated_date"].ToString()), role);

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

		public User getUserByLogin(string username, string password)
		{

			string sql = "select * from [User] where username ='" + username + "' and password ='" + password + "'";
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				while (dr.Read())
				{
					Role role = getRoleByID(int.Parse(dr["role_id"].ToString()));
					User c = new User(int.Parse(dr["user_id"].ToString()), dr["username"].ToString(), dr["password"].ToString(),
						dr["fullName"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), DateTime.Parse(dr["dob"].ToString()),
						dr["gender"].ToString(), dr["status"].ToString(), DateTime.Parse(dr["updated_date"].ToString()), role);

					return c;

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
			return null;
		}

		public Role getRoleByName(string role)
		{
			string sql = "select * from [Role] where role_name ='" + role + "'";
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				if (dr.Read())
				{
					return new Role(int.Parse(dr["role_id"].ToString()), dr["role_name"].ToString());
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
			return null;
		}

		public bool AddUser(User user)
		{
			try
			{

				User user2 = checkDuplicateUsername(user.Username);

				if (user2 != null)
				{
					return false;
				}
				else
				{
					string sqlInsert = "INSERT INTO [dbo].[User] ([username] ,[password],[fullName] ,[phone],[email] ,[dob],[gender] ,[status] ,[updated_date] ,[role_id]) " +
						"VALUES(@username, @password, @fullName, @phone," +
										"@email, @dob, @gender, @status,getdate(),@role_id)";
					var parameters = new List<SqlParameter>();
					parameters.Add(dataProvider.CreateParameter("@username", 50, user.Username, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@password", 50, user.Password, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@fullName", 50, user.FullName, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@phone", 50, user.Phone, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@email", 50, user.Email, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@dob", 50, user.Dob, DbType.DateTime));
					parameters.Add(dataProvider.CreateParameter("@gender", 50, user.Gender, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@status", 50, user.Status, DbType.String));
					parameters.Add(dataProvider.CreateParameter("@role_id", 4, user.Role_id, DbType.Int32));
					dataProvider.Insert(sqlInsert, CommandType.Text, parameters.ToArray());

					return true;
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally { CloseConnection(); }
		}

		private User checkDuplicateUsername(string username)
		{
			string sql = "select * from [User] where username ='" + username + "'";
			IDataReader dr = null;
			try
			{
				dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
				if (dr.Read())
				{
					Role role = getRoleByID(int.Parse(dr["role_id"].ToString()));
					User c = new User(int.Parse(dr["user_id"].ToString()), dr["username"].ToString(), dr["password"].ToString(),
						dr["fullName"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), DateTime.Parse(dr["dob"].ToString()),
						dr["gender"].ToString(), dr["status"].ToString(), DateTime.Parse(dr["updated_date"].ToString()), role);
					return c;
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
			return null;
		}

		public void updateUser(User user)
		{
			
			
				var parameters = new List<SqlParameter>();
				string sqlUpdate = "update [User] set  fullName = @fullName," +
			 " phone = @phone, email = @email,  dob = @dob,gender = @gender,status = @status,updated_date = getdate(),role_id = @role_id  where user_id = @user_id";

				if (user.Password != null)
				{
					sqlUpdate = "update [User] set password = @password, fullName = @fullName,phone = @phone, email = @email,  " +
					   "dob = @dob,gender = @gender,status = @status,updated_date = getdate(),role_id = @role_id  where user_id = @user_id";

					parameters.Add(dataProvider.CreateParameter("@password", 50, user.Password, DbType.String));
				}

				parameters.Add(dataProvider.CreateParameter("@fullName", 50, user.FullName, DbType.String));	
				parameters.Add(dataProvider.CreateParameter("@phone", 50, user.Phone, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@email", 50, user.Email, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@dob", 50, user.Dob, DbType.DateTime));
				parameters.Add(dataProvider.CreateParameter("@gender", 50, user.Gender, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@status", 50, user.Status, DbType.String));
				parameters.Add(dataProvider.CreateParameter("@role_id", 4, user.Role_id, DbType.Int32));
				parameters.Add(dataProvider.CreateParameter("@user_id", 4, user.User_id, DbType.Int32));
				dataProvider.Update(sqlUpdate, CommandType.Text, parameters.ToArray());

			
			

		}
	}
}
