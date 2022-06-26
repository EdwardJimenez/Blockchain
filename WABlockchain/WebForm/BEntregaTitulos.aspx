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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
            <div class="contein">
                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" runat="server" class="btn" Text="REGISTRAR" OnClick="btnRegistrar_Click" Width="212px" />
                    &nbsp;&nbsp;
                </div>
                <div style="overflow: auto; height: 250px">

                    <asp:GridView ID="grvTitulos" CssClass="gridview" style="align-content:center; margin-left: 135px" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden" Visible="false">
                                <HeaderStyle CssClass="hidden" />
                                <ItemStyle CssClass="hidden" />
                                <FooterStyle CssClass="hidden" />
                            </asp:BoundField>
                            <asp:BoundField DataField="fullNameTitulado" HeaderStyle-CssClass="name" HeaderText="TITULADO" ItemStyle-CssClass="itName" SortExpression="name" />
                            <asp:BoundField DataField="faculty" HeaderStyle-CssClass="college" HeaderText="FACULTAD" ItemStyle-CssClass="itCollege" SortExpression="college" />
                            <asp:BoundField DataField="carreer" HeaderStyle-CssClass="program" HeaderText="CARRERA" ItemStyle-CssClass="itProgram" SortExpression="program" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" OnClick="Subir_Click" CommandName="Actualizar" HeaderText="Subir" ItemStyle-CssClass="btButton" Text="Registrar entrega" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <div>
                    <asp:Label ID="Label9" runat="server" CssClass="msj" Text="El título se registró exitosamente" Visible="false"></asp:Label>
                </div>
            </div>
        </fieldset>
    </form>
</asp:Content>
