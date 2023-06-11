using RAAMEN_PSD_FINAL_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Admin
{
    public partial class CreateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_ramen_btn_Click(object sender, EventArgs e)
        {
            RamenController.createRamen(int.Parse(DropDownList1.SelectedValue), name_txt.Text, broth_txt.Text, int.Parse(price_txt.Text));
            Response.Redirect("ManageRamen.aspx");
        }
    }
}