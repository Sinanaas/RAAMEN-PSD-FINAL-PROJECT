using RAAMEN_PSD_FINAL_PROJECT.Controller;
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
    public partial class HomeStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List <Raman> ramens = RamenRepository.getAllRamen();
            ramenGridView.DataSource = ramens;
            ramenGridView.DataBind();
        }
    }
}