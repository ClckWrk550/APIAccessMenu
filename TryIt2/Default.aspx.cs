using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TempSortServices.Service1Client tempService = new TempSortServices.Service1Client();
            int y = int.Parse(TextBox1.Text);
            int cels = tempService.f2c(y);
            TextBox2.Text = cels.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TempSortServices.Service1Client tempService = new TempSortServices.Service1Client();
            int y = int.Parse(TextBox3.Text);
            int cels = tempService.c2f(y);
            TextBox4.Text = cels.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TempSortServices.Service1Client sortService = new TempSortServices.Service1Client();
            string r = TextBox5.Text;
            string output = sortService.sort(r); // Run Sort on Textbox Text
            TextBox6.Text = output; // Output into TextBox
        }
    }
}