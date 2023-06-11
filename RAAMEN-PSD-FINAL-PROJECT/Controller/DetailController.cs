using RAAMEN_PSD_FINAL_PROJECT.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Controller
{
    public class DetailController
    {
        public static void createDetail(int header_id, int ramen_id, int quantity)
        {
            DetailHandler.createDetail(header_id, ramen_id, quantity);
        }
    }
}