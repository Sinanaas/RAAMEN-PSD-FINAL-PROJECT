using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Staff
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGridView.DataSource = RamenRepository.getAllRamen();
            ramenGridView.DataBind();
            customerGridView.DataSource = UserRepository.getAllCustomer();
            customerGridView.DataBind();
        }

        protected void insert_ramen_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateRamen.aspx");
        }

        protected void ramenGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ramenGridView.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text.ToString());
            RamenRepository.deleteRamen(id);
            Response.Redirect("ManageRamen.aspx");
        }

        protected void ramenGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ramenGridView.Rows[e.NewEditIndex];
            string id = row.Cells[1].Text.ToString();
            Response.Redirect("UpdateRamen.aspx?ramen_id=" + id);
        }
    }
}