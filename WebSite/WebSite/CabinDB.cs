using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSite
{
    public class CabinDB
    {
        String ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void RegisterCabin(int village_Id, int rooms, int beds, string size)
        {
            
            using (SqlConnection _conn = new SqlConnection(ConnectionString))
            {
                SqlCommand _cmd = new SqlCommand("dbo.Usp_RegisterCabin", _conn);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.Add(new SqlParameter("@Village_Id", village_Id));
                _cmd.Parameters.Add(new SqlParameter("@Rooms", rooms));
                _cmd.Parameters.Add(new SqlParameter("@Beds", beds));
                _cmd.Parameters.Add(new SqlParameter("@Size", size));
                _conn.Open();
                _cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetCabinData(int village_Id, int rooms, int beds)
        {
            DataTable tbl = new DataTable();

            using (SqlConnection _conn = new SqlConnection(ConnectionString))
            using (SqlCommand _cmd = new SqlCommand("dbo.Usp_GetCabins", _conn))
            {
                SqlDataAdapter adptr = new SqlDataAdapter(_cmd);
                _cmd.CommandType = CommandType.StoredProcedure;

                if (village_Id == 0)
                    _cmd.Parameters.Add(new SqlParameter("@Village_Id", DBNull.Value));
                else
                    _cmd.Parameters.Add(new SqlParameter("@Village_Id", village_Id));
                if (rooms == 0)
                    _cmd.Parameters.Add(new SqlParameter("@Rooms", DBNull.Value));
                else
                    _cmd.Parameters.Add(new SqlParameter("@Rooms", rooms));
                if (beds == 0)
                    _cmd.Parameters.Add(new SqlParameter("@Beds", DBNull.Value));
                else
                    _cmd.Parameters.Add(new SqlParameter("@Beds", beds));
               

                _conn.Open();
                _cmd.ExecuteNonQuery();
                adptr.Fill(tbl);
                _conn.Close();
            }

            return tbl;
        }

    }
}