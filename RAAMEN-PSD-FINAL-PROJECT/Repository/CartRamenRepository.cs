using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class CartRamenRepository
    {
        static DatabaseEntities db = new DatabaseEntities();

        public static void createCartRamen(Cart_Ramen cart_ramen)
        {
            Cart_Ramen x = searchCartRamen(cart_ramen.Ramen_Id);
            if (x != null)
            {
                x.Quantity++;
            }
            else
            {
                db.Cart_Ramen.Add(cart_ramen);
            }
            db.SaveChanges();
        }

        public static List<Cart_Ramen> getAllItems(int user_id)
        {
            Cart cart = CartRepository.searchCart(user_id);
            if(cart == null)
            {
                return null;
            }
            List<Cart_Ramen> list = (from x in db.Cart_Ramen where x.Cart_Id.Equals(cart.Cart_Id) select x).ToList();
            return list;
        }

        public static Cart_Ramen searchCartRamen(int ramen_id)
        {
            Cart_Ramen cart_ramen = (from x in db.Cart_Ramen where x.Ramen_Id.Equals(ramen_id) select x).FirstOrDefault();
            if(cart_ramen == null)
            {
                return null;
            }
            return cart_ramen;
        }

        public static void deleteCartRamen(int cart_id)
        {
            var cartRamenItems = from x in db.Cart_Ramen where x.Cart_Id == cart_id select x;
            db.Cart_Ramen.RemoveRange(cartRamenItems);
            db.SaveChanges();
        }
    }
}