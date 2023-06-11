<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="HistoryCustomer.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Customer.HistoryCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Transaction History</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px">
        <asp:GridView ID="historyGridView" runat="server"></asp:GridView>
    </div>
</asp:Content>
