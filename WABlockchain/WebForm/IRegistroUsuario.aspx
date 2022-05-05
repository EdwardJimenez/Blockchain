<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="IRegistroUsuario.aspx.cs" Inherits="WABlockchain.WebForm.IRegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <fieldset>
            <legend class="bold">USUARIO NUEVO</legend>
            <div class="container">

                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Nombre: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtNombreEstudiante" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Apellidos: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtApellidos" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="CI: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtCi" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Correo: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtCorreo" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Telefonos: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtTelefonos" />
                        </td>
                    </tr>

                    <tr>
                        <td class="cell">
                            <asp:Label Text="Fecha de creacion: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" CssClass="finicio" ID="txtFechaCreacion" TextMode="Date" />
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
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Rol: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:DropDownList ID="ddlRol" runat="server"></asp:DropDownList>
                        </td>
                    </tr>

                </table>
            </div>
            <div class="contein">

                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" class="btn" runat="server" Text="REGISTRAR USUARIO" />
                </div>
                <div>
                    <asp:Label runat="server" CssClass="msj" Text="El programa se registró exitosamente" Visible="false"></asp:Label>
                </div>
            </div>
              <div>
                    <asp:Label ID="Label9" runat="server" CssClass="msj" Text="El usuario se registró exitosamente" Visible="false"></asp:Label>
                </div>
        </fieldset>

    </form>
</asp:Content>
