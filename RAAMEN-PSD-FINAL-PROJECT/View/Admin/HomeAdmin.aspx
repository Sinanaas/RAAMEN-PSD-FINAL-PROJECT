<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Admin.HomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Admin Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:Label ID="Label1" runat="server" Text="ADMIN BOS"></asp:Label>
        <br />
        <asp:Label ID="status" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Staffs"></asp:Label>
        <br />
        <asp:GridView ID="staffGridView" runat="server"></asp:GridView>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Customers"></asp:Label>
        <br />
        <asp:GridView ID="customerGridView" runat="server"></asp:GridView>
    </div>
</asp:Content>
