using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PORTAL
{
    public partial class email_verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select Name,Email,Phone,Address,DOB,Gender,number from portal where Email like '" + TextBox2.Text + "'", con);
            SQLiteDataReader ds = cmd.ExecuteReader();

            if (ds.HasRows)
            {
                while (ds.Read())
                {
                    //  label23 .Text = ds[0].ToString();
                    //Label1.Text = ds[0].ToString();
                 //   Label6.Text = ds[1].ToString();
                    //	Label3.Text = ds[2].ToString();
                    //	Label4.Text = ds[3].ToString();
                    //	Label5.Text = ds[4].ToString();
                    //	Label6.Text = ds[5].ToString();
                    //	Label8.Text = ds[6].ToString();
                    //label9.Text = ds[7].ToString();



                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text == TextBox6.Text)
            {
                Label2.Text = "OTP Verification done successfully!";
                Label2.ForeColor = System.Drawing.Color.Green;
                Label2.Visible = true;

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
                        Label3.Text = ds[1].ToString();
                        Label4.Text = ds[2].ToString();
                        Label5.Text = ds[3].ToString();
                        Label6.Text = ds[4].ToString();
                        Label7.Text = ds[5].ToString();
                        Label8.Text = ds[6].ToString();
                        //label9.Text = ds[7].ToString();



                    }
                }



                // string url;
                // url = "WebForm4.aspx?name =" + TextBox2.Text;
                // Response.Redirect(url);
                //Response.Write("<script>alert('Registration successfully done.');</script>");
                clear();

            }
            else
            {
                Label2.Text = "Wrong OTP!";
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Visible = true;

            }
        }

        public void clear()
        {
            Button6.ForeColor = System.Drawing.Color.Green;
            TextBox5.Text = "";
            TextBox2.Text = "";
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

        protected void Button9_Click(object sender, EventArgs e)
        {
            string url;
            url = "admit_card.aspx?name";// =" + Label6.Text;

            Response.Redirect(url);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string url;
            url = "payment.aspx"; //?name =" + Label6.Text;

            Response.Redirect(url);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox2.Text;
            Random rnd = new Random();
            string rdnum = (rnd.Next(10000, 99999)).ToString();
            TextBox6.Text = rdnum;
            string to = TextBox2.Text; //To address    
            string from = "emailmkagr@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);
            string mailbody = "\n\n\n\n" + "Your OTP is " + rdnum;
            message.Subject = "OTP for E-mail Verification";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("emailmkagr@gmail.com", "aoeripveytppbsur");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}