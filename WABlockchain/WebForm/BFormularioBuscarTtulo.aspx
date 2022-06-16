<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioBuscarTtulo.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioBuscarTtulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" class="fieldsetForm">
        <fieldset>
            <legend class="bold">BUSCAR TITULOS</legend>
            <div class="container">

                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Facultad: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtFacultad"  />
                            <%-- <asp:RequiredFieldValidator ID="vlcFacultad" runat="server" ControlToValidate="txtFacultad" ErrorMessage="Campo requerido" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Carrera: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtCarrera" />
                            <%-- <asp:RequiredFieldValidator ID="vlcCarrera" runat="server" ControlToValidate="txtCarrera" ErrorMessage="Campo requerido" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Nombres: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtNombrePersona" />
                            <%--<asp:RequiredFieldValidator ID="vlcNombres" runat="server" ControlToValidate="txtNombrePersona" ErrorMessage="Campo requerido" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>--%>
                    </tr>

                    <tr>
                        <td class="auto-style10">
                            <asp:Label Text="Primer Apellido: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox runat="server" ID="txtPrimerApellido" />
                            <%--    <asp:RequiredFieldValidator ID="vlcPrimerApellido" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="Campo requerido" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            <asp:Label Text="Segundo Apellido: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox runat="server" ID="txtSegundoApellido" />
                        </td>

                </table>
            </div>
            <div class="contein">

                <div class="bold">
                    <asp:Button OnClick="btnBuscar_Click" ID="btnBuscar" class="btn" runat="server" Text="Buscar " />
                </div>
                <div class="bold">
                <asp:Label runat="server" CssClass="msj" ID="lblMensaje" Text="Mensaje" ></asp:Label>
                </div>
            </div>

        </fieldset>
        <fieldset>
            <legend class="bold">LISTA TITULOS</legend>
            <asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden">
                        <HeaderStyle CssClass="hidden" />
                        <ItemStyle CssClass="hidden" />
                        <FooterStyle CssClass="hidden" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fullNameTitulado" HeaderStyle-CssClass="name" HeaderText="NOMBRE COMPLETO" ItemStyle-CssClass="itName" SortExpression="name" />
                    <asp:BoundField DataField="faculty" HeaderStyle-CssClass="college" HeaderText="FACULTAD" ItemStyle-CssClass="itCollege" SortExpression="college" />
                    <asp:BoundField DataField="carreer" HeaderStyle-CssClass="program" HeaderText="CARRERA" ItemStyle-CssClass="itProgram" SortExpression="program" />
                </Columns>
            </asp:GridView>
        </fieldset>
    </form>
</asp:Content>
