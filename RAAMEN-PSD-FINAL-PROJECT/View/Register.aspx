<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Register" %>

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
            <asp:Label ID="Label2" runat="server" Text="Email    :  "></asp:Label>
            <asp:TextBox ID="email_text" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Gender   :  "></asp:Label>
            <br />
            <asp:RadioButton ID="male_radio" runat="server" GroupName="gender_group" Text="Male" />
            <asp:RadioButton ID="female_radio" runat="server" GroupName="gender_group" Text="Female" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password :  "></asp:Label>
            <asp:TextBox ID="password_text" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Confirm Password :  "></asp:Label>
            <asp:TextBox ID="confirm_password_text" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="register_btn" runat="server" Text="Register" OnClick="register_btn_Click"/>
            <br />
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
