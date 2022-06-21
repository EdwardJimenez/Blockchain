<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BMenuPrincipal.aspx.cs" Inherits="WABlockchain.WebForm.BMenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloMenuPrincipal.css" rel="stylesheet" />
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
            <asp:DropDownList ID="ddlSede" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlGestion" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlCarrera" CssClass="btn" runat="server"></asp:DropDownList>
            &nbsp;<asp:DropDownList ID="ddlEstadoTitulo" CssClass="btn" runat="server"></asp:DropDownList>
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
            <div >
                <asp:Button ID="btnRegistrarUsuario" CssClass="btn"  runat="server"  Text="REGISTRAR USUARIO" Width="187px" />
                <asp:Button ID="btnRegistrarTitulo" CssClass="btn" runat="server" Text="REGISTRAR TITULO" Width="187px" />
            </div>

        </div>

    </form>
</asp:Content>

