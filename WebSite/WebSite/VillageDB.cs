using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSite
{
    public class VillageDB
    {
        String ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    
        public DataTable GetVillagesFromDB()
        {
            DataTable table = new DataTable();
            using(SqlConnection _conn = new SqlConnection(ConnectionString))
            {
                SqlCommand _cmd = new SqlCommand("dbo.Usp_GetVillages", _conn);
                _cmd.CommandType = CommandType.StoredProcedure;
                _conn.Open();
                _cmd.ExecuteNonQuery();

                SqlDataAdapter adr = new SqlDataAdapter(_cmd);
                adr.Fill(table);
                //slurp
            }
            return table;
           

        }
    }
}