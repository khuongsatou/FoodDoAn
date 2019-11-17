using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDoAn.HttpCode
{
    public class Comment
    {
		private int _comment_id;
		private string _cus_email;
		private string _cus_name;
		private string _des;
		private int _status;
		private DateTime _created;
		private int _post_id;
		private int _rep_Id;

		public int Rep_Id
		{
			get { return _rep_Id; }
			set { _rep_Id = value; }
		}


		public int Post_Id
		{
			get { return _post_id; }
			set { _post_id = value; }
		}


		public DateTime Created
		{
			get { return _created; }
			set { _created = value; }
		}


		public int Status
		{
			get { return _status; }
			set { _status = value; }
		}


		public string Des
		{
			get { return _des; }
			set { _des = value; }
		}


		public string Cus_Email
		{
			get { return _cus_email; }
			set { _cus_email = value; }
		}

		
		public string Cus_Name
		{
			get { return _cus_name; }
			set { _cus_name = value; }
		}



		public int Comment_Id
		{
			get { return _comment_id; }
			set { _comment_id = value; }
		}

	}
}