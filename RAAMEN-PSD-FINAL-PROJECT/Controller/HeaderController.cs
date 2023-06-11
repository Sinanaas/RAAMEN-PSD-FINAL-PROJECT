using RAAMEN_PSD_FINAL_PROJECT.Handler;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Controller
{
    public class HeaderController
    {
        public static Header createHeader(int user_id, int staff_id, DateTime date)
        {
            Header header = HeaderHandler.createHeader(user_id, staff_id, date);
            return header;
        }
    }
}