<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BRegistroTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BRegistroTitulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset>
            <legend class="bold">REGISTRO TITULOS</legend>
            <div class="container">

                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Facultad: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtFacultad" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Carrera: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtCarrera" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Nombre: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtNombreTitulo" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Email: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtEmail" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Contraseña: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtContrasenia" TextMode="Password" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Ci Usuario: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" CssClass="finicio" ID="txtCiUsuario" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Descripción: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" CssClass="ffin" ID="txtDescripcion" />
                        </td>
                    </tr>
                    <asp:Label ID="Label10" runat="server" CssClass="lbl"></asp:Label>

                    <tr>
                        <td class="cell">
                            <asp:Label Text="Ci Extra: " runat="server" Font-Bold="True" />
                        </td>

                        <td class="cel">
                            <asp:TextBox runat="server" CssClass="ffin" ID="txtCiExtra" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="contein">

                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" class="btn" runat="server" Text="REGISTRAR " />
                    <asp:Button ID="btnActualizar" class="btn" runat="server" Text="ACTUALIZAR" />

                </div>
                <div>
                    <asp:Label runat="server" CssClass="msj" Text="El programa se registró exitosamente" Visible="false"></asp:Label>
                </div>
            </div>
            <div>
                <asp:Label ID="Label9" runat="server" CssClass="msj" Text="El usuario se registró exitosamente" Visible="false"></asp:Label>
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
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" CommandName="Enviar" HeaderText="Enviar" CssClass="btn" ItemStyle-CssClass="btButton" Text="Enviar" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </fieldset>
    </form>
</asp:Content>
