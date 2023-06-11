<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="HomeStaff.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Staff.HomeStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Staff Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div style="margin-top: 55px;padding: 20px">
            <asp:GridView ID="ramenGridView" runat="server"></asp:GridView>
        <br />
    </div>
</asp:Content>
