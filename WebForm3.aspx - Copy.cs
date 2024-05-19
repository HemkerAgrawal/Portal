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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Mail;


namespace PORTAL
{
    public partial class WebForm3 : System.Web.UI.Page
    //DataTable dt = new DataTable();
    {
        
        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Response.Redirect("Please fill the details");
            }
            else
            {

                SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
                con.Open();


                SQLiteCommand cmd = new SQLiteCommand("select Password from portal where Email like '" + TextBox1.Text + "'", con);
                SQLiteDataReader ds = cmd.ExecuteReader();
                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                        Label1.Text = ds[0].ToString();


                    }
                }

                if (Label1.Text == TextBox2.Text)
                {
                    Response.Redirect("successfully login");

                    //Form3 frm = new Form3();
                    //frm.Show();
                    //this.Close();
                }




                else
                {
                    Response.Redirect("wrong password");
                }
            }
        }
    

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                if (TextBox1.Text == "" || TextBox2.Text == "")
                {
                    Response.Redirect("Please fill the details");
                }
                else
                {

                    SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
                    con.Open();


                    SQLiteCommand cmd = new SQLiteCommand("select Password from portal where Email like '" + TextBox1.Text + "'", con);
                    SQLiteDataReader ds = cmd.ExecuteReader();
                    if (ds.HasRows)
                    {
                        while (ds.Read())
                        {
                            Label1.Text = ds[0].ToString();


                        }
                    }

                    if (Label1.Text == TextBox2.Text)
                    {
                        //   (object sender, System.Eventargs e)
                        
                            string url;
                            url = "WebForm4.aspx?name ="+TextBox1.Text;
                        
                        Response.Redirect(url);
                        //Form3 frm = new Form3(); 
                        //frm.Show();
                        //this.Close();
                    }

                   // ~//
                    else
                    {
                        Response.Write("wrong password");
                    }
                }
            }

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

            //if (TextBox1.Text == "" || TextBox2.Text == "")
            //{
            //    Response.Redirect("Please fill the details");
            //}
            //else
            //{

                SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
                con.Open();


                SQLiteCommand cmd = new SQLiteCommand("select Password from portal where Email like '" + TextBox1.Text + "'", con);
                SQLiteDataReader ds = cmd.ExecuteReader();
                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                        Label1.Text = ds[0].ToString();


                    }
                }

                //if (Label1.Text == TextBox2.Text)
                //{
                //    Response.Redirect("successfully login");
                //    //Form3 frm = new Form3();
                //    //frm.Show();
                //    //this.Close();
                //}




                else
                {
                    Response.Redirect("wrong password");
                }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//WebForm7.aspx");

            //if (TextBox1.Text == "" || TextBox2.Text == "")
            //{
            //    Response.Redirect("Please fill the details");
            //}
            //else
            //{

            //    SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            //    con.Open();


            //    SQLiteCommand cmd = new SQLiteCommand("select number from portal where Email like '" + TextBox4.Text + "'", con);
            //    SQLiteDataReader ds = cmd.ExecuteReader();
            //    if (ds.HasRows)
            //    {
            //        while (ds.Read())
            //        {
            //            Label4.Text = ds[0].ToString();


            //        }
            //    }

            //    if (Label4.Text == TextBox3.Text)
            //    {
            //        //   (object sender, System.Eventargs e)

            //        string url;
            //        url = "WebForm6.aspx?name =" + TextBox4.Text;

            //        Response.Redirect(url);
            //        //Form3 frm = new Form3(); 
            //        //frm.Show();
            //        //this.Close();
            //    }

            //    // ~//


            //    else
            //    {
            //        Response.Redirect("wrong number");
            //    }
            //}
        }
    }
    }
    

