<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px">
            <asp:Button ID="custReg_btn" runat="server" Text="Customer Register" OnClick="custReg_btn_Click" Width="141px" />
            <asp:Button ID="staffReg_btn" runat="server" Text="Staff Register" OnClick="staffReg_btn_Click" Width="141px" />
            <br />
            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="login_btn_Click" Width="282px" />
        </div>
    </form>
</body>
</html>
