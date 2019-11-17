using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDoAn.HttpCode
{
    public class Post
    {
		private int _post_id;
		private string _title;
		private string _short;
		private string _des;
		private string _img;
		private int _status;
		private string _username;
		private DateTime _modified;
		private DateTime _created;

		public DateTime Created
		{
			get { return _created; }
			set { _created = value; }
		}


		public DateTime Modified
		{
			get { return _modified; }
			set { _modified = value; }
		}


		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}


		public int Status
		{
			get { return _status; }
			set { _status = value; }
		}


		public string Img
		{
			get { return _img; }
			set { _img = value; }
		}


		public string Des
		{
			get { return _des; }
			set { _des = value; }
		}


		public string Short
		{
			get { return _short; }
			set { _short = value; }
		}


		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}


		public int Post_Id
		{
			get { return _post_id; }
			set { _post_id = value; }
		}

	}
}