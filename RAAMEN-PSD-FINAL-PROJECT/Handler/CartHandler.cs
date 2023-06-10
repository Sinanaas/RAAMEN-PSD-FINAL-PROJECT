using RAAMEN_PSD_FINAL_PROJECT.Factory;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Handler
{
    public class CartHandler
    {
        public static void createCart(int user_id, DateTime date)
        {
            Cart cart = CartFactory.createCart(user_id, date);
            CartRepository.createCart(cart);
        }
    }
}