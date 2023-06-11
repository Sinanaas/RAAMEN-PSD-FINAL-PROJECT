using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class DetailRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static void createDetail(Detail detail)
        {
            db.Details.Add(detail);
            db.SaveChanges();
        }
    }
}