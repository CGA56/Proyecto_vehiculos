<%@ Page Title="Elimanar patente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="AplicacionWeb.WebForm2" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Eliminar Vehiculo por Patente.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContenct" ContentPlaceHolderID="MainContent">
    <div id="buscadorDiv" runat="server">
        <asp:Label ID="lblPatente" runat="server" Text="Patente"></asp:Label>
        <asp:TextBox ID="txtPatente" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" /><br />
        <asp:ListBox ID="lstPatentes" runat="server"></asp:ListBox><br />
        <asp:Label ID="lblMensaje" runat="server" Text="msj" Visible="false"></asp:Label>
    </div>
</asp:Content>
