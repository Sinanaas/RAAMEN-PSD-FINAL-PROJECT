using RAAMEN_PSD_FINAL_PROJECT.Controller;
using RAAMEN_PSD_FINAL_PROJECT.Model;
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
            if(!IsPostBack)
            {
                int user_id = Convert.ToInt32(Session["user_id"]);

                ramenGridView.DataSource = RamenRepository.getAllRamen();
                ramenGridView.DataBind();
                cartGridView.DataSource = CartRamenRepository.getAllItems(user_id);
                cartGridView.DataBind();
            }
        }

        protected void ramenGridView_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddRecord")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow row = ramenGridView.Rows[index];
                string ramen_id = Server.HtmlDecode(row.Cells[1].Text);

                int user_id = Convert.ToInt32(Session["user_id"]);
                Cart cart = CartRepository.searchCart(user_id);
                //status.Text = cart.Cart_Id + " | " + ramen_id;
                CartRamenController.createCartRamen(cart.Cart_Id, int.Parse(ramen_id), 1);
                Response.Redirect("OrderRamen.aspx");
            }
        }

        //protected void pay_btn_Click(object sender, EventArgs e)
        //{
        //    int user_id = Convert.ToInt32(Session["user_id"]);
        //    DatabaseEntities db = new DatabaseEntities();
        //    Cart cart = CartRepository.searchCart(user_id);
        //    total.Text = CartRepository.getTotal(cart.Cart_Id).ToString();
        //    var cartRamenItems = from x in db.Cart_Ramen where x.Cart_Id.Equals(cart.Cart_Id) select x;
        //    if(cartRamenItems != null)
        //    {
        //        Header header = HeaderController.createHeader(user_id, 0, DateTime.Now);
        //        foreach (var cartRamen in cartRamenItems)
        //        {
        //            DetailController.createDetail(header.Header_Id, cartRamen.Ramen_Id, cartRamen.Quantity);
        //        }
        //        CartRamenRepository.deleteCartRamen(cart.Cart_Id);
        //        Response.Redirect("OrderRamen.aspx?user_id=" + user_id);
        //    }
        //}

        protected void pay_btn_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Session["user_id"]);
            DatabaseEntities db = new DatabaseEntities();
            Cart cart = CartRepository.searchCart(user_id);
            var cartRamenItems = from x in db.Cart_Ramen where x.Cart_Id.Equals(cart.Cart_Id) select x;
            if (cartRamenItems != null && cartRamenItems.Any())
            {
                Header header = HeaderController.createHeader(user_id, 0, DateTime.Now);
                foreach (var cartRamen in cartRamenItems)
                {
                    DetailController.createDetail(header.Header_Id, cartRamen.Ramen_Id, cartRamen.Quantity);
                }
                CartRamenRepository.deleteCartRamen(cart.Cart_Id);
            }
            else
            {
                return;
            }
            Response.Redirect("OrderRamen.aspx");
            total.Text = CartRepository.getTotal(cart.Cart_Id).ToString();
        }


        protected void clear_btn_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Session["user_id"]);
            DatabaseEntities db = new DatabaseEntities();
            Cart cart = CartRepository.searchCart(user_id);
            CartRamenRepository.deleteCartRamen(cart.Cart_Id);
            Response.Redirect("OrderRamen.aspx?user_id=" + user_id);
        }
    }
}