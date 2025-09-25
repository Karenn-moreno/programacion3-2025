<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="ejemplo1.ejemploConMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Ejemplo con master</h1>
   <!--<input type="type" id="txtHola" runat="server" name="name" value="" /> -->
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> <!--control asp -->
    <asp:Button ID="BtnAceptar" runat="server" OnClick="BtnAceptar_Click" Text="Aceptar" />
    <asp:Label ID="LblSaludo" runat="server" Text=""></asp:Label>
    <a href="About"> DESCRIP</a>

</asp:Content>
