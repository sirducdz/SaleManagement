using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Model
{
	public class User
	{
		public static User u { get; set; }
		public int User_id { get; set; }
		public string FullName { get; set; }
		public string Phone{ get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Username { get; set; }

		public DateTime Dob { get; set; }

		public string Gender { get; set; }

		public string Status { get; set; }

		public DateTime Updated_date { get; set; }

		public Role Role { get; set; }

		public int Role_id { get; set; }


		public User(int user_id,string fullName, string phone, string email,DateTime dob, string gender,
			string status, int role_id)
		{
			User_id = user_id;
			FullName = fullName;
			Phone = phone;	
			Email = email;			
			Dob = dob;
			
			Gender = gender;
			Status = status;
			Role_id = role_id;
		}
		public User(int user_id, string fullName, string phone, string email, DateTime dob, string gender,
			string password, string status, int role_id)
		{
			User_id = user_id;
			FullName = fullName;
			Phone = phone;
			Email = email;
			Dob = dob;
			Password = password;
			Gender = gender;
			Status = status;
			Role_id = role_id;
		}


		public User(string fullName, string phone, string email, string password, string username,  DateTime dob, string gender,
			string status, int role_id)
		{
			FullName = fullName;
			Phone = phone;
			Email = email;
			Password = password;
			Username = username;
			Dob = dob;
			Gender = gender;
			Status = status;
			Role_id = role_id;
		}

		public User(int user_id, string username, string password, string fullName, string phone, string email,
			DateTime dob, string gender, string status,DateTime updated, Role role)
		{
			User_id = user_id;
			FullName = fullName;
			Phone = phone;
			Email = email;
			Password = password;
			Username = username;
			Dob = dob;
			Gender = gender;
			Updated_date = updated;
			Status = status;
			Role= role;
		}


	}
}
