<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BEnviarTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BEnviarTitulos" %>

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
        <fieldset>
            <legend class="bold">ENVIAR TITULADOS</legend>
            <div class="boton">
                <br />
                <asp:Button ID="btnBuscar" runat="server" CssClass="btn" Text="BUSCAR" Height="29px" Width="104px" />
                <asp:Image ID="Image3" ImageUrl="~/Imagenes/lupa1.jpg" runat="server" Height="21px" Width="38px" />
                <asp:TextBox ID="txtBuscadorTitulados" runat="server" Width="599px"></asp:TextBox>
            </div>
            <asp:GridView ID="grvTitulos" CssClass="auto-style10" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="465px">
                <Columns>
                    <asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden">
                        <HeaderStyle CssClass="hidden" />
                        <ItemStyle CssClass="hidden" />
                        <FooterStyle CssClass="hidden" />
                    </asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" CommandName="Enviar" HeaderText="Enviar" CssClass="btn" ItemStyle-CssClass="btButton" Text="Enviar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </fieldset>
        <fieldset>
            <legend class="bold">LISTA TITULADOS</legend>
            <asp:GridView ID="GridView2" CssClass="auto-style10" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="465px">
                <Columns>
                    <asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden">
                        <HeaderStyle CssClass="hidden" />
                        <ItemStyle CssClass="hidden" />
                        <FooterStyle CssClass="hidden" />
                    </asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" CommandName="Cancelar" HeaderText="Cancelar" CssClass="btn" ItemStyle-CssClass="btButton" Text="Cancelar" />
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
