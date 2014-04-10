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
        public void RegisterCabin(int village_Id, int rooms, int beds, string size)
        {
            String ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
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
    }
}