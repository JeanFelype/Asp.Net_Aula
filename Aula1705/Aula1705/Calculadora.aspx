<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Aula1705.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSomar" runat="server" Text="Somar" OnClick="btnSomar_Click" />
            <asp:Button ID="btnIgual" runat="server" Text="Igual" OnClick="btnIgual_Click" />
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
