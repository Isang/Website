using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class searchCabin : System.Web.UI.Page
    {
        CabinDB cabinDB = new CabinDB();
        VillageDB villageDB = new VillageDB();
        //registercabin rgstCabin = new registercabin();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowVillages();
                ShowRooms();
                ShowBeds();
                SortCabin();
            }
        }

        protected void ddlVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortCabin();
        }

        protected void ddlRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortCabin();
        }

        protected void ddlBeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortCabin();
        }
        protected void SortCabin()
        {
            grdUserData.DataSource = cabinDB.GetCabinData(Convert.ToInt32(ddlVillage.SelectedValue), Convert.ToInt32(ddlRooms.SelectedValue), Convert.ToInt32(ddlBeds.SelectedValue));
            grdUserData.DataBind();
            
        }

        private void ShowVillages()
        {
            ListItem itmDefault = new ListItem("- Village -", "0");

            ddlVillage.DataSource = villageDB.GetVillagesFromDB();
            ddlVillage.DataBind();
            ddlVillage.Items.Insert(0, itmDefault);
        }

        private void ShowRooms()
        {
            ListItem itmDefault = new ListItem("- Rooms - ", "0");

            ddlRooms.Items.Insert(0, itmDefault);
        }

        private void ShowBeds()
        {
            ListItem itmDefault = new ListItem("- Beds -", "0");

            ddlBeds.Items.Insert(0, itmDefault);
        }
    }
}