<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="PORTAL.payment" %>

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
            <br />
            <br />
            <div row="container">
                Make payment for Examination Fee using the following button:
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button10" runat="server" Text="Pay Examination Fee" OnClick="Button10_Click" />
                <br />
                </div>
                </form>


     <div row="container">
             <%--   <form>
                    <script src="https://checkout.razorpay.com/v1/payment-button.js" data-payment_button_id="pl_HjVWHIbZxFnqu5" async></script>
            </form>
    
                <script>
                    function.myfunction2(){
                        document.getElementById("t").innerHTML = "Will be available soon.";
                    }

                </script>--%>

         </div>
      <%--  </form>--%>
</body>
</html>
