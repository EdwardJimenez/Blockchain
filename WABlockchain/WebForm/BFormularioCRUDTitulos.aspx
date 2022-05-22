<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioCRUDTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioCRUDTitulos" %>
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
<label for="">Nombre completo : <asp:TextBox runat="server" ID="txtNombreCompleto" /></label><br>
&nbsp;</div>
<div>
<%--<label for="">Estudiante :<input runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
<label for="">Email : <asp:TextBox runat="server" ID="txtEmail" /></label><br>
&nbsp;</div>
<div>
<%--<label for="">Apellidos :<input runat="server" ID="fechaActual" name="fechaActual" type="text" onchange="handler(event);"></label><br>--%>
<label for="">Password : <asp:TextBox runat="server" ID="txtPassword" /></label><br>
&nbsp;</div>



<div>
<%-- <label for="">Teléfonos :<input runat="server" ID="Date3" name="fechaActual" type="text" onchange="handler(event);" ></label><br>--%>
<label for="">CI Uusario:<asp:TextBox runat="server" ID="txtCi" /></label><br>
&nbsp;</div>
<div>
<%--<label for="">Fecha de Creación :<input runat="server" ID="fechaPlazo" name="fechaPlazo" type="date" value="2021-06-27"></label><br>--%>
<label for="">Descripcion :<asp:TextBox runat="server" ID="txtDescripcion" /></label>
<br>
&nbsp;</div>
<div>
<%--<label for="">Descripción :<input runat="server" ID="Date5" name="fechaActual" type="text" onchange="handler(event);" ></label><br>--%>
<label for="">CI Extra :<asp:TextBox runat="server" ID="txtCIExtra" /></label><br>
&nbsp;</div>
</div>
<asp:Button class="btn" ID="btnEnviar" runat="server" Text="Registrar" OnClick="btnInsertar_Click" Height="38px" style="margin-left: 21px; margin-top: 25px" Width="145px" />
<asp:Button class="btn" ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Height="38px" style="margin-left: 21px; margin-top: 25px" Width="145px" />
<asp:Label runat="server" CssClass="msj" ID="lblMensaje" Text="Mensaje" ></asp:Label>
<fieldset id="field">
<legend class="sub">Lista de Titulos</legend>
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
<asp:Button runat="server" OnClick="btnEliminar_Click" OnClientClick="return confirm('Are you sure you want to Logout ?');" CommandName="Eliminar" HeaderText="Eliminar" ItemStyle-CssClass="btButton" Text="Eliminar" />
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
</div>
</form>

</asp:Content>
