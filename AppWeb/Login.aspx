<%@ Page Title="Ingreso de usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppWeb.Login" %>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
    <h1 align="center">Ingreso de Usuario</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function ValidaLargo(oSrc, args) {
           args.IsValid = (args.Value.length >= 4);
          
        }

       
    </script>
    Ingrese Usuario: <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" ForeColor="#FF0000" BackColor="#FFFF00" 
     runat="server" ControlToValidate="txtUsuario" ClientValidationFunction="ValidaLargo" ErrorMessage="No se cumplen los requsitos"/>
    <br />
    <br />
    Ingrese Clave:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtClave" runat="server" TextMode="Password" ></asp:TextBox>

    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonAceptar"  name="btnEnviar" runat="server" Text="Enviar" OnClick="Button1_Click"    />
     
</asp:Content>
