using RAAMEN_PSD_FINAL_PROJECT.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Controller
{
    public class CartController
    {
        public static void createCart(int user_id, DateTime date)
        {
            CartHandler.createCart(user_id, date);
        }
    }
}