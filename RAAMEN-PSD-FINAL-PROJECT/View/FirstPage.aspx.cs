﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void custReg_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?role_id=" + 2);
        }

        protected void staffReg_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?role_id=" + 3);
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}