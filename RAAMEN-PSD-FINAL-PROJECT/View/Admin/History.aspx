<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Admin.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>History</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px;padding: 20px">
        <asp:GridView ID="historyGridView" runat="server" OnRowCommand="historyGridView_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Transaction History">
                    <ItemTemplate>
                        <asp:Button ID="btnAddRecord" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="Detail" runat="server" Text="Detail" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
