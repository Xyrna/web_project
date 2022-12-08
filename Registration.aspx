<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="web_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <div class="center-y">
        <div class="center-x">
            <form id="form1" runat="server">
                <div class="loginbox">
                    <h1 class="text" >Create Account </h1>
                    <%--<img src="dit.PNG" alt="Alternate Text" class="user"/>--%>
                </div>
                <p>
                    <asp:TextBox ID="txtName" placeholder="Name" CssClass="input" runat="server"  Width="150px" Font-Size="Larger"></asp:TextBox>

                    <asp:TextBox ID="txtSurname" placeholder="Surname" CssClass="input" runat="server"  Width="150px" Font-Size="Larger"></asp:TextBox>
                </p>

                <asp:TextBox ID="txtUsername" placeholder="Username" CssClass="input" runat="server"  Width="308px" Font-Size="Larger" ></asp:TextBox>
                <p>

                    <asp:TextBox ID="txtEmail" placeholder="Email" CssClass="input" runat="server"  Width="308px" Font-Size="Larger"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="txtPassword" CssClass="input" placeholder="Password" TextMode="Password" runat="server" Style="margin-bottom: 0px"  Width="150px" Font-Size="Larger"></asp:TextBox>
                    <asp:TextBox ID="txtRptPassword" CssClass="input" placeholder="Confirm" TextMode="Password" runat="server"  Width="150px" Font-Size="Larger"></asp:TextBox>
                </p>
                <p>

                    <asp:Button CssClass="button" ID="Button1" runat="server" Text="Sign up" OnClick="Button1_Click" Height="41px" Width="313px" />

                </p>
                    <a href="Login.aspx"  CssClass="btnToLogin" >Already have an account?</a>
            </form>
        </div>
    </div>
</body>
</html>
