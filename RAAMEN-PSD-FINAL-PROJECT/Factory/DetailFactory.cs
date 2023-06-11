using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Factory
{
    public class DetailFactory
    {
        public static Detail creaeteDetail(int header_id, int ramen_id, int quantity)
        {
            Detail detail = new Detail();
            detail.Header_Id = header_id;
            detail.Ramen_Id = ramen_id;
            detail.Quantity = quantity;

            return detail;
        }
    }
}