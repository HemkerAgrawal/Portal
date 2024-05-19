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
using System.Drawing;

namespace PORTAL
{ 
 public partial class WebForm1 : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
			CheckBox1.Checked = false;
			CheckBox2.Checked = false;
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
				
				
				//const int bmpW = 600;

				//const int bmpH = 450;

				const int bmpW = 150;

				const int bmpH = 200;
				string filePath = "";
				if ((FileUpload1.HasFile))
				{
					string x  = "";
					if ((CheckFileType(FileUpload1.FileName)))
					{
						Int32 newWidth = bmpW;
						Int32 newHeight = bmpH;
						String upName = FileUpload1.FileName.Substring(0, FileUpload1.FileName.IndexOf("."));
						filePath = ("~/UserImage/") + upName + ".jpg";
						Bitmap upBmp = (Bitmap)Bitmap.FromStream(FileUpload1.PostedFile.InputStream);
						Bitmap newBmp = new Bitmap(newWidth, newHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
						newBmp.SetResolution(72, 72);
						Double upWidth = upBmp.Width;
						Double upHeight = upBmp.Height;
						int newX = 0;
						int newY = 0;
						Double reDuce;
						if (upWidth > upHeight)
						{


							reDuce = newWidth / upWidth;



							newHeight = ((Int32)(upHeight * reDuce));



							newY = ((Int32)((bmpH - newHeight) / 2));



							newX = 0;

						}

						else if (upWidth < upHeight)
						{


							reDuce = newHeight / upHeight;



							newWidth = ((Int32)(upWidth * reDuce));



							newX = ((Int32)((bmpW - newWidth) / 2));



							newY = 0;

						}

						else if (upWidth == upHeight)
						{


							reDuce = newHeight / upHeight;



							newWidth = ((Int32)(upWidth * reDuce));
							newX = ((Int32)((bmpW - newWidth) / 2));
							newY = ((Int32)((bmpH - newHeight) / 2));


						}


						Graphics newGraphic = Graphics.FromImage(newBmp);

						try
						{

							newGraphic.Clear(Color.White);

							newGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

							newGraphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

							newGraphic.DrawImage(upBmp, newX, newY, newWidth, newHeight);

							newBmp.Save(MapPath(filePath), System.Drawing.Imaging.ImageFormat.Jpeg);
							Label2.Text = "Saved ";
						}
						catch (Exception ex)
						{
							string newError = ex.Message;
							x = newError; ///label2.text
						}

						finally
						{

							upBmp.Dispose();

							newBmp.Dispose();

							newGraphic.Dispose();

						}
					}

					else
					{

						//Label2.Text = "Please select a picture with a file format extension of either Bmp, Jpg, Jpeg, Gif or Png.";

					}

					// FileUpload1.SaveAs(@"C:\Users\lenovo\source\repos\mytproject\image\" + Path.GetFileName(FileUpload1.FileName));
				}







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
						cmdc.Parameters.AddWithValue("@Photo", filePath);
						//	cmdc.Parameters.AddWithValue("@Photo", " ~/ UserImages / " + TextBox3.Text + fname);
				cmdc.Parameters.AddWithValue("@Doc", " ~/ UserDoc / " + TextBox3.Text + fname2);
						int k2 = cmdc.ExecuteNonQuery();
					if (k2 != 0)
					{
						//Label1.Text = "Details saved successfully!";
						Label1.ForeColor = System.Drawing.Color.Green;
				        Response.Write("<script>alert('Registration successfully done.');</script>");
							clear();
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



            //string url;
            //url = "details.aspx?name =" + TextBox2.Text;
            //Response.Redirect(url);


            //string url;
            //url = "email_verification.aspx";//?name =" + TextBox2.Text;

            //Response.Redirect(url);

            //Random rnd = new Random();
            //string rdnum = (rnd.Next(10000, 99999)).ToString();
            //TextBox6.Text = rdnum;
            //string to = TextBox2.Text; //To address    
            //string from = "emailmkagr@gmail.com"; //From address    
            //MailMessage message = new MailMessage(from, to);
            //string mailbody = "Hello! " + TextBox1.Text + ",\n\n\n\n" + "Your OTP is " + rdnum;
            //message.Subject = "OTP for sign up";
            //message.Body = mailbody;
            //message.BodyEncoding = Encoding.UTF8;
            //message.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            //System.Net.NetworkCredential basicCredential1 = new
            //System.Net.NetworkCredential("emailmkagr@gmail.com", "aoeripveytppbsur");
            //client.EnableSsl = true;
            //client.UseDefaultCredentials = false;
            //client.Credentials = basicCredential1;
            //try
            //{
            //    client.Send(message);
            //}

            //catch (Exception ex)
            //{
            //    throw ex;
            //}

        }
		public bool CheckFileType(string fileName)
			{

				string ext = Path.GetExtension(fileName);

				switch (ext.ToLower())
				{

					case ".gif":

						return true;

					case ".png":

						return true;

					case ".jpg":

						return true;

					case ".jpeg":

						return true;

					case ".bmp":

						return true;

					default:

						return false;

			}
		}

        public void clear()
        {
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox7.Text = "";
			Button6.ForeColor = System.Drawing.Color.Green;
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

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
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
					Label6.Text = ds[1].ToString();
				//	Label3.Text = ds[2].ToString();
				//	Label4.Text = ds[3].ToString();
				//	Label5.Text = ds[4].ToString();
				//	Label6.Text = ds[5].ToString();
				//	Label8.Text = ds[6].ToString();
					//label9.Text = ds[7].ToString();



				}
			}
			string url;
			url = "email_verification.aspx?name";// =" + Label6.Text;

			Response.Redirect(url);
		}

		protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBox1.Checked == true)
			{
				CheckBox2.Checked = false;
			}
            else
            {
				CheckBox1.Checked = true;
            }
		
		}

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
			if(CheckBox2.Checked==true)
            {
				CheckBox1.Checked = false;
            }
            else
            {
				CheckBox2.Checked = true;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
			if (CheckBox1.Checked == true)
			{
				CheckBox2.Checked = false;
			}
			else
			{
				CheckBox1.Checked = true;
			}
		}

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
			if (CheckBox2.Checked == true)
			{
				CheckBox1.Checked = false;
			}
			else
			{
				CheckBox2.Checked = true;
			}
		}

        protected void Button9_Click(object sender, EventArgs e)
        {
			string url;
			url = "admit_card.aspx?name";// =" + Label6.Text;

			Response.Redirect(url);
		}

        protected void Button6_Click(object sender, EventArgs e)
        {
			string url;
			url = "register.aspx"; //?name =" + Label6.Text;

			Response.Redirect(url);
		}

        protected void Button8_Click(object sender, EventArgs e)
        {
			string url;
			url = "payment.aspx"; //?name =" + Label6.Text;

			Response.Redirect(url);
		}

        protected void Button9_Click1(object sender, EventArgs e)
        {
			string url;
			url = "admit_card.aspx"; //?name =" + Label6.Text;

			Response.Redirect(url);
		}

        protected void Button6_Click1(object sender, EventArgs e)
        {
			string url;
			url = "register.aspx"; //?name =" + Label6.Text;

			Response.Redirect(url);
		}

        protected void Button8_Click1(object sender, EventArgs e)
        {

        }
    }

}
