<%@ Page Title="Bienvenido!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AplicacionWeb._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
   
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1 align="center">Bienvenido al Registro de Vehiculos de Transportes.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <img src="Images/logo.jpg" id="Logo"/>
    <center>
        <asp:Button ID="btnIngresar" runat="server" Text="ingresar" OnClick="btnIngresar_Click"  /><br />
    </center>
</asp:Content>

