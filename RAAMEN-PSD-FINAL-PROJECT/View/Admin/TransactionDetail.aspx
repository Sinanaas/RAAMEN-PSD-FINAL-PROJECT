﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Admin.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Transactio Details</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px">
        <asp:GridView ID="detailGridView" runat="server"></asp:GridView>
    </div>
</asp:Content>
