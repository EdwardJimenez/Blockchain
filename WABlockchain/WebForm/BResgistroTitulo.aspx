<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BResgistroTitulo.aspx.cs" Inherits="WABlockchain.WebForm.BResgistroTitulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset style="height: 486px">
            <legend class="bold" style="text-align: center;">REGISTRO TITULOS</legend>
            <div class="container">
                <table>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Facultad: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtFacultad" runat="server" CssClass="finicio" />

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFacultad" ErrorMessage="Debe rellenar la Facultad" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <%-- <asp:Label ID="Label10" runat="server" CssClass="lbl"></asp:Label>--%>

                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Carrera: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCarrera" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCarrera" ErrorMessage="Debe rellenar la carrera" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nombre: " />
                        </td>
                        <asp:Label CssClass="label" runat="server" Font-Bold="True" />

                        <td class="cel">
                            <asp:TextBox ID="txtNombre" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe llenar el nombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="ID: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtId" runat="server" />
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="Debe llenar el  email" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un Email Valido" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
                        </td>
                    </tr>
                    <%-- %><tr>
                        <td class="cell">
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Password: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtContrasenia"  runat="server" />
                        </td>
                    </tr>
                    <%-- %><tr>
                        <td class="cell">
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="CI Usuario: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCiUsuaario" runat="server" />
                        </td>
                    </tr>
                    <%--<tr>
                        <td class="cell">
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Descripcion: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtDescripcion" runat="server" />
                        </td>
                    </tr>--%>
                    <%-- <tr>
                        <td class="cell">
                            <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Ci Extra: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCiExtra" runat="server" />
                            <br />
                        </td>
                    </tr>--%>
                </table>
            </div>
            <asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="627px">
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
                            <asp:Button runat="server" OnClick="btnEliminar_Click" OnClientClick="return confirm('Are you sure you want to Logout ?');" CommandName="Eliminar" HeaderText="Eliminar" ItemStyle-CssClass="btButton" Text="Eliminar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" OnClick="Actualizar_Click" CommandName="Actualizar" HeaderText="Actualizar" ItemStyle-CssClass="btButton" Text="Actualizar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" OnClick="btnPDF_Click" CommandName="PDF" HeaderText="PDF" ItemStyle-CssClass="btButton" Text="PDF" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <div class="contein">

                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" class="btn" runat="server" Text="REGISTRAR " OnClick="btnRegistrar_Click" />
                    <div>
                        <asp:Label runat="server" CssClass="msj" Text="Registrado" Visible="false"></asp:Label>
                    </div>
                    <asp:Button ID="btnRegistrar0" class="btn" runat="server" Text="ACTUALIZAR" OnClick="btnRegistrar_Click" />
                    <div>
                        <asp:Label runat="server" CssClass="msj" Text="Actualizado" Visible="false"></asp:Label>
                    </div>
                </div>

            </div>

        </fieldset>
    </form>
</asp:Content>
