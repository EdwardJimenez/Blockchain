<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BEntregaTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BEntregaTitulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset>
            <legend class="bold" style="text-align: center;">ENTREGA TITULOS NETVALLE</legend>
            <div class="container">
                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Fecha de Emisión: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtFechaEmision" runat="server" CssClass="finicio" TextMode="Date" />

                        </td>
                        <asp:Label ID="Label2" runat="server" CssClass="lbl"></asp:Label>
                    </tr>
                    <asp:Label ID="Label10" runat="server" CssClass="lbl"></asp:Label>

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
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Metodo de Entrega: " />
                        </td>
                        <td class="cel">
                            <asp:DropDownList ID="ddlMetodoEntrega" class="btn" runat="server">
                                <asp:ListItem Value="A">Acto de Graduacion</asp:ListItem>
                                <asp:ListItem Value="S">Solicitud Privada</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="contein">
                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" runat="server" class="btn" Text="INSERTAR" OnClick="btnRegistrar_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnQr" runat="server" class="btn" Text="ACTUALIZAR" />
                </div>
                <div>
                    <asp:GridView ID="GridView1" CssClass="grid" runat="server" Height="262px" Width="441px"></asp:GridView>
                </div>
                <div>
                    <asp:Label ID="Label9" runat="server" CssClass="msj" Text="El título se registró exitosamente" Visible="false"></asp:Label>
                </div>
            </div>
        </fieldset>
    </form>
</asp:Content>
