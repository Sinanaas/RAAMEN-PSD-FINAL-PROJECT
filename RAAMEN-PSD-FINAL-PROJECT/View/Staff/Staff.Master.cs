using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Staff
{
    public partial class Staff : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butOut_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-1);
            }
            Response.Redirect("~/Login.aspx");
        }

        protected void manage_ramen_btn_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(Request.QueryString["user_id"]);
            Response.Redirect("ManageRamen.aspx?user_id=" + user_id);
        }
    }
}