using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDoAn.HttpCode
{
    public class FoodType
    {
		private int _type_id;
		private string _type_name;
		private int _type_post;
		private string _type_img;
		private int _status;
		private string _username;
		private DateTime _modified;

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

		public string TypeImg
		{
			get { return _type_img; }
			set { _type_img = value; }
		}

		public int TypeID
		{
			get { return _type_id; }
			set { _type_id = value; }
		}

		

		public string TypeName
		{
			get { return _type_name; }
			set { _type_name = value; }
		}

		

		public int TypePost
		{
			get { return _type_post; }
			set { _type_post = value; }
		}


	}
}