using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Factory
{
    public class CartRamenFactory
    {
        public static Cart_Ramen createCartRamen(int cart_id, int ramen_id, int quantity)
        {
            Cart_Ramen cartRamen = new Cart_Ramen();
            cartRamen.Cart_Id = cart_id;
            cartRamen.Ramen_Id = ramen_id;
            cartRamen.Quantity = quantity;

            return cartRamen;
        }
    }
}