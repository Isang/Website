using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class registercabin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowVillages();
                ShowRooms();
                ShowBeds();
            }
        }

        private void ShowVillages()
        {
            ListItem itmDefault = new ListItem("- Village -");

            ddlVillage.Items.Insert(0, itmDefault);
        }

        private void ShowRooms()
        {
            ListItem itmDefault = new ListItem("- Rooms -");

            ddlRooms.Items.Insert(0, itmDefault);
        }

        private void ShowBeds()
        {
            ListItem itmDefault = new ListItem("- Beds -");

            ddlBeds.Items.Insert(0, itmDefault);
        }


        protected void ddlVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlBeds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}