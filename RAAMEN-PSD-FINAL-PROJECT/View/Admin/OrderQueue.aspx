<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Admin.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Order Queue</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:Label ID="Label1" runat="server" Text="Unhandled Orders"></asp:Label>
        <br />
        <asp:GridView ID="unhandledGridView" runat="server" OnRowCommand="unhandledGridView_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="btnAddRecord" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="Handle" runat="server" Text="Handle" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Handled Orders"></asp:Label>
        <br />
        <asp:GridView ID="handledGridView" runat="server"></asp:GridView>
        <br />
    </div>
</asp:Content>
