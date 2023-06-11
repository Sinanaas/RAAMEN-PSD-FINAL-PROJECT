using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Customer
{
    public partial class HistoryCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = int.Parse(Request.QueryString["user_id"]);
            historyGridView.DataSource = HeaderRepository.getAllHeader(user_id);
            historyGridView.DataBind();
        }

        protected void historyGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddRecord")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow row = historyGridView.Rows[index];
                string header_id = Server.HtmlDecode(row.Cells[1].Text);

                Response.Redirect("~/View/Customer/TransactionDetail.aspx?header_id=" + header_id);
                //int user_id = int.Parse(Request.QueryString["user_id"]);
                //Cart cart = CartRepository.searchCart(user_id);
                //CartRamenController.createCartRamen(cart.Cart_Id, int.Parse(ramen_id), 1);
                //Response.Redirect("OrderRamen.aspx?user_id=" + user_id);
            }
        }
    }
}