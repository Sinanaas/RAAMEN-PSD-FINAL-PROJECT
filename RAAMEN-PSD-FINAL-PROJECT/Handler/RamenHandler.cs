using RAAMEN_PSD_FINAL_PROJECT.Factory;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Handler
{
    public class RamenHandler
    {
        public static void createRamen(int meat_id, string name, string broth, int price)
        {
            Raman ramen = RamenFactory.createRamen(meat_id, name, broth, price);
            RamenRepository.createRamen(ramen);
        }

        public static void updateRamen(int id, int meat_id, string name, string broth, int price)
        {
            RamenRepository.updateRamen(id, meat_id, name, broth, price);
        }
    }
}