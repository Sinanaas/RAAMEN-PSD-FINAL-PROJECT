using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int user_id, DateTime date)
        {
            Cart cart = new Cart();
            cart.User_Id = user_id;
            cart.Date_Created = date;

            return cart;
        }
    }
}