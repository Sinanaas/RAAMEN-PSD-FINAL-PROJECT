<%@ Page Language="C#" EnableSessionState="True" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px">
            <asp:Label ID="Label1" runat="server" Text="Username :  "></asp:Label>
            <asp:TextBox ID="username_text" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password :  "></asp:Label>
            <asp:TextBox ID="password_text" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="remember_check" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
            <br />
            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="login_btn_Click" />
            <br />
            <asp:Label ID="status" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
