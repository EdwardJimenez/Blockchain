<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioListaUsuariosNetValle.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioListaUsuariosNetValle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
        <div>
<fieldset id="field">
<legend class="sub">Lista de Solicitudes</legend>
     <label for="">Buscar por nombre:       <asp:TextBox runat="server" ID="txtNombre" AutoPostBack ="true" OnTextChanged="txtNombre_TextChanged" /></label><br>
     <asp:label ID="lblTest" runat="server">Tests</asp:label> 
<asp:GridView ID="grvUsersNetvalle" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" >
<Columns>
<asp:BoundField DataField="IDPerson" ItemStyle-CssClass="hidden">
<HeaderStyle CssClass="hidden" />
<ItemStyle CssClass="hidden" />
<FooterStyle CssClass="hidden" />

</asp:BoundField>
<asp:BoundField DataField="Fullname" HeaderStyle-CssClass="name" HeaderText="NOMBRE COMPLETO" ItemStyle-CssClass="itName" SortExpression="name" />
<asp:BoundField DataField="IDCareer" Visible="false" HeaderStyle-CssClass="id" HeaderText="ID CARRERA" ItemStyle-CssClass="itId" SortExpression="id" />
<asp:BoundField DataField="CareerName" HeaderStyle-CssClass="program" HeaderText="CARRERA" ItemStyle-CssClass="itProgram" SortExpression="program" />
<asp:BoundField DataField="FacultyName" HeaderStyle-CssClass="college" HeaderText="FACULTAD" ItemStyle-CssClass="itCollege" SortExpression="college" />
<asp:BoundField DataField="SedeName" HeaderStyle-CssClass="sede" HeaderText="SEDE" ItemStyle-CssClass="itSede" SortExpression="sede" />

    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" OnClick="btn1_Click"  HeaderText="Enviar" ItemStyle-CssClass="btButton" Text="Enviar"  />
                        </ItemTemplate>
                    </asp:TemplateField>
</Columns>
</asp:GridView> 
</fieldset>
</div>


</form>
</asp:Content>