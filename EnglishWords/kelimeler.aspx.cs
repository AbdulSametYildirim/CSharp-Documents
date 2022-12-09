using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishWords
{
    public partial class kelimeler : System.Web.UI.Page
    {
        string cevap = "";
        string kpuan = "";
        int kpuan1;

        protected void Page_Load(object sender, EventArgs e)
        {

            lbl_dmesajim.Visible = false;
            lbl_ymesajim.Visible = false;

            PuanGetir();


            SoruGetir();


        }

        public void SoruGetir()
        {
            StringBuilder errorMessages = new StringBuilder();
            object user_id = Session["user_id"];

            if (user_id != null)
            {

                string user_id_str = Convert.ToString(user_id);
                int user_id_int = Int16.Parse(user_id_str);

                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

                string sorgu = "select top 1 * from Words ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(sorgu, cnn);
                cnn.Open();


                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lbl_soru.Text = dr["word_ing"].ToString();
                        btn_cevap1.Text = dr["word_answer1"].ToString();
                        btn_cevap2.Text = dr["word_answer2"].ToString();
                        btn_cevap3.Text = dr["word_answer3"].ToString();
                        btn_cevap4.Text = dr["word_answer4"].ToString();

                        cevap = dr["word_correct_answer"].ToString();
                    }

                    cnn.Close();

                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    lbl_soru.Text = errorMessages.ToString();
                }

                cnn.Close();


            }
            else
            {
                lbl_puan.Text = "Lütfen Önce Giriş Yapınız";
            }
        }

        public void PuanGetir()
        {

            object user_id = Session["user_id"];
            if (user_id != null)
            {

                string user_id_str = Convert.ToString(user_id);
                int user_id_int = Int16.Parse(user_id_str);

                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

                string sorgu = "select * from Users where user_id = @user_id";
                SqlCommand cmd = new SqlCommand(sorgu, cnn);
                cnn.Open();


                try
                {



                    cmd.Parameters.AddWithValue("@user_id", user_id_int);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lbl_puan.Text = dr["user_point"].ToString();
                        kpuan = dr["user_point"].ToString();
                    }

                    cnn.Close();

                }
                catch (Exception)
                {
                    lbl_puan.Text = "-9";

                }

                cnn.Close();


            }
            else
            {
                lbl_puan.Text = "Lütfen Önce Giriş Yapınız";
            }
        }

        protected void btn_yeni_Click(object sender, EventArgs e)
        {
            PuanGetir();


            SoruGetir();

        }

        public void btn_kontrol(String deger)
        {
            object user_id = Session["user_id"];
            deger = deger.Trim();
            cevap = cevap.Trim();
            if (deger.Equals(cevap))
            {
                kpuan1 = Int16.Parse(kpuan);
                kpuan1++;



                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

                SqlCommand update = new SqlCommand("update Users set user_point = @p1 where user_id = @user_id", cnn);
                update.Parameters.AddWithValue("@p1", kpuan1);
                update.Parameters.AddWithValue("@user_id", user_id);


                cnn.Open();
                update.ExecuteNonQuery();
                cnn.Close();


                PuanGetir();


                SoruGetir();
                Page.Response.Redirect(Page.Request.Url.ToString());


                lbl_dmesajim.Visible = true;
                lbl_ymesajim.Visible = false;
            }
       
            else
            {
                 kpuan1 = Int16.Parse(kpuan);
        kpuan1--;



                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

        SqlCommand update = new SqlCommand("update Users set user_point = @p1 where user_id = @user_id", cnn);
        update.Parameters.AddWithValue("@p1", kpuan1);
                update.Parameters.AddWithValue("@user_id", user_id);


                cnn.Open();
                update.ExecuteNonQuery();
                cnn.Close();


                PuanGetir();


        SoruGetir();
        Page.Response.Redirect(Page.Request.Url.ToString());


                lbl_dmesajim.Visible = false;
                lbl_ymesajim.Visible = true;
            }
        }

    public void btn_cevap1_Click(object sender, EventArgs e)
        {
            btn_kontrol(btn_cevap1.Text);

        }


        protected void btn_cevap2_Click1(object sender, EventArgs e)
        {
            btn_kontrol(btn_cevap2.Text);
        }

        protected void btn_cevap3_Click1(object sender, EventArgs e)
        {
            btn_kontrol(btn_cevap3.Text);

        }

        protected void btn_cevap4_Click1(object sender, EventArgs e)
        {
            btn_kontrol(btn_cevap4.Text);
        }
    }



    
    }
