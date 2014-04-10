using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace WebSite
{
    public class UserDB
    {
        String ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public Boolean ValidateEmail(String email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        public String RegUser(String email, String password, String firstName, String lastName, String phoneNumber)
        {
            if (EmailAlreadyRegistered(email))
                return "Error: This e-mail adress is already in use!";
            if (email == null || email == String.Empty || password == null || password == String.Empty || firstName == null || firstName == String.Empty || lastName == null || lastName == String.Empty || phoneNumber == null || phoneNumber == String.Empty)
                return "Error: One or more fields are empty!";
            if (!ValidateEmail(email))
                return "Error: Invalid e-mail adress!";

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

            return "User registration complete!";
        }

        public Boolean EmailAlreadyRegistered(String email)
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

        public DataTable GetUserData()
        {
            DataTable tbl = new DataTable();
            using (SqlConnection _conn = new SqlConnection(ConnectionString))
            using (SqlCommand _cmd = new SqlCommand("dbo.Usp_GetUsers", _conn))
            {
                SqlDataAdapter adptr = new SqlDataAdapter(_cmd);
                _cmd.CommandType = CommandType.StoredProcedure;
                adptr.Fill(tbl);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _conn.Close();
            }
            return tbl;
        }
    }
}