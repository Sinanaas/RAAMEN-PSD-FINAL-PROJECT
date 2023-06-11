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
    public partial class HomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                DateTime expiration = cookie.Expires;
                TimeSpan duration = expiration - DateTime.Now;
                double remainingHours = duration.TotalHours;
            }

            customerGridView.DataSource = UserRepository.getAllCustomer();
            customerGridView.DataBind();
            staffGridView.DataSource = UserRepository.getAllStaff();
            staffGridView.DataBind();
        }
    }
}