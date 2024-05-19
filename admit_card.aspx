<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admit_card.aspx.cs" Inherits="PORTAL.WebForm7" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="style.css" rel="stylesheet"/>
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
     <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
  
   <%-- <style type="text/css">
        .but {
            height: 35px;
        }
    </style>--%>
</head>
<body>

   <%--<form id="form1" runat="server">--%>
       <%-- <div>
            <div>
            <br>--%>
        <%--  <form id="form1" runat="server" class="box">--%>
    <form id="form1" runat="server">
    <header>
    <div class="jumbotron mt-0">
        <div class="container">
            <div class=" row row-header">
                <div class="col-12 col-sm-6">
                    <h1>PORTAL</h1>
                    <p>Dumyee Portal</p>
                </div>      
            </div>
        </div>
    </div>
         <nav class="navbar navbar-dark navbar-expand-sm fixed-top">
             <div class="container">
                 <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#Navbar">
                     <span class="navbar-toggler-icon"></span>
                 </button>

                 <%--   <a class="navbar-brand mr-auto" href="#"><img src="img/logo.png" height="30" width="41"></a>--%>
                 <div class="collapse navbar-collapse" id="Navbar">
                     <ul class="navbar-nav mr-auto">
                         <li class="nav-item"><a class="nav-link" href="register.aspx"><span class="fa fa-address-card fa-lg"></span>REGISTER</a></li>
                         <li class="nav-item"><a class="nav-link" href="email_verification.aspx"><span class="fa fa-address-card fa-lg"></span>E-MAIL VERIFICATION</a></li>
                         <li class="nav-item"><a class="nav-link" href="payment.aspx"><span class="fa fa-address-card fa-lg"></span>PAYMENT</a></li>
                         <li class="nav-item"><a class="nav-link" href="admit_card.aspx"><span class="fa fa-address-card fa-lg"></span>ADMIT CARD</a></li>
                         </ul>
                 </div>
             </div>
    </nav>
  </header>
        <div class="container">
 
        <p>
            &nbsp;</p>
        
            <asp:Label ID="Label2" runat="server" Text="Application Number"></asp:Label>
        <br/>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br/>
          <br/>
        <%--<p>--%>
            <asp:Label ID="Label1" runat="server" Text="PASSWORD"></asp:Label>
      <%--  </p>--%>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 6px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
            <p>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="VIEW ADMIT CARD" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GENERATE ADMIT CARD" Visible="False" />
         
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="DOWNLOAD ADMIT CARD" />
&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="false"></asp:Label>
            <asp:Image ID="Image1" runat="server" Height="171px" Visible="False" />

        </p>

             <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="913px" ShowExportControls="False" ShowPrintButton="False">
            <LocalReport ReportPath="Report2.rdlc" EnableExternalImages="True">
            </LocalReport>
        </rsweb:ReportViewer>
        &nbsp;&nbsp;&nbsp;
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
            <br />
            <br />
            <asp:RadioButtonList ID="rbFormat" runat="server" Visible="False">
                <asp:ListItem Selected="True" Text="pdf" Value="PDF" />
            </asp:RadioButtonList>
            </div>
        <br />
        <br />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
