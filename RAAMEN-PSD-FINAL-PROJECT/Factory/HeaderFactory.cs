using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Factory
{
    public class HeaderFactory
    {
        public static Header createHeader(int user_id, int staff_id, DateTime date)
        {
            Header header = new Header();
            header.User_Id = user_id;
            header.Staff_Id = staff_id;
            header.Date = date;

            return header;
        }
    }
}