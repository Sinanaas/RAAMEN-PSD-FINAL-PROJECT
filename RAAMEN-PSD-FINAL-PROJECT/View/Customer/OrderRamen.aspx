<%--<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Customer.OrderRamen" %>--%>
<%@ Page Title="" EnableViewState="true" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Customer.OrderRamen" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Order Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:Label runat="server" Text="Ramens"></asp:Label>
        <br />
        <asp:GridView ID="ramenGridView" runat="server" OnRowCommand="ramenGridView_RowCommand1">
            <Columns>
                <asp:TemplateField HeaderText="Add record">
                    <ItemTemplate>
                        <asp:Button ID="btnAddRecord" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="AddRecord" runat="server" Text="Add" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <br />
        <asp:Label runat="server" Text="Your Cart"></asp:Label>
        <br />
        <asp:GridView ID="cartGridView" runat="server"></asp:GridView>
        <br />
        <asp:Label ID="total" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="clear_btn" runat="server" Text="Clear Cart" OnClick="clear_btn_Click" />
        <asp:Button ID="pay_btn" runat="server" Text="Pay" OnClick="pay_btn_Click" />
        <br />
        <asp:Label ID="status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
