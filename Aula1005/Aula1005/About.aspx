<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula1005.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Texto.</h2>
    <h3>Página de descrição da sua aplicação.</h3>
    <p>Use this area to provide additional information.</p>

    <asp:Calendar ID="calDataIinicial" runat="server"></asp:Calendar>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <br />
    <br />
    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
</asp:Content>
