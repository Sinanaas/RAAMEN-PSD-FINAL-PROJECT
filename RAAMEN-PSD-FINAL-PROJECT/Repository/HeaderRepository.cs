using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        //public static List<object> getAllHeader(int user_id)
        //{
        //    var list = (from h in db.Headers
        //                join d in db.Details on h.Header_Id equals d.Header_Id
        //                join r in db.Ramen on d.Ramen_Id equals r.Ramen_Id
        //                where h.User_Id == user_id
        //                select new
        //                {
        //                    HeaderId = h.Header_Id,
        //                    RamenName = r.Name,
        //                    Quantity = d.Quantity,
        //                    Date = h.Date
        //                }).ToList();

        //    return list.Select(x => new
        //    {
        //        x.HeaderId,
        //        x.RamenName,
        //        x.Quantity,
        //        x.Date
        //    }).ToList<object>();
        //}

        public static List<Header> getAllHeader(int user_id)
        {
            List<Header> list = (from x in db.Headers where x.User_Id.Equals(user_id) select x).ToList();
            return list;
        }

        public static List<Header> getUnhandled()
        {
            List<Header> list = (from x in db.Headers where x.Staff_Id.Equals(0) select x).ToList();
            return list;
        }

        public static List<Header> getHandled()
        {
            List<Header> list = (from x in db.Headers where x.Staff_Id != 0 select x).ToList();
            return list;
        }

        public static void deleteHeader(int header_id)
        {
            Header header = db.Headers.Find(header_id);
            if(header != null)
            {
                db.Headers.Remove(header);
            }
            db.SaveChanges();
        }

        public static void handleHeader(int header_id, int staff_id)
        {
            Header header = db.Headers.Find(header_id);
            if (header != null)
            {
                header.Staff_Id = staff_id;
                db.Entry(header).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static List<Header> getAll()
        {
            List<Header> list = (from x in db.Headers select x).ToList();
            return list;
        }
    }
}