<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }

        .auto-style2 {
            text-align: center;
            width: 752px;
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
        <div class="calendar2">
            &nbsp;
            <asp:Calendar ID="Calendar3" runat="server" Width="255px" Height="16px"></asp:Calendar>
            <br />
            <asp:Calendar ID="Calendar1" runat="server" Width="254px" Height="111px"></asp:Calendar>
            <br />
        </div>
        <div class="botonesRegistro">
            &nbsp;<asp:Button ID="btnBuscarPorFecha" CssClass="btn" runat="server" Text="Buscar" Width="135px" />
        </div>
        <div class="ddls">
            <br />
            <br />
            <asp:GridView ID="GridView1" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="476px">
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
            <br />
            <asp:Label ID="lblmensaje" Text="..." runat="server" Font-Bold="True" />

            <div class="auto-style2">
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
