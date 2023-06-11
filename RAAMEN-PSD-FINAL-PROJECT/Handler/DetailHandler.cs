using RAAMEN_PSD_FINAL_PROJECT.Factory;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Handler
{
    public class DetailHandler
    {
        public static void createDetail(int header_id, int ramen_id, int quantity)
        {
            Detail detail = DetailFactory.creaeteDetail(header_id, ramen_id, quantity);
            DetailRepository.createDetail(detail);
        }
    }
}