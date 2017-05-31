<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultasEncontradas.aspx.cs" Inherits="ProjetoAsp.net.Views.Consultas.ConsultasEncontradas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>Consultas Futuras</h1>
            <asp:GridView ID="gvConsultaAtivas" runat="server"></asp:GridView>
            <br />
            <br />
            <h1>Consultas Realizadas</h1>
            <asp:GridView ID="gvConsultaInativas" runat="server"></asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
