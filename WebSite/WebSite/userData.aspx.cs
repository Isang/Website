using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class userData : System.Web.UI.Page
    {
        UserDB objUserData = new UserDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            grdUserData.DataSource = objUserData.GetUserData();
            grdUserData.DataBind();
        }
    }
}