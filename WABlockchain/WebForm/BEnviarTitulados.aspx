<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BEnviarTitulados.aspx.cs" Inherits="WABlockchain.WebForm.BEnviarTitulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroUsuario.css" rel="stylesheet" />
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style10 {
            text-align: center;
            margin-left: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
       <fieldset id="field">
            <legend class="bold">LISTA TITULOS</legend>
                <asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnSelectedIndexChanged="grvTitulos_SelectedIndexChanged">
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
                                <asp:Button runat="server" OnClick="btn1_Click" CommandName="Enviar" HeaderText="Enviar" ItemStyle-CssClass="btButton" Text="Enviar" />
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>
            </fieldset>
        <fieldset>
            <legend class="bold">LISTA TITULOS</legend>
            <asp:GridView ID="GridView2" CssClass="auto-style10" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="465px">
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
                                <asp:Button runat="server" OnClick="btn1_Click" CommandName="Enviar" HeaderText="Enviar" ItemStyle-CssClass="btButton" Text="Enviar" />
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
            </asp:GridView>
            <div class="Registrar">
                <asp:Button ID="btnRegistrar" class="btn" runat="server" Text="ENVIAR" Width="109px" />
            </div>

        </fieldset>

    </form>

</asp:Content>
