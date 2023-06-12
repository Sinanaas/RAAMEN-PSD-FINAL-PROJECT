using RAAMEN_PSD_FINAL_PROJECT.DataSet;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_PSD_FINAL_PROJECT.test
{
    public partial class myTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;

            DatabaseEntities db = new DatabaseEntities();
            myDataSet data = getData(db.Headers.ToList());
            report.SetDataSource(data);
        }

        public static myDataSet getData(List<Header> headers)
        {
            int grand = 0;
            myDataSet data = new myDataSet();
            foreach (Header h in headers)
            {
                int total = 0;
                var hrow = data.Header.NewRow();
                hrow["id"] = h.Header_Id;
                hrow["staffId"] = h.Staff_Id;
                hrow["userId"] = h.User_Id;
                hrow["date"] = h.Date;
                data.Header.Rows.Add(hrow);

                foreach (Detail d in h.Details)
                {
                    var drow = data.Detail.NewRow();
                    drow["headerId"] = d.Header_Id;
                    drow["buyer"] = d.Header.User.Username;
                    drow["ramenName"] = d.Raman.Name;
                    drow["totalPrice"] = d.Raman.Price * d.Quantity;
                    //drow["totalPrice"] = h.Details.Sum(x => int.Parse(d.Raman.Price) * d.Quantity).ToString();
                    //drow["totalPrice"] = h.Details.Sum(x => int.Parse(d.Raman.Price) * int.Parse(d.Quantity));
                    drow["price"] = d.Raman.Price;
                    drow["broth"] = d.Raman.Broth;
                    drow["quantity"] = d.Quantity;
                    //drow["totalAkhir"] = h.Details.Sum(x => d.Raman.Price * d.Quantity).ToString();
                    //total = h.Details.Sum(x => d.Raman.Price * d.Quantity);
                    total += d.Raman.Price * d.Quantity;
                    drow["totalAkhir"] = total;
                    data.Detail.Rows.Add(drow);
                }
                grand += total;
                hrow["grandTotal"] = grand;
            }
            return data;
        }
    }
}
