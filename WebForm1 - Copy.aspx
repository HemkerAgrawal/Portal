<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PORTAL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .but {
            height: 35px;
        }
    </style>
</head>
<body>
   <%--<form id="form1" runat="server">--%>
        <div>
            <div>
            <br>
          <form id="form1" runat="server" class="box">
              <div class="col-4"></div>
              <div class="col-4">
                  <h2>Form</h2>
              <br /><br />
               
                <asp:Label Text=" Enter Name" CssClass="labelb" runat="server"/>
                 <br><br />
             <asp:TextBox ID="TextBox1" runat="server" CssClass="textb" placeholder="Enter Name"/>  
              <br /><br>
              <asp:Label Text=" Enter Email" CssClass="labelb" runat="server"/>
             <br /><br>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="textb" placeholder="Enter Email"/> 
              <br><br>
              <asp:Label Text=" Enter Phone" CssClass="labelb" runat="server"/>
              <br /><br>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="textb" placeholder="Enter Phone"/> 
              <br /><br>
              <asp:Label Text=" Enter Address" CssClass="labelb" runat="server"/>
              <br /><br>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="textb" placeholder="Enter Address"/> 
              <br /><br>
               <asp:Label Text="DOB" CssClass="labelb" runat="server"/>
              <br /><br>
             <asp:TextBox ID="TextBox7" runat="server" CssClass="textb" placeholder="mm/dd/yyyy" TextMode="Date"/> 
                  <br><br>
            <asp:Label Text="PASSWORD" CssClass="labelb" runat="server"/>
              <br><br>    
          <asp:TextBox ID="TextBox8" runat="server" CssClass="textb" placeholder="Enter Address"/>
              <br /><br>
                 <asp:Label Text="Gender" CssClass="labelb" runat="server"/>
              <br /><br />
              <asp:CheckBox ID="CheckBox1" runat="server" />Male&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:CheckBox ID="CheckBox2" runat="server" />Female
              <asp:RadioButton ID="RadioButton1" runat="server" Visible="false" />
              <asp:RadioButton ID="RadioButton2" runat="server" Visible="false"/>
              <br /><br>
            
              <asp:Label Text="Photo" CssClass="labelb" runat="server"/>
              <br /><br>
              <asp:FileUpload ID="FileUpload1" runat="server"/> 
              <br /><br>
               <asp:Label Text="ID" CssClass="labelb" runat="server"/>
              <br /><br>
              <asp:FileUpload ID="FileUpload2" runat="server"/> 
              <br /><br>
               <asp:Button ID="Button4" text="ENTER(REGISTER)" CssClass="but" runat="server" OnClick="Button4_Click" />&nbsp;&nbsp;
           <asp:Label ID="Label1" runat="server"></asp:Label><br>
                      <asp:Button ID="Button5" text="Send OTP(Email)" CssClass="but" runat="server"  Visible="false"/>
              <asp:Button ID="Button3" Text="SAVE2(POST)" CssClass="but" runat="server"  visible="false"/>
                  <asp:TextBox ID="TextBox9" runat="server" Visible="false"></asp:TextBox>
                <br><br />
            <asp:Button ID="Button2" text="SAVE(GET)" CssClass="but" runat="server" Visible="false" />
              <tb>
              <br /><br>
              <asp:Label Text="OTP" CssClass="labelb" runat="server"/> 
              <br /><br>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="textb" placeholder="OTP"/> 
              <br /><br>
           <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
              <br /><br>
           <asp:Button ID="Button1" text="ENTER(OTP CHECK)" CssClass="but" runat="server" OnClick="Button1_Click"/>
          
     
            
             <asp:Label ID="Label2" runat="server"></asp:Label>
                  </div><br><br>
          
     
            
              <br>
             <asp:Label ID="Label5" runat="server"></asp:Label><br>
        

              <br><br>
          
            </form>
            </div>
     
        </div>

    </form>
</body>
</html>
