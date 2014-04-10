using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSite
{
    public class UserDB
    {
        String ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void RegUser(String email, String password, String firstName, String lastName, String phoneNumber)
        {
            if(!UserEmailExists(email))
            {
                using(SqlConnection _conn = new SqlConnection(ConnectionString))
                using(SqlCommand _cmd = new SqlCommand("dbo.Usp_RegisterUser", _conn))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.Add(new SqlParameter("@Type", "User"));
                    _cmd.Parameters.Add(new SqlParameter("@Email", email));
                    _cmd.Parameters.Add(new SqlParameter("@Password", password));
                    _cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
                    _cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
                    _cmd.Parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber));

                    _conn.Open();
                    _cmd.ExecuteNonQuery();
                    _conn.Close();
                }
            }
            else
            {
            }
        }

        public Boolean UserEmailExists(String email)
        {
            using (SqlConnection _conn = new SqlConnection(ConnectionString))
            using (SqlCommand _cmd = new SqlCommand("dbo.Usp_SelectUserEmail", _conn))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.Add(new SqlParameter("@Email", email));

                SqlParameter emailCount = new SqlParameter("@EmailCount", SqlDbType.Int);
                emailCount.Direction = ParameterDirection.Output;

                _cmd.Parameters.Add(emailCount);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _conn.Close();

                if (Convert.ToInt32(emailCount.Value) == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}