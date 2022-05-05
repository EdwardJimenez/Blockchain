<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="IRegistroTitulo.aspx.cs" Inherits="WABlockchain.WebForm.IRegistroTitulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <fieldset>
            <legend class="bold" style="text-align: center;">TITULOS</legend>
            <div class="container">
                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Fecha de Emisión: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtFechaEmision" runat="server" CssClass="finicio" TextMode="Date" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Titulado: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtTitulado" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Sede: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtSede" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Metodo de Entrega: " />
                        </td>
                        <td class="cel">
                            <asp:DropDownList ID="ddlMetodoEntrega" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="contein">
                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" runat="server" class="btn" Text="REGISTRAR TITULO" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnQr" runat="server" class="btn" Text="GENERAR CÓDIGO QR" />

                </div>
                <div>
                    <asp:Label ID="lblMensajeTitulo" runat="server" CssClass="msj" Text="El título se registró exitosamente" Visible="False"></asp:Label>
                </div>
            </div>
        </fieldset>
    </form>
</asp:Content>
