using RAAMEN_PSD_FINAL_PROJECT.Controller;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Admin
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ramen_id"]);
                Raman ramen = RamenRepository.searchRamen(id);
                if (ramen.Meat_Id.Equals(1))
                {
                    DropDownList1.SelectedValue = "1";
                }
                else if (ramen.Meat_Id.Equals(2))
                {
                    DropDownList1.SelectedValue = "2";
                }
                else if (ramen.Meat_Id.Equals("3"))
                {
                    DropDownList1.SelectedValue = "3";
                }
                else if (ramen.Meat_Id.Equals("4"))
                {
                    DropDownList1.SelectedValue = "4";
                }
                name_txt.Text = ramen.Name;
                price_txt.Text = ramen.Price.ToString();
                broth_txt.Text = ramen.Broth;
            }
        }

        protected void update_ramen_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ramen_id"]);
            RamenController.updateRamen(id, int.Parse(DropDownList1.SelectedValue), name_txt.Text, broth_txt.Text, int.Parse(price_txt.Text));
            Response.Redirect("ManageRamen.aspx");
        }
    }
}