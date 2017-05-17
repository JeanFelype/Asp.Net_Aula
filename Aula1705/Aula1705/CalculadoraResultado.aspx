<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculadoraResultado.aspx.cs" Inherits="Aula1705.CalculadoraResultado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:TextBox ID="txtN1" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblSoma" runat="server" Text="+"></asp:Label>
    <asp:TextBox ID="txtN2" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblIgual1" runat="server" Text="="></asp:Label>
    <asp:TextBox ID="txtResultado1" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="txtN3" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblSubtracao" runat="server" Text="-"></asp:Label>
    <asp:TextBox ID="txtN4" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblIgual2" runat="server" Text="="></asp:Label>
    <asp:TextBox ID="txtResultado2" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="txtN5" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblMultiplicacao" runat="server" Text="*"></asp:Label>
    <asp:TextBox ID="txtN6" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblIgual3" runat="server" Text="="></asp:Label>
    <asp:TextBox ID="txtResultado3" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="txtN7" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblDivisao" runat="server" Text="/"></asp:Label>
    <asp:TextBox ID="txtN8" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblIgual4" runat="server" Text="="></asp:Label>
    <asp:TextBox ID="txtResultado4" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
</asp:Content>
