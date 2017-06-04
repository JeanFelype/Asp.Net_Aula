<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PacientesEncontrados.aspx.cs" Inherits="ProjetoAsp.net.Views.Pacientes.PacientesEncontrados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>Pacientes Cadastrados Ativos</h1>
            <asp:GridView ID="gvPacientesAtivas" runat="server"></asp:GridView>
            <br />
            <br />
            <h1>Pacientes Cadastrados Inativos</h1>
            <asp:GridView ID="gvPacientesInativas" runat="server"></asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
