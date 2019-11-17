using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace FoodDoAn.HttpCode
{
    public class Member
    {
		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		private string _pass;

		public string Pass
		{
			get { return _pass; }
			set { _pass = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _phone;

		public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}

		private int _role;

		public int Role
		{
			get { return _role; }
			set { _role = value; }
		}

		public Member(string _userName, string _pass, string _name, string _phone,int _role)
		{
			this._userName = _userName;
			this._pass = _pass;
			this._name = _name;
			this._phone = _phone;
			this._role = _role;
		}

		public bool addMember()
		{
			string sQuery = "INSERT INTO [dbo].[member] ([username] ,[pass] ,[name] ,[phone] ,[role]) VALUES (@username ,@pass ,@name ,@phone ,@role)";
			SqlParameter[] sqlParams =
			{ 
				new SqlParameter("@username", SqlDbType.VarChar, 50){Value = this.UserName }, 
				new SqlParameter("@pass", SqlDbType.VarChar, 255){Value = StringProc.MD5Hash(this.Pass) }, 
				new SqlParameter("@name", SqlDbType.VarChar, 200){Value = this.Name }, 
				new SqlParameter("@phone", SqlDbType.VarChar, 20){Value = this.Phone }, 
				new SqlParameter("@role", SqlDbType.Int){Value = this.Role }
			};
			return DataProvider.executeNonQuery(sQuery, sqlParams);
			
		}

	}
}