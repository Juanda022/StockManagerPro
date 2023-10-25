<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StockManagerPro.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href='https://fonts.googleapis.com/css?family=Poppins' rel='stylesheet'/>
    <link rel="stylesheet" href="css/login.css"/>
    <title>Login</title>
</head>
<body>
    <article class="login">
            <img src="./images/profile.png" alt="profile"/>
            <h3>Welcome</h3>
            <h2>User</h2>
        <form id="form1" runat="server">
            <asp:TextBox ID="txt_user" runat="server" CssClass="User" Placeholder="Enter your ID"></asp:TextBox>
            <br />
            <asp:TextBox ID="txt_password" runat="server" CssClass="Password" Placeholder="Enter your password"></asp:TextBox>
            <br />
            <button type="submit">LOGIN</button>
            <br />
            <a href="#">Forgot your password?</a>
        </form>
    </article>
</body>
</html>
