<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BRegistroUsuarioNuevo.aspx.cs" Inherits="WABlockchain.WebForm.BRegistroUsuarioNuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style10 {
            height: 28px;
        }
    </style>

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
                            <asp:RequiredFieldValidator ID="vlcNombre" runat="server" ControlToValidate="txtNombreEstudiante" ErrorMessage="Debes Ingresar tus Nombres" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Apellidos: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtApellidos" />
                            <asp:RequiredFieldValidator ID="vlcApellido" runat="server" ControlToValidate="txtApellidos" ErrorMessage="Debes Ingresar tus Apellidos" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="CI: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtCi" />
                            <asp:RequiredFieldValidator ID="vlcCI" runat="server" ControlToValidate="txtCi" ErrorMessage="Debes Ingresar tu Carnet de Identidad" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            <asp:Label Text="CI Extra: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox runat="server" ID="txtCiextra" />
                            <asp:RequiredFieldValidator ID="vlcCIExtra" runat="server" ControlToValidate="txtCiextra" ErrorMessage="Si no tiene un CI Extra , dejarlo en NO" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                                        <tr>
                        <td class="auto-style10">
                            <asp:Label Text="Usuario NetValle: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox runat="server" ID="txtUsuarioNetvalle" />
                            <asp:RequiredFieldValidator ID="vlcUN" runat="server" ControlToValidate="txtUsuarioNetvalle" ErrorMessage="Si es un Usuario NetValle dejarlo en SI" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
                        <td class="auto-style10">
                            <asp:Label Text="Password: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/>
                            <asp:RequiredFieldValidator ID="vlcPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Debes Ingresar una contraseña" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Correo: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtCorreo" />
                            <asp:RequiredFieldValidator ID="vlcCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Debes ingresar un correo electronico " ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Correo Electronico No Valido" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtCorreo"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Telefonos: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:TextBox runat="server" ID="txtTelefonos" TextMode="Number" />
                            <asp:RequiredFieldValidator ID="vlcTelefono" runat="server" ControlToValidate="txtTelefonos" ErrorMessage="Debes ingresar un Telefono" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtTelefonos" ErrorMessage="Debes ingresar un numero de Bolivia" ForeColor="#CC0000" MaximumValue="79999999" MinimumValue="60000000" Type="Integer"></asp:RangeValidator>
                          
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style10">
                            <asp:Label Text="Descripción: " runat="server" Font-Bold="True" />
                        </td>
                        <asp:Label ID="Label10" runat="server" CssClass="lbl" ></asp:Label>

                        <td class="auto-style10">
                            <asp:TextBox runat="server" CssClass="ffin" ID="txtDescripcion"  TextMode="MultiLine" Height="42px" Width="218px"/>
                            <asp:RequiredFieldValidator ID="vlcDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Debes Ingresar una descripcion" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label Text="Rol: " runat="server" Font-Bold="True" />
                        </td>
                        <td class="cel">
                            <asp:DropDownList ID="ddlRol" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="vlcRol" runat="server" ControlToValidate="ddlRol" ErrorMessage="Debes seleccionar un Rol" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>

                </table>
            </div>
            <div class="contein">

                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" class="btn" runat="server" Text="REGISTRAR USUARIO" OnClick="btnRegistrar_Click" />
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
