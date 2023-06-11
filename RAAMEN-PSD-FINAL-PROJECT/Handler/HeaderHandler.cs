using RAAMEN_PSD_FINAL_PROJECT.Factory;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Handler
{
    public class HeaderHandler
    {
        public static Header createHeader(int user_id, int staff_id, DateTime date)
        {
            Header header = HeaderFactory.createHeader(user_id, staff_id, date);
            HeaderRepository.createHeader(header);
            return header;
        }
    }
}