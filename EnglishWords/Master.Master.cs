using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishWords
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object user_id = Session["user_id"];
            if (user_id != null)
            {
                pnl_girisyap.Visible = false;
                pnl_kayitol.Visible = false;

                pnl_kelimeler.Visible = true;
                pnl_rapor.Visible = true;
              
            }
            else
            {
                pnl_girisyap.Visible = true;
                pnl_kayitol.Visible = true;

                pnl_kelimeler.Visible = false;
                pnl_rapor.Visible = false;

            }
        }
    }
}