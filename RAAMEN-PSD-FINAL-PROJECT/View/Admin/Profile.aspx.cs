using RAAMEN_PSD_FINAL_PROJECT.Controller;
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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["user_id"] != null)
                {
                    int user_id = int.Parse(Request.QueryString["user_id"]);
                    User user = UserRepository.userSearch(user_id);
                    username_txt.Text = user.Username;
                    password_txt.Text = user.Password;
                    if (user.Gender.Equals("Male"))
                    {
                        male_radio.Checked = true;
                    }
                    else
                    {
                        female_radio.Checked = true;
                    }
                    email_txt.Text = user.Email;
                }
                else
                {
                    // Handle the case when the user_id is missing or not in the expected format
                    // Redirect to an error page or display an error message
                }
            }
        }


        protected void update_btn_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(Request.QueryString["user_id"]);
            string selectedGender;
            if(male_radio.Checked)
            {
                selectedGender = "Male";
            } else
            {
                selectedGender = "Female";
            }
            UserController.userUpdate(user_id, username_txt.Text, email_txt.Text, selectedGender, password_txt.Text);
        }
    }
}