using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace FoodDoAn.HttpCode
{
    public class DataProvider
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Rau;Integrated Security=True");
        public static void Connect()
        {
            if (ConnectionState.Broken == conn.State || ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
        }

        public static bool executeNonQuery(string sQuery,SqlParameter[] sParams)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                cmd.Parameters.AddRange(sParams);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //lấy về id tang tụ đông

        public static int executeScalar(string sQuery , SqlParameter[] sParams)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                cmd.Parameters.AddRange(sParams);
                cmd.ExecuteNonQuery();
                sQuery = "Select * @@identity";
                cmd =new SqlCommand(sQuery, conn);
                int id = (int)cmd.ExecuteScalar();
                conn.Close();
                return id;
            }
            catch (Exception err)
            {
                
                throw;
            }
            
        }

        public static DataTable getDataTable(string sQuery, SqlParameter[] sParams)
        {
            try
            {
                Connect();
                SqlDataAdapter da = new SqlDataAdapter(sQuery, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception err)
            {

                throw;
            }

        }




    }
}