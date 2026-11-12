<%@ Page Title="Ricerca ticket" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Ricerca.aspx.vb" Inherits="Alpina.Web.Ricerca" %>
<%@ Register TagPrefix="uc" TagName="Filtro" Src="~/Controlli/Filtro.ascx" %>
<asp:Content ID="Corpo" ContentPlaceHolderID="Contenuto" runat="server">
  <uc:Filtro ID="filtro" runat="server" />
  <asp:TextBox ID="txtCliente" runat="server" />
  <asp:Button ID="btnCerca" runat="server" Text="Cerca" OnClick="btnCerca_Click" />
  <asp:Button ID="btnStampa" runat="server" Text="Stampa" OnClientClick="return confirm('Stampare?');" />
  <asp:GridView ID="grigliaTicket" runat="server" OnSelectedIndexChanged="grigliaTicket_SelectedIndexChanged" />
</asp:Content>
