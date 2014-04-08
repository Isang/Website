using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class register : System.Web.UI.Page
    {
        UserDB UserDB = new UserDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtRegEmail.Focus();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserDB.RegUser(txtRegEmail.Text, txtRegPassword.Text, txtRegFirstName.Text, txtRegLastName.Text, txtRegPhoneNumber.Text);
        }
    }
}