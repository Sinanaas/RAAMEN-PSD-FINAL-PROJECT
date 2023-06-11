using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Admin
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                unhandledGridView.DataSource = HeaderRepository.getUnhandled();
                unhandledGridView.DataBind();
                handledGridView.DataSource = HeaderRepository.getHandled();
                handledGridView.DataBind();
            }
        }

        protected void unhandledGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Handle")
            {
                int user_id = Convert.ToInt32(Session["user_id"]);
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow row = unhandledGridView.Rows[index];
                string header_id = row.Cells[1].Text;
                HeaderRepository.handleHeader(int.Parse(header_id), user_id);
                Response.Redirect("OrderQueue.aspx");
            }
        }
    }
}