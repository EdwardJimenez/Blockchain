<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BVerUsuariosNetValle.aspx.cs" Inherits="WABlockchain.WebForm.BVerUsuariosNetValle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .gridview {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
        <div>
<fieldset id="field">
<legend class="sub">Lista de Solicitudes</legend>
  
<asp:GridView ID="grvUsersNetvalle" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" Width="801px"
    >
<Columns>
<asp:BoundField DataField="IDPerson" ItemStyle-CssClass="hidden">
<HeaderStyle CssClass="hidden" />
<ItemStyle CssClass="hidden" />
<FooterStyle CssClass="hidden" />

</asp:BoundField>
<asp:BoundField DataField="Fullname" HeaderStyle-CssClass="name" HeaderText="NOMBRE COMPLETO" ItemStyle-CssClass="itName" SortExpression="name" />
<asp:BoundField DataField="Phone" HeaderStyle-CssClass="cell" HeaderText="CELULAR" ItemStyle-CssClass="itCell" SortExpression="cell" />
<asp:BoundField DataField="CI" HeaderStyle-CssClass="ci" HeaderText="CI" ItemStyle-CssClass="itCi" SortExpression="ci" />
<asp:BoundField DataField="Mail" HeaderStyle-CssClass="mail" HeaderText="CORREO ELECTRONICO" ItemStyle-CssClass="itMail" SortExpression="mail" />
<asp:BoundField DataField="ExtCI" HeaderStyle-CssClass="ciextra" HeaderText="CI EXTRA" ItemStyle-CssClass="itCiextra" SortExpression="ciextra" />

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