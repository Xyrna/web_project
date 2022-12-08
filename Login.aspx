<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <div class="center-y">
        <div class="center-x">
    <form id="form1" runat="server">
        <div>
        </div>
         <h1 class="text" style="padding-left:65px"> Log In </h1>
        <p>
            <asp:TextBox ID="txtUsernameL" CssClass="input" placeholder="Username" Height="30px" runat="server" Font-Size="Larger"></asp:TextBox>
        </p>
        
        
            <asp:TextBox ID="txtPasswordL" CssClass="input"  placeholder="Password" Height="30px" runat="server" Font-Size="Larger"></asp:TextBox>
       
        <p>
            <asp:Button ID="btnLogin" CssClass="button" runat="server" Text="Log In" OnClick="btnLogin_Click" Height="42px" Width="239px" />
        </p>
        <a href="Registration.aspx"  CssClass="btnToLogin" >Create an account</a>
       
    </form>
            </div>
    </div>
</body>
</html>
