using RAAMEN_PSD_FINAL_PROJECT.Controller;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            int role_id = int.Parse(Request.QueryString["role_id"]);
            string selectedGender = "";
            if (male_radio.Checked)
            {
                selectedGender = "Male";
            }
            else if (female_radio.Checked)
            {
                selectedGender = "Female";
            }

            message.Text = UserController.userRegister(role_id, username_text.Text, email_text.Text, selectedGender, password_text.Text, confirm_password_text.Text);
            if (message.Text.Equals("Register Success"))
            {
                int uid = UserRepository.getLatestUserIdWithRoleId2();
                CartController.createCart(uid, DateTime.Now);
                Response.Redirect("Login.aspx");
            }
        }
    }
}