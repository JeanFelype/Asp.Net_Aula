<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPaciente.aspx.cs" Inherits="ProjetoAsp.net.Views.Pacientes.ListaPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Label ID="lblNomeP" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtNomeP" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDataNasc" runat="server" Text="Data de Nascimento: "></asp:Label>
        <asp:TextBox ID="txtDataNasc" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
        <asp:Button ID="btnMostrar" runat="server" Text="Mostar" />
        <br />
        <br />
        <asp:Label ID="lblIDP" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="txtIDP" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
        <br />
        <br />
        <asp:Label ID="lblNomePEncontrado" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtNomePEncontrado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDataNascEncontrado" runat="server" Text="Data de Nascimento: "></asp:Label>
        <asp:TextBox ID="txtDataNascEncontrado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" />
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
