<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN_PSD_FINAL_PROJECT.View.Customer.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Order Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 55px">
        <asp:Label runat="server" Text="Ramens"></asp:Label>
        <br />
        <asp:GridView ID="ramenGridView" runat="server" OnRowCommand="ramenGridView_RowCommand" OnSelectedIndexChanged="ramenGridView_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="add_btn" runat="server" Text="Add to Cart" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" Text="Your Cart"></asp:Label>
        <br />
        <asp:GridView ID="cartGridView" runat="server"></asp:GridView>
        <br />
        <asp:Button ID="pay_btn" runat="server" Text="Pay" />
    </div>
</asp:Content>
