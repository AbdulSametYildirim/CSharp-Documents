using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishWords
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kadi = txt_kadi.Text;
            string sifre = txt_sifre.Text;
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
            string sorgu = "Select * From Users Where user_name = @kadi AND user_pass = @sifre";
            SqlCommand cmd = new SqlCommand(sorgu, connect);
            cmd.Parameters.AddWithValue("@kadi", kadi);
            cmd.Parameters.AddWithValue("@sifre", sifre);

            connect.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session.Timeout = 300;
                Session.Add("user_id", dr["user_id"].ToString());
                lbl_mesaj.Text = "Başarıyla Giriş Yapıldı";
            }
            else
            {
                lbl_mesaj.Text = "Kullanıcı girişi sağlanamadı";
            }
            connect.Close();

        }
    }
}