<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2405_EF_MF.Views.Categorias.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <br />
    <asp:Label ID="lblNome" runat="server" Text="Nome :"></asp:Label>
    <br />
    <asp:TextBox ID="txtNome" runat="server" MaxLength="50"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição :"></asp:Label>
    <br />
    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
    <br />
            <br />
            <h1>Categorias Ativas</h1> 
    <asp:GridView ID="gvCategorias" runat="server"></asp:GridView>
    <br />
            <h1>Categorias Excluidas</h1> 
    <asp:GridView ID="gvCategoriasExcluidas" runat="server"></asp:GridView>
            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
