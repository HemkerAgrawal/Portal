<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="PORTAL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
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
                         <li class="nav-item"><a class="nav-link" href="register.aspx"><span class="fa fa-address-card fa-lg border-dark"></span>REGISTER</a></li>
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
                  <asp:Button ID="Button6" runat="server" Text="Registration" Width="200px" OnClick="Button6_Click1" />
                  </div>
                  <div class="col-3 t mx-auto align-self-center">
                  <asp:Button ID="Button7" runat="server" Text="E-mail Verification" Width="200px" OnClick="Button7_Click" />
                        </div>
                    <div class="col-3 t mx-auto align-self-center">
                  <asp:Button ID="Button8" runat="server" Text="Payment" Width="200px" OnClick="Button8_Click" />
                        </div>
                    <div class="col-3 t mx-auto lign-self-center">
                  <asp:Button ID="Button9" runat="server" Text="Admit Card " Width="200px" OnClick="Button9_Click1" />
                  </div>
            </div>
         <%--   <div class="col-8 t">
                <asp:Label Text=" WELCOME TO THE PORTAL" CssClass="labelb" runat="server"/>
                </div>--%>
           <%-- </div>--%>
        <%--  <div class="col-4 t">
                <br />
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
                  </div>--%>
           <br />
           <br />
           <div class="container">
            <div class="row">
              <%--  <div class="col-8 t">--%>
                <asp:Label Text="Name" CssClass="labelb" runat="server"/>
                <br />
             <asp:TextBox ID="TextBox1" runat="server" CssClass="textb" placeholder="Enter Name" Width="500px"/>  
                </div>
              <br/>
                <div class="row">
              <asp:Label Text="Email" CssClass="labelb" runat="server"/>
             <br/>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="textb" placeholder="Enter Email" Width="500px"/> 
              </div>
              <br/>
                <div class="row">
              <asp:Label Text="Phone" CssClass="labelb" runat="server"/>
              <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="textb" placeholder="Enter Phone" Width="500px"/> 
                </div>
               <br />

                 <div class="row">
              <asp:Label Text="Address" CssClass="labelb" runat="server"/>
              <br />
            <asp:TextBox ID="TextBox4" runat="server" CssClass="textb" placeholder="Enter Address" Width="600px"/> 
               </div>
               <br />

               <div class="row">
               <asp:Label Text="DOB" CssClass="labelb" runat="server"/>
              <br />
             <asp:TextBox ID="TextBox7" runat="server" CssClass="textb" placeholder="mm/dd/yyyy" TextMode="Date" Width="500px"/> 
                  </div>
               <br />    <br/>

            <div class="row">
               <asp:Label Text="Gender:" CssClass="labelb" runat="server"/>
              <asp:CheckBox ID="CheckBox1" runat="server" Text="Male" Width="100px" OnCheckedChanged="CheckBox1_CheckedChanged"/><br/>
              <asp:CheckBox ID="CheckBox2" runat="server" Text="Female" Width="100px" OnCheckedChanged="CheckBox2_CheckedChanged"/>
              <asp:RadioButton ID="RadioButton1" runat="server" Visible="false" OnCheckedChanged="RadioButton1_CheckedChanged" />
              <asp:RadioButton ID="RadioButton2" runat="server" Visible="false" OnCheckedChanged="RadioButton2_CheckedChanged"/>
                </div>
               <br />
               <br />

              <div class="row">
              <asp:Label Text="Photo" CssClass="labelb" runat="server"/>
              <br />
              <asp:FileUpload ID="FileUpload1" runat="server" Width="349px"/>
                   </div>
              <br />
               <div class="row">
               <asp:Label Text="ID" CssClass="labelb" runat="server"/>
              <br />
              <asp:FileUpload ID="FileUpload2" runat="server"/> 
               </div>
               <br /><br />

               <div class="row">
               <asp:Label Text="PASSWORD" CssClass="labelb" runat="server"/>
              <br/> 
              <asp:TextBox ID="TextBox8" runat="server" CssClass="textb" placeholder="Enter Password" OnTextChanged="TextBox8_TextChanged" Width="300px"/>
              <br/>
              <div />
              <br />
              <br />
              <asp:Button ID="Button4" text="REGISTER" CssClass="but" runat="server" OnClick="Button4_Click" />&nbsp;&nbsp;
          <br />
         <br />
                  <asp:Label ID="Label1" runat="server"></asp:Label><br/>
                   <br />
                   <br />
                   <br />

                    <!--  <asp:Button ID="Button5" text="Send OTP(Email)" CssClass="but" runat="server"  Visible="false"/>
              <asp:Button ID="Button3" Text="SAVE2(POST)" CssClass="but" runat="server"  visible="false"/>
                  <asp:TextBox ID="TextBox9" runat="server" Visible="false"></asp:TextBox>
                <br/><br />
            <asp:Button ID="Button2" text="SAVE(GET)" CssClass="but" runat="server" Visible="false" OnClick="Button2_Click" />
              <tb>
              <br /><br/>
              <asp:Label Text="OTP" CssClass="labelb" runat="server"/> 
              <br /><br/>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="textb" placeholder="OTP"/> 
              <br /><br/>
           <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
              <br /><br/>
           <asp:Button ID="Button1" text="ENTER(OTP CHECK)" CssClass="but" runat="server" OnClick="Button1_Click"/>
             <asp:Label ID="Label2" runat="server"></asp:Label>
                <%--  </div>--%>
            <br/><br/>
              <br/>
             <asp:Label ID="Label5" runat="server"></asp:Label><br>
        

              <br/>
                  <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                  <br/>-->
                  </div>
          </div>
        </div>
            </form>
           <%-- </div>
     
        </div>

    </form>--%>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
