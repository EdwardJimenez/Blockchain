<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <div class="boton">
            <br />
        <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" OnClick="btnBuscar_Click" Width="187px" />
            &nbsp;<asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="21px" Width="42px" />
            <asp:TextBox ID="txtBuscador" runat="server" Width="537px"></asp:TextBox>
       </div>
            <br />
        <div class="ddls">
            <asp:DropDownList ID="ddlSede" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlGestion" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlCarrera" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlEstadoTitulo" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Height="330px" Width="476px">
            </asp:GridView>
        </div>
        <div class="botons">

        <asp:Button ID="btnRegistrarUsuario" runat="server" Text="REGISTRAR USUARIO" Width="187px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegistrarTitulo" runat="server" Text="REGISTRAR TITULO" Width="187px" />
        </div>

    </form>
</asp:Content>
