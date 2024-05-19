using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace PORTAL
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // TextBox1.Text = Request.QueryString["name"];
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            string data = url.Split('?')[1].Split('=')[1];
            TextBox1.Text = data;
            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            con.Open();


            SQLiteCommand cmd = new SQLiteCommand("select Name,Email,Phone,Address,DOB,Gender,number from portal where Email like '" + TextBox1.Text + "'", con);
            SQLiteDataReader ds = cmd.ExecuteReader();

            if (ds.HasRows)
            {
                while (ds.Read())
                {
                    //  label23 .Text = ds[0].ToString();
                    Label1.Text = ds[0].ToString();
                    Label2.Text = ds[1].ToString();
                    Label3.Text = ds[2].ToString();
                    Label4.Text = ds[3].ToString();
                    Label5.Text = ds[4].ToString();
                    Label6.Text = ds[5].ToString();
                    Label8.Text = ds[6].ToString();
                    //label9.Text = ds[7].ToString();



                }
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}