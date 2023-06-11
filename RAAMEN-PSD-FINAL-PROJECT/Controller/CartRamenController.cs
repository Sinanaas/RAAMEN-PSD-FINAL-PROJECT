using RAAMEN_PSD_FINAL_PROJECT.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Controller
{
    public class CartRamenController
    {
        public static void createCartRamen(int cart_id, int ramen_id, int quantity)
        {
            CartRamenHandler.createCartRamen(cart_id, ramen_id, quantity);
        }
    }
}