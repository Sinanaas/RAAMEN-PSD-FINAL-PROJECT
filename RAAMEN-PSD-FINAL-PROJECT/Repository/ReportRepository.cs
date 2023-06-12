using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class ReportRepository
    {
        public static List<Header> GetHeader()
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.Headers.ToList();
        }
    }
}