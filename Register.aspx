<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="StockManagerPro.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href='https://fonts.googleapis.com/css?family=Poppins' rel='stylesheet'/>
    <link rel="stylesheet" href="css/register.css"/>
    <title>Register</title>
</head>
<body>
    <article class="register">
            <img src="./images/register-none.png" alt="profile"/>
            <h3>Register</h3>
            <h2>User</h2>
        <form id="form1" runat="server">
            <asp:TextBox ID="txt_user" runat="server" CssClass="User" Placeholder="Enter your ID"></asp:TextBox>
            <br />
            <asp:TextBox ID="txt_password" runat="server" CssClass="Password" Placeholder="Enter your password"></asp:TextBox>
            <br />
            <asp:TextBox ID="txt_role" runat="server" CssClass="Password" Placeholder="Enter your password"></asp:TextBox>
            <br />
            <asp:Button ID="btn_Register" runat="server" CssClass="btn" Text="Register" OnClick="btn_Register_Click"/>
            <br />
            <a href="Login.aspx">Are you already registered?</a>
        </form>
    </article>
</body>
</html>
