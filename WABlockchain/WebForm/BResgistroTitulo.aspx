<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BResgistroTitulo.aspx.cs" Inherits="WABlockchain.WebForm.BResgistroTitulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style10 {
            text-align: center;
            margin-left: 78px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset>
            <legend class="bold">REGISTRO TITULO</legend>
            <div class="container">
                <table>
                  <tr>
                        <td class="cell">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Facultad: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtFacultad" runat="server" CssClass="finicio" />
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFacultad" ErrorMessage="Debe rellenar la Facultad" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Carrera: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtCarrera" runat="server" CssClass="finicio" />
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCarrera" ErrorMessage="Debe rellenar la Carrera" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nombre: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="finicio" />
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe rellenar el nombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="cell">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="ID: " />
                        </td>
                        <td class="cel">
                            <asp:TextBox ID="txtId" runat="server" CssClass="finicio" />
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtId" ErrorMessage="Campo Requerido" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="contein">

                <div class="Registrar">
                    <asp:Button ID="btnRegistrar" class="btn" runat="server" Text="REGISTRAR" OnClick="btnRegistrar_Click" />
                    <asp:Button ID="btnActualizar" class="btn" runat="server" Text="ACTUALIZAR" OnClick="btnActualizar_Click" />
                </div>
                <div>
                    <asp:Label runat="server"  ID="lblmensaje" CssClass="msj" ForeColor="#CC0000"></asp:Label>
                </div>
            </div>
        </fieldset>
        <fieldset>
            <legend class="bold">LISTA TITULOS</legend>
            <div style="overflow: auto; height: 250px">
                <asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="627px">
                    <Columns>
                        <asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden" Visible="false">
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
            </div>
        </fieldset>
    </form>
</asp:Content>
