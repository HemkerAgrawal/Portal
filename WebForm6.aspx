<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="PORTAL.WebForm6" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1004px;
            height: 681px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting" TypeName="PORTAL.DataSet1TableAdapters."></asp:ObjectDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Button" Height="29px" OnClick="Button1_Click" style="margin-left: 49px; margin-right: 0px" Width="100px" />
        <p>
            &nbsp;</p>
         <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>

   
     <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
         
    <center>  
        <h2>  
            ADMIT CARD</h2>  
        <table width="60%" border="1">  
            <tr>  
                <td>  
                    <asp:DropDownList ID="ddlFileFormat" runat="server">  
                        <asp:ListItem Text="PDF" Value=".pdf"></asp:ListItem>  
                        <asp:ListItem Text="WORD" Value=".doc"></asp:ListItem>  
                        <asp:ListItem Text="EXCEL" Value=".xls"></asp:ListItem>  
                    </asp:DropDownList>  
                </td>  
                <td>  
                      
                </td>  
            </tr>  
        </table>  
    </center>  
   </form>  

</body>
</html>
