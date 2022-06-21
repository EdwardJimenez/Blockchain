<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioBuscarTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioBuscarTitulos" %>
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



<div style="width: 332px; height: 425px; margin-left: 9px;">
<div class="datos">
<div>
<%--<label for="">Estudiante :<input runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
<label for="">Facultad: <asp:TextBox runat="server" ID="txtFacultad" />

</label>
<br>
&nbsp;</div>
<div>
<%--<label for="">Estudiante :<input runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
<label for="">Carrera : <asp:TextBox runat="server" ID="txtCarrera" /></label><br>
&nbsp;</div>
<div>
<%--<label for="">Estudiante :<input runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
<label for="">Nombres : <asp:TextBox runat="server" ID="txtNombreEstudiante" /></label><br>
&nbsp;</div>
    <div>
<%--<label for="">Estudiante :<input runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
<label for="">Primer Apellido : <asp:TextBox runat="server" ID="txtPrimero" /></label><br>
&nbsp;</div>
    <div>
<%--<label for="">Estudiante :<input runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
<label for="">Segundo Apellido (Opcional) : <asp:TextBox runat="server" ID="txtSegundo" /></label><br>
&nbsp;</div>
    <br />
<asp:Button class="btn" OnClick="btnBuscar_Click" ID="btnBuscar" runat="server" Text="Buscar" Height="38px" style="margin-left: 21px; margin-top: 25px" Width="145px" />
<asp:Label runat="server" CssClass="msj" ID="lblMensaje" Text="Mensaje" ></asp:Label>
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
</Columns>
</asp:GridView>
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
