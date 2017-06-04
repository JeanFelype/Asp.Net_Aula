<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaConsultas.aspx.cs" Inherits="ProjetoAsp.net.Views.Consultas.ListaConsultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPreco" runat="server" Text="Preço: "></asp:Label>
            <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblData" runat="server" Text="Data: "></asp:Label>
            <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
            <br />
            <br />
            <asp:Label ID="lblID" runat="server" Text="ID: "></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            <br />
            <br />
            <asp:Label ID="lblNomeEncontrado" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="txtNomeEncontrado" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrecoEncontrado" runat="server" Text="Preço: "></asp:Label>
            <asp:TextBox ID="txtPrecoEncontrado" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDataEncontrada" runat="server" Text="Data: "></asp:Label>
            <asp:TextBox ID="txtDataEncontrada" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" />
            <asp:Button ID="btnEditar" runat="server" Text="Editar" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
