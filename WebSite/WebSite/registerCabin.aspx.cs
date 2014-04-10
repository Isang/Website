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
        VillageDB villageDB = new VillageDB();
        CabinDB cabinDB = new CabinDB();

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

            ddlVillage.DataSource = villageDB.GetVillagesFromDB();
            ddlVillage.DataBind();
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

        protected void btnRegisterCabin_Click(object sender, EventArgs e)
        {
            cabinDB.RegisterCabin(Convert.ToInt32(ddlVillage.SelectedValue), Convert.ToInt32(ddlRooms.SelectedValue), Convert.ToInt32(ddlBeds.SelectedValue), txtCabinSize.Text);
        }
    }
}