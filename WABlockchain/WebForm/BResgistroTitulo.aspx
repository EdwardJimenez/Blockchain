<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BResgistroTitulo.aspx.cs" Inherits="WABlockchain.WebForm.BResgistroTitulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset>
            <legend class="bold" style="text-align: center;"> REGISTRO TITULOS</legend>
            <div class="container">
                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Facultad: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtFacultad" runat="server" CssClass="finicio" TextMode="Date" />

                        </td>
                    </tr>
                   <%-- <asp:Label ID="Label10" runat="server" CssClass="lbl"></asp:Label>--%>

                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Carrera: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCarrera" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nombre: " />
                        </td>
                            <asp:Label  CssClass="label" runat="server" Font-Bold="True"/>

                        <td class="cel">
                            <asp:TextBox ID="txtNombre" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Email: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtEmail" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Password: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtContrasenia"  runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="CI Usuario: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCiUsuaario" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Descripcion: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtDescripcion" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Ci Extra: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCiExtra" runat="server" />
                            <br />
                        </td>
                    </tr>
                </table>
            </div>       
            <asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" >
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
                                <asp:Button runat="server"  CommandName="Enviar" HeaderText="Enviar" CssClass="btn" ItemStyle-CssClass="btButton" Text="Enviar" />
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>
            <div class="contein">
                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" runat="server" class="btn" Text="REGISTRAR TITULO" Width="172px" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnQr" runat="server" class="btn" Text="ACTUALIZAR" />
                </div>
                <div>
                    <asp:Label ID="Label9" runat="server" CssClass="msj" Text="El título se registró exitosamente" Visible="false"></asp:Label>
                </div>
            </div>
        </fieldset>
    </form>
</asp:Content>
