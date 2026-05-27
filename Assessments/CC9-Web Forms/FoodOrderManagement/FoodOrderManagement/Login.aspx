<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodOrderManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <style>
        body {
            background-color: white;
            font-family: Arial;
        }

        .login-container {
            width: 320px;
            margin: 120px auto;
            padding: 25px;
            background-color: lavender;
            border-radius: 15px;
            
        }

        .login-container h2 {
            text-align: center;
            color:rebeccapurple;
        }

        .input-box {
            width: 80%;
            padding: 8px;
            margin: 5px 0 15px 0;
            border-radius: 8px;
            border: 1px solid #ccc;
        }

        .btn-login {
            width: 100%;
            padding: 10px;
            background-color: rebeccapurple;
            color: white;
            border-radius: 8px;
          
        }

    </style>

</head>

<body>
    <form id="form1" runat="server">

        <div class="login-container">

            <h2>Admin Login</h2>

            <asp:Label ID="lblMsg" runat="server" CssClass="msg"></asp:Label>

            <br />

            Username:
            <asp:TextBox ID="txtUser" runat="server" CssClass="input-box"></asp:TextBox>

            Password:
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="input-box"></asp:TextBox>

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-login"
                OnClick="btnLogin_Click" />

        </div>

    </form>
</body>
</html>