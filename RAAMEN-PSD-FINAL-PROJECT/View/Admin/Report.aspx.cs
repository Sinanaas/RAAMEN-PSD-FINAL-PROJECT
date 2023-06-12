using RAAMEN_PSD_FINAL_PROJECT.DataSet;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.View.Admin
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;

            DatabaseEntities db = new DatabaseEntities();
            myDataSet data = getData(db.Headers.ToList());
            report.SetDataSource(data);        }

        public static myDataSet getData(List<Header> headers)
        {
            myDataSet data = new myDataSet();

            foreach (Header h in headers)
            {
                var hrow = data.Header.NewRow();
                hrow["id"] = h.Header_Id;
                hrow["staffId"] = h.Staff_Id;
                hrow["userId"] = h.User_Id;
                hrow["date"] = h.Date;
                data.Header.Rows.Add(hrow);

                foreach(Detail d in h.Details)
                {
                    var drow = data.Detail.NewRow();
                    drow["headerId"] = d.Header_Id;
                    drow["ramenId"] = d.Ramen_Id;
                    drow["quantity"] = d.Quantity;
                    data.Detail.Rows.Add(drow);
                }

            }
            return data;
        }
    }
}