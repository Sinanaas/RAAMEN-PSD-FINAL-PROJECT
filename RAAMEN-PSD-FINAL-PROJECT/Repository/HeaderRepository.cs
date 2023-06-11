using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class HeaderRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static void createHeader(Header header)
        {
            db.Headers.Add(header);
            db.SaveChanges();
        }
    }
}