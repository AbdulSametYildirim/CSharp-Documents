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
    public partial class kayitol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kadi = txt_kadi.Text;
            string sifre = txt_sifre.Text;


            if (kadi.Contains(" ") == true | sifre.Contains(" ") == true)
            {
                lbl_mesaj.Text = "Lütfen Tüm Alanları Doldurun";
            }
            else
            {
              
                    SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

                    string sorgu = "Insert into Users (user_name, user_pass) Values (@kadi,@sifre)";
                    SqlCommand cmd = new SqlCommand(sorgu, connect);
                connect.Open();


                    try
                    {
                        cmd.Parameters.AddWithValue("@kadi", kadi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                    cmd.ExecuteNonQuery();
                    connect.Close();

                    lbl_mesaj.Text = "Başarı ile kayıt yapılmıştır!";
                    }
                    catch (Exception)
                    {
                    lbl_mesaj.Text = "Kaydınız yapılamamıştır!";

                    }

                
           
            }
        }

    }
    }
