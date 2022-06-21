<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
        <div class="boton">
            <br />
            <asp:Button ID="btnBuscar" runat="server" CssClass="btn" Text="BUSCAR" Height="29px" Width="104px" />
            <asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="21px" Width="38px" />
            <asp:TextBox ID="txtBuscador" runat="server" Width="557px"></asp:TextBox>
        </div>
        <br />
        <div class="ddls">
            <asp:DropDownList ID="ddlSede" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlGestion" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlCarrera" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlEstadoTitulo" CssClass="btn" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" CssClass="grid" runat="server" Height="330px" Width="476px">
            </asp:GridView>
            <br />
            <br />
            <div >
                <asp:Button ID="btnRegistrarUsuario" CssClass="btn"  runat="server"  Text="Registrar Usuario" Width="187px" />
                <asp:Button ID="btnRegistrarTitulo" CssClass="btn" runat="server" Text="Registrar Titulo" Width="187px" />
            </div>
             <div >
                <asp:Button ID="btnConfirmarTitulo" CssClass="btn"  runat="server"  Text="Confirmar " Width="80px" />
                <asp:Button ID="btnSolicitarTitulo" CssClass="btn" runat="server" Text="Solicitar" Width="80px" />
                <asp:Button ID="btnRecibirTitulo" CssClass="btn" runat="server" Text="Recibido" Width="80px" />

            </div>

        </div>

    </form>
</asp:Content>
