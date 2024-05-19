using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Data.SQLite;
using System.Net.Mail;


namespace PORTAL
{ 
 public partial class WebForm1 : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Button4_Click(object sender, EventArgs e)
	{
			Random rnd1 = new Random();
			string rdnum1 = (rnd1.Next(1000, 99999)).ToString();
			TextBox9.Text = rdnum1;
			SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
		con.Open();

		if (FileUpload1.HasFile)
		{
			string spath = Path.GetExtension(FileUpload1.PostedFile.FileName);
			if (spath != ".jpeg" && spath != ".jpg" && spath != ".png" && spath != ".gif")
			{
				Label1.Text = "Only jpeg, jpg, png or gif Image is allowed!";
				Label1.ForeColor = System.Drawing.Color.Red;
			}

			string fname = Path.GetFileName(FileUpload1.PostedFile.FileName);
			FileUpload1.SaveAs(Server.MapPath("~/UserImage/") + TextBox3.Text + fname);
			Label1.Text = "Image Saved!";
			Label1.ForeColor = System.Drawing.Color.Green;
			string gender = string.Empty;
			//if (RadioButton1.Checked ==true)
			//{
			//   RadioButton2.Checked = false;
			//	gender = "Male";
			//}
			//else if (RadioButton2.Checked==true)
			//{
			//     	RadioButton1. = false;
			//                	gender = "Female";
			//}
			//else
			//               {
			//    	gender ="";
			//               }
			if (CheckBox1.Checked == true && CheckBox2.Checked == false)
			{
				gender = "Male";
			}
			else if (CheckBox2.Checked == true && CheckBox1.Checked == false)
			{
				gender = "Female";
			}
			else
			{
				gender = "";
			}
			TextBox6.Text = gender;
			if (FileUpload2.HasFile)
			{
				string spath2 = Path.GetExtension(FileUpload2.PostedFile.FileName);
				if (spath2 != "pdf")
				{
					Label1.Text = "Only pdf of Document is allowed!";
					Label1.ForeColor = System.Drawing.Color.Red;
				}
				string fname2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
				FileUpload2.SaveAs(Server.MapPath("~/UserDoc/") + TextBox3.Text + fname2);
				Label1.Text = "Document saved";
				Label1.ForeColor = System.Drawing.Color.Green;

			//	string query = "insert into portal values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "','" + TextBox7.Text + "','" + TextBox6.Text + "','" + "~/UserImages/" + fname + "','" + "~/UserDoc/" + fname2 + "' ,'" + TextBox8.Text + "','" + TextBox9.Text + "')";

			//	SQLiteCommand cmd = con.CreateCommand();
			//	cmd.CommandText = query;
			//	int k = cmd.ExecuteNonQuery();
				if (TextBox1.Text != null && TextBox2.Text != null && TextBox3.Text != null && TextBox4.Text != null && TextBox7.Text != "" && gender != "" && TextBox8.Text != null)

					{
					SQLiteCommand cmdc = new SQLiteCommand("insert into portal values(@Name,@Email,@Phone,@Address,@DOB,@Gender,@Photo,@Doc,@Password,@number)", con);
					cmdc.Parameters.AddWithValue("@Name", TextBox1.Text);
					cmdc.Parameters.AddWithValue("@Email", TextBox2.Text);
					cmdc.Parameters.AddWithValue("@Phone", TextBox3.Text);
					cmdc.Parameters.AddWithValue("@Address", TextBox4.Text);
					cmdc.Parameters.AddWithValue("@DOB", TextBox7.Text);
			        cmdc.Parameters.AddWithValue("@Password", TextBox8.Text);
						cmdc.Parameters.AddWithValue("@number", TextBox9.Text);
						cmdc.Parameters.AddWithValue("@Gender", gender);
					cmdc.Parameters.AddWithValue("@Photo", " ~/ UserImages / " + TextBox3.Text + fname);
					cmdc.Parameters.AddWithValue("@Doc", " ~/ UserDoc / " + TextBox3.Text + fname2);
					int k2 = cmdc.ExecuteNonQuery();
					if (k2 != 0)
					{
						Label1.Text = "Details saved successfully!";
						Label1.ForeColor = System.Drawing.Color.Green;
					}
					else if (k2 == 0)
					{
						Label1.Text = "There is some problem!";
						Label1.ForeColor = System.Drawing.Color.Red;
					}
				}
				else
				{
					Label1.Text = "Please insert all the details!";
					Label1.ForeColor = System.Drawing.Color.Red;
				}
			}
			else
			{
				Label1.Text = "Please insert the Document!";
				Label1.ForeColor = System.Drawing.Color.Red;
			}
		}
		else
		{
			Label1.Text = "Please insert Image!";
			Label1.ForeColor = System.Drawing.Color.Red;
		}
	
			con.Close();



            Random rnd = new Random();
            string rdnum = (rnd.Next(10000, 99999)).ToString();
            TextBox6.Text = rdnum;
            string to = TextBox2.Text; //To address    
            string from = "emailmkagr@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);
            string mailbody = "Hello! " + TextBox1.Text + ",\n\n\n\n" + "Your OTP is " + rdnum;
            message.Subject = "OTP for sign up";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("emailmkagr@gmail.com", "Abcd.0000");
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text == TextBox6.Text)
            {
                Label2.Text = "OTP is Correct!";
                Label2.ForeColor = System.Drawing.Color.Green;
                Label2.Visible = true;
				string url;
				url = "WebForm4.aspx?name =" + TextBox2.Text;

				Response.Redirect(url);
			}
            else
            {
                Label2.Text = "Wrong OTP!";
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Visible = true;

            }
        }
    }

}
