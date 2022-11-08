using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void top10Btn_Click(object sender, EventArgs e)
        {
            Top10Service.Service1Client obj = new Top10Service.Service1Client();
            TextBox3.Text = string.Join(",", obj.Top10Words(TextBox1.Text.ToString()));
        }

        protected void filtWords_Click(object sender, EventArgs e)
        {
            FilterService.Service1Client obj = new FilterService.Service1Client();
            TextBox4.Text = obj.WordFilter(TextBox2.Text.ToString());
        }


        protected void getFrcst_Click(object sender, EventArgs e)
        {

        }
    }
}