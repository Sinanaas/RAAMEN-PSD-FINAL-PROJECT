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
            Cart cart = (from x in db.Carts where x.User_Id.Equals(user_id) select x).FirstOrDefault();
            if(cart == null)
            {
                return null;
            }
            return cart;
        }

        public static void createCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static int getTotal(int cart_id)
        {
            int total = 0;
            var cartRamenItems = from x in db.Cart_Ramen where x.Cart_Id.Equals(cart_id) select x;
            foreach (var cartRamen in cartRamenItems)
            {
                int ramenPrice = RamenRepository.getPrice(cartRamen.Ramen_Id) * cartRamen.Quantity;
                total += ramenPrice;
            }
            return total;
        }
    }
}