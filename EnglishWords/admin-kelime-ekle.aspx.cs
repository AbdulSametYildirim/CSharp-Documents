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
    public partial class admin_kelime_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object user_id = Session["user_id"];
            if (user_id != null)
            {
               // Response.Redirect("default.aspx");
            }
            else
            {


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kelime = txt_kelime.Text;
            string cevap1 = txt_cevap1.Text;
            string cevap2 = txt_cevap2.Text;
            string cevap3 = txt_cevap3.Text;
            string cevap4 = txt_cevap4.Text;
            string dogruCevap = txt_dogru_cevap.Text;

            if (kelime.Contains(" ") == true | cevap1.Contains(" ") == true)
            {
                lbl_mesaj.Text = "Lütfen Tüm Alanları Doldurun";
            }
            else
            {

                SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

                string sorgu = "Insert into Words (word_ing, word_answer1 ,word_answer2 ,word_answer3 ,word_answer4 ,word_correct_answer)" +
                    " Values (@word_ing,@word_answer1,@word_answer2,@word_answer3,@word_answer4,@word_correct_answer)";
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                connect.Open();


                try
                {
                    cmd.Parameters.AddWithValue("@word_ing", kelime);
                    cmd.Parameters.AddWithValue("@word_answer1", cevap1);
                    cmd.Parameters.AddWithValue("@word_answer2", cevap2);

                    cmd.Parameters.AddWithValue("@word_answer3", cevap3);
                    cmd.Parameters.AddWithValue("@word_answer4", cevap4);
                    cmd.Parameters.AddWithValue("@word_correct_answer", dogruCevap);

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