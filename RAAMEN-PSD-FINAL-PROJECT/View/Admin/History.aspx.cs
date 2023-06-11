using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Admin
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            historyGridView.DataSource = HeaderRepository.getAll();
            historyGridView.DataBind();
        }

        protected void historyGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow row = historyGridView.Rows[index];
                string header_id = Server.HtmlDecode(row.Cells[1].Text);

                Response.Redirect("~/View/Admin/TransactionDetail.aspx?header_id=" + header_id);
            }
        }
    }
}