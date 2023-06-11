<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Admin.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Profile</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
        <asp:TextBox ID="username_txt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
        <asp:TextBox ID="email_txt" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButton ID="male_radio" runat="server" GroupName="gender_group" Text="Male" />
        <asp:RadioButton ID="female_radio" runat="server" GroupName="gender_group" Text="Female" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox ID="password_txt" runat="server" ReadOnly="true"></asp:TextBox>
        <br />
        <asp:Button ID="update_btn" runat="server" Text="Update" OnClick="update_btn_Click" />
        <br />
        <asp:Label ID="status" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
