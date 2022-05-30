<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioEnviarTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioEnviarTitulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
<div>
<div class="">
<div class="center_content">
<div class="">
<div class="form-style-10">

<div class="caja">
    <fieldset id="field">
<legend class="sub">Lista de Titulos</legend>
<asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
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
<asp:Button runat="server" OnClick="Enviar_Click" CommandName="Enviar" HeaderText="Enviar" ItemStyle-CssClass="btButton" Text="Enviar" />
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
<ItemTemplate>
</ItemTemplate>
</asp:TemplateField>

   

</Columns>
</asp:GridView>
</fieldset>

    </div>


    <div class="caja2">
    <fieldset id="field2">
<legend class="sub">Lista de Titulos</legend>
<asp:GridView ID="grvTitulos2" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
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
<asp:Button runat="server" OnClick="Cancelar_Click" CommandName="Cancelar" HeaderText="Cancelar" ItemStyle-CssClass="btButton" Text="Cancelar" />
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
<ItemTemplate>
</ItemTemplate>
</asp:TemplateField>

   

</Columns>
</asp:GridView>
</fieldset>

    </div>



</div>
</div>

</div>
</div>
</div> 
    </form>

</asp:Content>
