using RAAMEN_PSD_FINAL_PROJECT.Controller;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                string cookieValue = cookie.Value;
                int startIndex = cookieValue.IndexOf('=') + 1;
                int userId = int.Parse(cookieValue.Substring(startIndex));
                Session["user_id"] = userId.ToString();
                User user = UserRepository.userSearch(userId);
                if (user.Role_Id == 1)
                {
                    Response.Redirect("Admin/HomeAdmin.aspx?user_id=" + userId);
                }
                else if (user.Role_Id == 2)
                {
                    Response.Redirect("Customer/HomeCustomer.aspx?user_id=" + userId);
                }
                else if (user.Role_Id == 3)
                {
                    Response.Redirect("Staff/HomeStaff.aspx?user_id=" + userId);
                }
                else
                {
                    Response.Redirect("Register.aspx");
                }
            }
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            User user = UserController.userLogin(username_text.Text, password_text.Text);

            if (user != null)
            {
                int uid = user.User_Id;
                //Session["user_id"] = uid;
                if (remember_check.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserInfo");
                    cookie["user_id"] = user.User_Id.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                if (user.Role_Id == 1)
                {
                    Response.Redirect("Admin/HomeAdmin.aspx?user_id=" + uid);
                }
                else if (user.Role_Id == 2)
                {
                    if(CartRepository.searchCart(uid) == null)
                    {
                        DateTime currentTime = DateTime.Now;
                        CartController.createCart(uid, currentTime);
                    }
                    Response.Redirect("Customer/HomeCustomer.aspx?user_id=" + uid);
                }
                else if (user.Role_Id == 3)
                {
                    Response.Redirect("Staff/HomeStaff.aspx?user_id=" + uid);
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}