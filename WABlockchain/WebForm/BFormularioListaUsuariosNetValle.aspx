<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioListaUsuariosNetValle.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioListaUsuariosNetValle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
        <div>
<fieldset id="field">
<legend class="sub">Lista de Solicitudes</legend>
<asp:GridView ID="grvUsersNetvalle" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
<Columns>
<asp:BoundField DataField="IDPerson" ItemStyle-CssClass="hidden">
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
</div>


</form>
</asp:Content>