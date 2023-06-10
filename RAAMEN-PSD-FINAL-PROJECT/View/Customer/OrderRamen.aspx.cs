using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Customer
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGridView.DataSource = RamenRepository.getAllRamen();
            ramenGridView.DataBind();
            //cartGridView.DataSource;
            
        }

        protected void ramenGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void ramenGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}