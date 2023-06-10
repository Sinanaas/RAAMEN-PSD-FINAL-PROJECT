using RAAMEN_PSD_FINAL_PROJECT.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Controller
{
    public class RamenController
    {
        public static string createRamen(int meat_id, string name, string broth, int price)
        {
            if (!name.Contains("Ramen"))
            {
                return "Name must contain 'Ramen'.";
            }
            else if (meat_id == 0)
            {
                return "Meat must be selected.";
            }
            else if (string.IsNullOrEmpty(broth))
            {
                return "Broth cannot be empty.";
            }
            else if (price < 3000)
            {
                return "Price must be at least 3000.";
            }

            // Your code to insert the new ramen data goes here
            RamenHandler.createRamen(meat_id, name, broth, price);
            return "Ramen data inserted successfully.";
        }

        public static string updateRamen(int id, int meat_id, string name, string broth, int price)
        {
            if (!name.Contains("Ramen"))
            {
                return "Name must contain 'Ramen'.";
            }
            else if (meat_id == 0)
            {
                return "Meat must be selected.";
            }
            else if (string.IsNullOrEmpty(broth))
            {
                return "Broth cannot be empty.";
            }
            else if (price < 3000)
            {
                return "Price must be at least 3000.";
            }

            // Your code to insert the new ramen data goes here
            RamenHandler.updateRamen(id, meat_id, name, broth, price);
            return "Ramen data updated successfully.";
        }

    }
}