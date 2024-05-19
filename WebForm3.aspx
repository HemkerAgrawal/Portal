<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="PORTAL.WebForm3" %>

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
    <form id="form1" runat="server">
         <div class="col-4"></div>
         <asp:Label Text=" Enter Email" CssClass="labelb" runat="server"/>
                 <br><br />
             <asp:TextBox ID="TextBox1" runat="server" CssClass="textb" placeholder="Enter Name" OnTextChanged="TextBox1_TextChanged1" Width="203px"/>  
              <br /><br>
              <asp:Label Text=" Enter Password" CssClass="labelb" runat="server"/>
             <br /><br>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="textb" placeholder="Enter Email"/> 
        <br><br>
  <asp:Button ID="Button1" text="LOGIN" CssClass="but" runat="server" OnClick="Button1_Click" />&nbsp;&nbsp;
             
    <br>  <br><br />

                 <br><br />
         <asp:Label ID="Label1" runat="server" Text="Label" Visible="true"></asp:Label>
             <p>
                 &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
         </p>
         <p>
             <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
         </p>
         <p>
             <asp:Label ID="Label2" runat="server" Text="APPLICATION NUMBER"></asp:Label>
         </p>
         <p>
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         </p>
         <p>
             <asp:Button ID="Button2" runat="server" Text="ADMIT CARD" OnClick="Button2_Click" />
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
         </p>
             </form>

    </body>
</html>
