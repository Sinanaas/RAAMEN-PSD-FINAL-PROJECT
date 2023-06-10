using RAAMEN_PSD_FINAL_PROJECT.Factory;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Handler
{
    public class CartRamenHandler
    {
        public static void createCartRamen(int cart_id, int ramen_id, int quantity)
        {
            Cart_Ramen cart_ramen = CartRamenFactory.createCartRamen(cart_id, ramen_id, quantity);
            CartRamenRepository.createCartRamen(cart_ramen);
        }
    }
}