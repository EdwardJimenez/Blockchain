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
            <asp:Button ID="btnBuscar" OnClick="btnSearch_Click1" runat="server" CssClass="btn" Text="Buscar Titulo" Height="29px" Width="104px" />
            &nbsp;<asp:TextBox ID="txtBuscador" runat="server" Width="617px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div class="calendar2">
            <div class="cal1">
            <asp:Label CssClass="lblfechas" runat="server" Text="Fecha Inicio :"></asp:Label>
                <asp:Calendar ID="FechaInicio" runat="server" Width="255px" Height="16px"></asp:Calendar>
            </div>
            <div class="cal1">
            <asp:Label CssClass="lblfechas" runat="server" Text="Fecha Fin :"></asp:Label>
                <asp:Calendar ID="FechaFin" runat="server" Width="254px" Height="111px"></asp:Calendar>
            </div>
            <br />
        </div>
        <div class="botonesRegistro">
            &nbsp;<asp:Button ID="btnBuscarPorFecha" OnClick="btnSearchDate_Click" CssClass="btn" runat="server" Text="Buscar" Width="135px" />
        </div>
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
            <asp:Label CssClass="lblmensaje" ID="lblmensaje"  runat="server"></asp:Label>
            <br />
            <div class="auto-style2">
                <asp:Button ID="btnRegistrarUsuario" CssClass="btn" runat="server" Text="Registrar Usuario" Width="135px" />
                <asp:Button ID="btnRegistrarUsuarioNetvalle" CssClass="btnsep" runat="server" Text="Registrar Usuario Netvalle" Width="198px" />
                <asp:Button ID="btnRegistrarTitulo" CssClass="btnsep" runat="server" Text="Registrar Titulo" Width="135px" />   
                <asp:Button ID="btnConfirmarTitulo" CssClass="btnsep" runat="server" Text="Confirmar " Width="135px" />
                <asp:Button ID="btnSolicitarTitulo" CssClass="btnsep" runat="server" Text="Solicitar" Width="135px" />
                <asp:Button ID="btnImprimirTitulo" CssClass="btnsep" runat="server" Text="Imprimir" Width="135px" />
                <asp:Button ID="Button2" CssClass="btnsep" runat="server" Text="Enviar" Width="135px" />
                <asp:Button ID="btnRecibirTitulo" CssClass="btnsep" runat="server" Text="Recibido" Width="135px" />
            </div>
        </div>
        <br/>
    </form>
</asp:Content>
