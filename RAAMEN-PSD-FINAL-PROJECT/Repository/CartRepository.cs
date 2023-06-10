using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class CartRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static Cart searchCart(int user_id)
        {
            Cart cart = db.Carts.Find(user_id);
            return cart;
        }

        public static void createCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }
    }
}