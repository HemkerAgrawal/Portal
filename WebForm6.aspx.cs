using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WinForms;
using System.Data.SQLite;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.IO;
using System.Configuration;

namespace PORTAL
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //    SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            //    con.Open();


            //    SQLiteDataAdapter da = new SQLiteDataAdapter("select Name,Email,Phone,Address,DOB,Gender,number from portal where Email like '" + TextBox1.Text + "'", con);
            //    DataSet1 ds = new DataSet1();
            //    da.Fill(ds, "DataTableid");

            //    ReportDataSource datasource = new ReportDataSource("DataSetN", ds.Tables[0]);

            //  this.ReportViewer1.LocalReport.DataSources.Clear();
            // this.ReportViewer1.LocalReport.DataSources.Add(datasource);
            // this.ReportViewer1.ReportRefresh();
            //   this.ReportViewer1.RefreshReport();string contentType = string.Empty;  
            //string contentType = string.Empty;
            //if (ddlFileFormat.SelectedValue.Equals(".pdf"))
            //    contentType = "application/pdf";
            //DataTable dsData = new DataTable();
            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
            con.Open();


            SQLiteDataAdapter da = new SQLiteDataAdapter("select Name,Email,Phone,Address,DOB,Gender,number from portal where Email like '" + TextBox1.Text + "'", con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTableid");

          //  ReportViewer1.ProcessingMode =ProcessingMode.Local;
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

            //this.ReportViewer.LocalReport.DataSources.Clear();
            //this.ReportViewer1.LocalReport.DataSources.Add(datasource);
            //this.ReportViewer1.ReportRefresh();
            //this.ReportViewer1.RefreshReport();
            //dsData =ds.Tables[0];

            //string FileName = "File_" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ddlFileFormat.SelectedValue;
            //string extension;
            //string encoding;
            //string mimeType;
            //string[] streams;
            //Warning[] warnings;

            //LocalReport report = new LocalReport();
            //report.ReportPath = Server.MapPath("~/Report1.rdlc");
            //ReportDataSource rds = new ReportDataSource();
            //rds.Name = "DataSet1";//This refers to the dataset name in the RDLC file  
            //rds.Value = dsData;
            //report.DataSources.Add(rds);

            //Byte[] mybytes = report.Render(ddlFileFormat.SelectedItem.Text, null,
            //                out extension, out encoding,
            //                out mimeType, out streams, out warnings); //for exporting to PDF  
            //using (FileStream fs = File.Create(Server.MapPath("~/download/") + FileName))
            //{
            //    fs.Write(mybytes, 0, mybytes.Length);
            //}

            //Response.ClearHeaders();
            //Response.ClearContent();
            //Response.Buffer = true;
            //Response.Clear();
            //Response.ContentType = contentType;
            //Response.AddHeader("Content-Disposition", "attachment; filename=" + FileName);
            //Response.WriteFile(Server.MapPath("~/download/" + FileName));
            //Response.Flush();
            //Response.Close();
            //Response.End();
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {

        }


        //private DataTable getReportData()
        //{
        //    SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
        //    con.Open();


        //    SQLiteDataAdapter da = new SQLiteDataAdapter("select Name,Email,Phone,Address,DOB,Gender,number from portal where Email like '" + TextBox1.Text + "'", con);
        //    DataSet1 ds = new DataSet1();
        //    da.Fill(ds, "DataTableid");

        //    ReportDataSource datasource = new ReportDataSource("DataSetN", ds.Tables[0]);

        //    this.ReportViewer1.LocalReport.DataSources.Clear();
        //    this.ReportViewer1.LocalReport.DataSources.Add(datasource);
        //    this.ReportViewer1.ReportRefresh();
        //    this.ReportViewer1.RefreshReport(); 
        //    //string contentType = string.Empty;
        //    //SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\lenovo\source\repos\PORTAL\portal.db;Version=3;Mode=ReadWrite;New=False;Compress=True;");
        //    //DataSet dsData = new DataSet();
        //    //SqlConnection sqlCon = null;
        //    //SqlDataAdapter sqlCmd = null;

        //    //try
        //    //{
        //    //    using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
        //    //    {
        //    //        sqlCmd = new SqlDataAdapter("USP_GETEmployeeDetails", sqlCon);
        //    //        sqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;

        //    //        sqlCon.Open();
        //    //        sqlCmd.Fill(dsData);

        //    //        sqlCon.Close();
        //    //    }
        //    //}
        //    //catch
        //    //{
        //    //    throw;
        //    //}
        //    //return dsData.Tables[0];
        //}
    }
}
