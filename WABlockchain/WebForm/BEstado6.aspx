<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BEstado6.aspx.cs" Inherits="WABlockchain.WebForm.BEstado6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
<div>
<div class="">
<div class="center_content">
<div class="">
<div class="form-style-10">

<div class="caja">



<div style="width: 332px; height: 425px; margin-left: 9px;">
<div class="datos">
<div>
<fieldset id="field">
<legend class="sub">Lista de títulos solicitados a la espera de ser enviados
    </legend>
    <div style="overflow: auto; height: 250px">
<asp:GridView ID="grvTitulos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
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
<asp:Button runat="server" OnClick="Actualizar_Click" CommandName="Actualizar" HeaderText="Actualizar" ItemStyle-CssClass="btButton" Text="Envíar título solicitado" />
</ItemTemplate>
</asp:TemplateField>

    


</Columns>
</asp:GridView>
        </div>





</fieldset>
</div>

</div>
</div>
</div>

</div>
</div>
</div>
</form>

</asp:Content>