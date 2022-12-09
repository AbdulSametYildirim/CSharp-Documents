using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishWords
{
    public partial class rapor_deneme : System.Web.UI.Page
    {
   
        
            protected void Page_Load(object sender, EventArgs e)

            {
            object user_id = Session["user_id"];

            string user_id_str = Convert.ToString(user_id);
            int user_id_int = Int16.Parse(user_id_str);

            if (!this.IsPostBack)
                {
                    string sorgu = "SELECT * FROM Users Where user_id="+ user_id_int;
                    SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["WordConnectionString"].ConnectionString);
                    SqlCommand cmd = new SqlCommand(sorgu, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();

                    adapter.Fill(ds1, "DataSet11");
                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Raporlar/Report1.rdlc");
                    ReportDataSource rds = new ReportDataSource("DataSet_name", ds1.Tables[0]);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(rds);
                    ReportViewer1.LocalReport.Refresh();
                }
            }
        }
    
}