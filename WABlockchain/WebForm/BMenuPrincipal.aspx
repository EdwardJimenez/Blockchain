<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
        .auto-style2 {
            margin-left: 100px;
            width: 603px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="boton">
            <br />
            <asp:Button ID="btnBuscar" runat="server" CssClass="btn" Text="Buscar Titulo" Height="29px" Width="104px" />
            &nbsp;<asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="24px" Width="43px" CssClass="auto-style1" Style="margin-top: 0px" />
            <asp:TextBox ID="txtBuscador" runat="server" Width="557px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div class="auto-style2">
            &nbsp;
            <asp:Calendar  ID="Calendar3"  runat="server" CssClass="auto-style1" Width="545px"></asp:Calendar>
            <br />
            <asp:Calendar   ID="Calendar1"  runat="server" CssClass="calendar2" Width="542px"></asp:Calendar>
            <br />
        </div>
        <div class="botonesRegistro">
            
            &nbsp;<asp:Button ID="btnBuscarPorFecha" CssClass="btn" runat="server" Text="Buscar" Width="135px" />
        </div>
        <div class="ddls">
            <asp:GridView ID="GridView1" CssClass="grid" runat="server" Height="287px" Width="412px">
            </asp:GridView>
            <br />
            <br />
        </div>
        <div class="botonesRegistro">
            <asp:Button ID="btnRegistrarUsuario" CssClass="btn" runat="server" Text="Registrar Usuario" Width="135px" />
            &nbsp;<asp:Button ID="btnRegistrarUsuarioNetvalle" CssClass="btn" runat="server" Text="Registrar Usuario Netvalle" Width="198px" />
            &nbsp;<asp:Button ID="btnRegistrarTitulo" CssClass="btn" runat="server" Text="Registrar Titulo" Width="135px" />
            <br />
            <br />
            <asp:Button ID="btnConfirmarTitulo" CssClass="btn" runat="server" Text="Confirmar " Width="135px" />
            &nbsp;<asp:Button ID="btnSolicitarTitulo" CssClass="btn" runat="server" Text="Solicitar" Width="135px" />
            &nbsp;<asp:Button ID="btnRecibirTitulo" CssClass="btn" runat="server" Text="Recibido" Width="135px" />
        </div>
        <br />

    </form>
</asp:Content>
