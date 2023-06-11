<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Customer.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Transactio Details</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:GridView ID="detailGridView" runat="server"></asp:GridView>
    </div>
</asp:Content>
