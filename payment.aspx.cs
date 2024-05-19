using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PORTAL
{
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string url;
            url = "register.aspx"; //?name =" + Label6.Text;

            Response.Redirect(url);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string url;
            url = "email_verification.aspx?name";// =" + Label6.Text;

            Response.Redirect(url);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string url;
            url = "payment.aspx"; //?name =" + Label6.Text;

            Response.Redirect(url);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string url;
            url = "admit_card.aspx?name";// =" + Label6.Text;

            Response.Redirect(url);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {

        }
    }
}