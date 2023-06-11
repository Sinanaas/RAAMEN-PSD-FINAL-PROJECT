using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Admin
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int header_id = int.Parse(Request.QueryString["header_id"]);
            detailGridView.DataSource = DetailRepository.getAllDetail(header_id);
            detailGridView.DataBind();
        }
    }
}