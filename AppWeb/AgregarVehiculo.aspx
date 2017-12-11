<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarVehiculo.aspx.cs" Inherits="AppWeb.AgregarVehiculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Seleccionar Vehiculo.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function ValidaLargo(oSrc, args) {
            args.IsValid = (args.Value.length == 8);
        }
    </script>
    <div id="EleccionDiv" runat ="server">
        <asp:Label ID="lblEleccion" runat="server" Text="Elije el tipo de Vehiculo"></asp:Label><br />
        <asp:Button ID="btnColectivo" runat="server" Text="Colectivo" OnClick="btnColectivo_Click" />
        <asp:Button ID="btnTaxi" runat="server" Text="Taxi" OnClick="btnTaxi_Click" />
    </div>

    <asp:Panel ID="pnlBus" runat="server" Visible="false">
        Patente: <asp:TextBox ID="txtPatenteColectivo" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" ForeColor="#FF0000" BackColor="#FFFF00" 
        ControlToValidate="txtPatenteColectivo" ClientValidationFunction="ValidaLargo" ErrorMessage="El formato es XX-XX-XX" runat="server"/><br />
        Modelo: <asp:DropDownList ID="ddlModeloColectivo" runat="server" Height="17px" Width="156px"></asp:DropDownList><br />
        Motor: <asp:TextBox ID="txtMotorColectivo" runat="server" Width="52px"></asp:TextBox><br />
        Recorrido: <asp:DropDownList ID="ddlRecorrido" runat="server"></asp:DropDownList><br />
        <asp:Button ID="btnCrearBus" runat="server" Text="Ingresar Colectivo"  OnClick="btnCrearColectivo_Click" />
        <asp:Button ID="btnCancelarColectivo" runat="server" Text="Cancelar" OnClick="btnCancelarColectivo_Click" />
        <br />
    </asp:Panel>
    
    <asp:Panel ID="pnlTaxi" runat="server" Visible="false">
        Patente: <asp:TextBox ID="txtPatenteTaxi" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator2" ForeColor="#FF0000" BackColor="#FFFF00" 
        ControlToValidate="txtPatenteTaxi" ClientValidationFunction="ValidaLargo" ErrorMessage="El formato es XX-XX-XX" runat="server"/><br />
        Modelo: <asp:DropDownList ID="ddlModeloTaxi" runat="server" Height="17px" Width="156px"></asp:DropDownList><br />
        Motor: <asp:TextBox ID="txtMotorTaxi" runat="server" Width="52px"></asp:TextBox><br />
        Tipo: <asp:DropDownList ID="ddlTipoTaxi" runat="server"></asp:DropDownList><br />
        <asp:Button ID="btnCrearTaxi" runat="server" Text="Ingresar Taxi" OnClick="btnCrearTaxi_Click" />
        <asp:Button ID="btnCancelarTaxi" runat="server" Text="Cancelar" OnClick="btnCancelarTaxi_Click" />
        <br />
    </asp:Panel>

    <asp:Label ID="lblMensaje" runat="server" Text="msj" Visible="false"></asp:Label>
</asp:Content>
