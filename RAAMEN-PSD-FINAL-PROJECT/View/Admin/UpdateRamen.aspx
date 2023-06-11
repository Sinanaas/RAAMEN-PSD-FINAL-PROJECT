<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Admin.UpdateRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Update Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:Label ID="Label1" runat="server" Text="New Meat Type :"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">Daging Sapi</asp:ListItem>
            <asp:ListItem Value="2">Daging Babi</asp:ListItem>
            <asp:ListItem Value="3">Daging Ayam</asp:ListItem>
            <asp:ListItem Value="4">Daging Kuda</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="New Name :"></asp:Label>
        <asp:TextBox ID="name_txt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="New Broth :"></asp:Label>
        <asp:TextBox ID="broth_txt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="New Price :"></asp:Label>
        <asp:TextBox ID="price_txt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="update_ramen_btn" runat="server" Text="Update Ramen" OnClick="update_ramen_btn_Click" />
    </div>
</asp:Content>
