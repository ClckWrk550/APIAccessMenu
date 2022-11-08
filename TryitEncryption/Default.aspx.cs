using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryitEncryption
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient myClient = new EncryptService.ServiceClient();
            try { TextBox2.Text = myClient.Encrypt(TextBox1.Text); }
            catch (Exception ec) { TextBox2.Text = ec.Message.ToString(); } // Encrypt Text in Box and print to label
            try { TextBox3.Text = myClient.Decrypt(TextBox2.Text); }
            catch (Exception dc) { TextBox3.Text = dc.Message.ToString(); } // Decrypt Encrypted label and reprint
        }
    }
}