<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
        <div class="boton">
            <br />
            <asp:Button ID="btnBuscar" runat="server" CssClass="btn" Text="BUSCAR" Height="29px" Width="104px" />
            &nbsp;<asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="24px" Width="43px" CssClass="auto-style1" style="margin-top: 0px" />
            <asp:TextBox ID="txtBuscador" runat="server" Width="557px"></asp:TextBox>
        </div>
        <div class="ddls">
          
            <br />
            <br />
            <asp:GridView ID="GridView1" CssClass="grid" runat="server" Height="287px" Width="412px">
            </asp:GridView>
            <br />
            <br />
            <div >
                <asp:Button ID="btnRegistrarUsuario" CssClass="btn"  runat="server"  Text="Registrar Usuario" Width="187px" />
                <asp:Button ID="btnRegistrarTitulo" CssClass="btn" runat="server" Text="Registrar Titulo" Width="187px" />
                <br />
                <br />
            </div>
             <div >
                <asp:Button ID="btnConfirmarTitulo" CssClass="btn"  runat="server"  Text="Confirmar " Width="135px" />
                <asp:Button ID="btnSolicitarTitulo" CssClass="btn" runat="server" Text="Solicitar" Width="135px" />
                <asp:Button ID="btnRecibirTitulo" CssClass="btn" runat="server" Text="Recibido" Width="135px" />

            </div>

        </div>

        <br />

    </form>
</asp:Content>
