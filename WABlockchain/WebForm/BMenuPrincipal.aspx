<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
        <div class="boton">
            <br />
            <asp:Button ID="btnBuscar" runat="server" CssClass="btn" Text="BUSCAR" Height="29px" Width="104px" />
            <asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="21px" Width="30px" />
            <asp:TextBox ID="txtBuscador" runat="server" Width="551px"></asp:TextBox>
        </div>
        <br />
        <div class="ddls">
            <asp:DropDownList ID="ddlSede" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlGestion" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlCarrera" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlEstadoTitulo" CssClass="btn" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Height="330px" Width="476px">
            </asp:GridView>
            <br />
            <br />
            <div >
                <asp:Button ID="btnRegistrarUsuario" CssClass="btn"  runat="server"  Text="REGISTRAR USUARIO" Width="187px" OnClick="btnRegistrarUsuario_Click" />
                <asp:Button ID="btnRegistrarTitulo" CssClass="btn" runat="server" Text="REGISTRAR TITULO" Width="187px" OnClick="btnRegistrarTitulo_Click" />
            </div>

        </div>

    </form>
</asp:Content>
