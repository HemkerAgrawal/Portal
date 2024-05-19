<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="PORTAL.WebForm4" %>

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
             <div class="row">
              <%--<div class="col-4">
              </div>--%>
                <div class="col-3 t mx-auto align-self-center">
                <%--  <h2>Form</h2>--%>
                  <asp:Button ID="Button6" runat="server" Text="Registration" Width="200px" OnClick="Button6_Click"/>
                  </div>
                  <div class="col-3 t mx-auto align-self-center">
                  <asp:Button ID="Button7" runat="server" Text="E-mail Verification" Width="200px" OnClick="Button7_Click" />
                        </div>
                    <div class="col-3 t mx-auto align-self-center">
                  <asp:Button ID="Button8" runat="server" Text="Payment" Width="200px" OnClick="Button8_Click" />
                        </div>
                    <div class="col-3 t mx-auto lign-self-center">
                  <asp:Button ID="Button9" runat="server" Text="Admit Card " Width="200px" OnClick="Button9_Click" />
                  </div>
            </div>
             </div>
            <br />
            <br />
    <div class="container">
        <br />
        <br />
        CANDIDATE DETAILS <br />
        <br />
        <p>
        Name<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        <p>
            Email<br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Phone<br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Address<br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            DOB<br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Gender<br />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Application Number<br />
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label7" runat="server" ></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:TextBox ID="TextBox1" runat="server" Visible="false" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>

        </div>
    </form>
</body>
</html>
