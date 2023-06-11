using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Customer
{
    public partial class Customer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butOut_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_id"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-1);
            }
            Session.Abandon();
            Response.Redirect("~/View/Login.aspx");
        }
    }
}