using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.IO;
using System.Configuration;
namespace PORTAL
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ReportViewer1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select Password from portal where number like '" + TextBox1.Text + "'", con);
            SQLiteDataReader ds1 = cmd.ExecuteReader();
            if (ds1.HasRows)
            {
                while (ds1.Read())
                {
                    Label3.Text = ds1[0].ToString();


                }
            }
            if (Label3.Text == TextBox2.Text)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select Name,Email,Phone,Address,DOB,Gender,number,Photo from portal where number like '" + TextBox1.Text + "'", con);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "DataTableid");

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report2.rdlc");
                this.ReportViewer1.LocalReport.DataSources.Clear();
                
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);


                this.ReportViewer1.LocalReport.DataSources.Add(datasource);
                this.ReportViewer1.LocalReport.Refresh();
            }

            else
            {
                Response.Write("<script>alert('Wrong Password');</script>");

            }


        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select Password,Photo from portal where number like '" + TextBox1.Text + "'", con);
            SQLiteDataReader ds1 = cmd.ExecuteReader();
            if (ds1.HasRows)
            {
                while (ds1.Read())
                {
                    Label3.Text = ds1[0].ToString();
                    Label4.Text = ds1[1].ToString();

                }
            }
            if (Label3.Text == TextBox2.Text)
            {
                ReportViewer1.Visible = true;
                SQLiteDataAdapter da = new SQLiteDataAdapter("select Name,Email,Phone,Address,DOB,Gender,number,Photo from portal where number like '" + TextBox1.Text + "'", con);
                //SQLiteDataReader ds2 = cmd.ExecuteReader();
                //if (ds2.HasRows)
                //{
                //    while (ds2.Read())
                //    {
                //       // label23 .Text = ds[0].ToString();
                //       // Label1.Text = ds2[0].ToString();
                //       // Label2.Text = ds2[1].ToString();
                //       // Label3.Text = ds2[2].ToString();
                //       // Label4.Text = ds2[3].ToString();
                //       // Label5.Text = ds2[4].ToString();
                //       // Label6.Text = ds2[5].ToString();
                //       // Label8.Text = ds2[6].ToString();
                //        Label3.Text = ds2[7].ToString();
                //    }
                //}
                Image1.ImageUrl = Label4.Text;
                string imgpath2 = Label4.Text;

                DataSet1 ds = new DataSet1();
                da.Fill(ds, "DataTableid");
                string FolderPath = Server.MapPath("Photo");
                string filepath = string.Empty;
                string ext = string.Empty;
                if (File.Exists(FolderPath))
                {

                    filepath = FolderPath;
                    ext = "jpg";
                   // Image1.ImageUrl = " ~/ UserImages / 123345IMG-20220721-WA0000.jpg";

                }

            //    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc");
            //    ReportViewer1.LocalReport.EnableExternalImages = true;
            //    string imagePath = new Uri(Server.MapPath("~/images/Mudassar.jpg")).AbsoluteUri;
              //  ReportParameter parameter = new ReportParameter("ImagePath", imgPath);
               // ReportViewer1.LocalReport.SetParameters(parameter);
               // ReportViewer1.LocalReport.Refresh();

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report2.rdlc");
                this.ReportViewer1.LocalReport.EnableExternalImages = true;//extra
                string imgpath = new Uri(Server.MapPath(imgpath2)).AbsoluteUri;
                this.ReportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                ReportParameter parameter = new ReportParameter("ImagePath", imgpath);//extra
                this.ReportViewer1.LocalReport.SetParameters(parameter);//extra
             //  ReportViewer1.LocalReport.Refresh();//extra

                this.ReportViewer1.LocalReport.DataSources.Add(datasource);
                    this.ReportViewer1.LocalReport.Refresh();


                    //  SqlConnection con = new SqlConnection("Server=Server;database=test;user=sa;password=tech27");
                    //SqlDataAdapter da = new SqlDataAdapter("select productName,productNo from Products", con);
                    //  DataSet ds = new DataSet();
                    //da.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //DataColumn dc = new DataColumn("productImage", typeof(System.Byte[]));
                    //DataColumn dc1 = new DataColumn("ImageType", typeof(System.String));
                    //dt.Columns.Add(dc);
                    //dt.Columns.Add(dc1);

                    //foreach (DataRow row in dt.Rows)
                    //{
                    //    string FolderPath = Server.MapPath("Images");
                    //    string filepath = string.Empty;
                    //    string ext = string.Empty;
                    //    if (Directory.Exists(FolderPath))
                    //    {
                    //        if (File.Exists(FolderPath + "\\" + row["productName"].ToString() + ".jpg"))
                    //        {
                    //            filepath = FolderPath + "\\" + row["productName"].ToString() + ".jpg";
                    //            ext = "jpg";


                    //        }
                    //        else if (File.Exists(FolderPath + "\\" + row["productName"].ToString() + ".png"))
                    //        {
                    //            filepath = FolderPath + "\\" + row["productName"].ToString() + ".png";
                    //            ext = "png";

                    //        }
                    //        else if (File.Exists(FolderPath + "\\" + row["productName"].ToString() + ".gif"))
                    //        {
                    //            filepath = FolderPath + "\\" + row["productName"].ToString() + ".gif";
                    //            ext = "gif";

                    //        }
                    //        else
                    //        {
                    //            filepath = FolderPath + "\\" + "noimage.png";
                    //            ext = "png";

                    //        }

                    //    }
                    //    row["productImage"] = Getimage(filepath);
                    //    row["ImageType"] = "image/" + ext;


                    //}
                

            }
            else
            {
                Response.Write("<script>alert('Wrong Password');</script>");

            }
            


        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Warning[] warnings;
            string[] streamIds;
            string contentType;
            string encoding;
            string extension;
            string name = TextBox1.Text;

            byte[] bytes = ReportViewer1.LocalReport.Render(rbFormat.SelectedItem.Value, null, out contentType, out encoding, out extension, out streamIds, out warnings);


            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + name + "." + extension);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();

            //Response.Redirect("~//ad.aspx");
        }
    }
}