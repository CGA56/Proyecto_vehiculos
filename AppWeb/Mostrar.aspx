<%@ Page Title="Buscador patente" Language ="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="AplicacionWeb.WebForm1" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Mostrar Vehiculo por Patente.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContenct" ContentPlaceHolderID="MainContent">
    <div id="buscadorDiv" runat="server">
        <asp:Label ID="lblPatente" runat="server" Text="Patente"></asp:Label>
        <asp:TextBox ID="txtPatente" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /><br />
        <asp:ListBox ID="lstPatentes" runat="server"></asp:ListBox><br />
        <asp:Label ID="lblMensaje" runat="server" Text="msj" Visible="false"></asp:Label>
    </div>
    <div id="mostrarDiv" runat="server">
        <asp:TextBox ID="txtVehiculo" runat="server" ReadOnly="True" TextMode="MultiLine" Rows="9"></asp:TextBox><br />
        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
    </div>
</asp:Content>