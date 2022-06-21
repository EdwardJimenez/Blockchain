<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
    <style type="text/css">
        
        .auto-style2 {
            text-align: center;
            width: 545px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="boton">
            <br />
            <asp:Button ID="btnBuscar" runat="server" CssClass="btn" Onclick="btnSearch_Click1" Text="BUSCAR" Height="29px" Width="104px" />
            <asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="21px" Width="24px" />
            <asp:TextBox ID="txtBuscador" runat="server" Width="551px" ></asp:TextBox>
            <asp:Button ID="btnBuscarPorFecha" runat="server" CssClass="btn" Onclick="btnSearchDate_Click"  Text="BUSCAR" Height="29px" Width="104px" />
            <asp:Calendar ID="FechaInicio" runat="server" Width="156px" Height="83px" ></asp:Calendar>
            <asp:Calendar ID="FechaFin" runat="server" Width="150px" ></asp:Calendar>
        </div>
        <br />
        <div class="ddls">

            <asp:GridView ID="GridView1" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="536px" Height="208px">
                <Columns>
                    <asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden">
                        <HeaderStyle CssClass="hidden" />
                        <ItemStyle CssClass="hidden" />
                        <FooterStyle CssClass="hidden" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fullNameTitulado" HeaderStyle-CssClass="name" HeaderText="NOMBRE COMPLETO" ItemStyle-CssClass="itName" SortExpression="name" />
                    <asp:BoundField DataField="faculty" HeaderStyle-CssClass="college" HeaderText="FACULTAD" ItemStyle-CssClass="itCollege" SortExpression="college" />
                    <asp:BoundField DataField="carreer" HeaderStyle-CssClass="program" HeaderText="CARRERA" ItemStyle-CssClass="itProgram" SortExpression="program" />
                    <asp:BoundField DataField="registerDate" HeaderStyle-CssClass="program" HeaderText="FECHA" ItemStyle-CssClass="itProgram" SortExpression="program" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="lblmensaje" Text="..." runat="server" Font-Bold="True" />
            <div class="auto-style2">
                <asp:Button ID="btnRegistrarUsuario" CssClass="btn" runat="server" Text="Registrar Usuario" Width="135px" OnClick="btnRegistrarUsuario_Click"/>
                &nbsp;<asp:Button ID="btnRegistrarUsuarioNetvalle" CssClass="btn" runat="server" Text="Registrar Usuario Netvalle" Width="198px" OnClick="btnRegistrarUsuarioNetvalle_Click" />
                &nbsp;<asp:Button ID="btnRegistrarTitulo" CssClass="btn" runat="server" Text="Registrar Titulo" Width="135px" OnClick="btnRegistrarTitulo_Click"/>
                <br />
                <br />
                <asp:Button ID="btnConfirmarTitulo" CssClass="btn" runat="server" Text="Confirmar " Width="135px" OnClick="btnConfirmarTitulo_Click" />
                &nbsp;<asp:Button ID="btnSolicitarTitulo" CssClass="btn" runat="server" Text="Solicitar" Width="135px" OnClick="btnSolicitarTitulo_Click" />
                &nbsp;<asp:Button ID="btnRecibirTitulo" CssClass="btn" runat="server" Text="Recibido" Width="135px" OnClick="btnRecibirTitulo_Click" />
            </div>
        </div>
        <br />
    </form>
</asp:Content>

