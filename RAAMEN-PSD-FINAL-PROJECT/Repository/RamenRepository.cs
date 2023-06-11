using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class RamenRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static List<Raman> getAllRamen()
        {
            List<Raman> ramens = (from x in db.Ramen select x).ToList();
            return ramens;
        }

        public static void createRamen(Raman ramen) 
        {
            db.Ramen.Add(ramen);
            db.SaveChanges();
        }

        public static Raman deleteRamen(int id)
        {
            Raman ramen = db.Ramen.Find(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
            return ramen;
        }

        public static Raman searchRamen(int id)
        {
            Raman ramen = db.Ramen.Find(id);
            return ramen;
        }

        public static void updateRamen(int id, int meat_id, string name, string broth, int price)
        {
            Raman ramen = db.Ramen.Find(id);
            ramen.Meat_Id = meat_id;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;

            db.SaveChanges();
        }

        public static int getPrice(int ramen_id)
        {
            int price = (from x in db.Ramen where x.Ramen_Id.Equals(ramen_id) select x.Price).FirstOrDefault();
            return price;
        }
    }
}