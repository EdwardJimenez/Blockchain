<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioListaTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioListaTitulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<form id="form1" runat="server">
<div>
<fieldset id="field">
<legend class="sub">Lista de Solicitudes</legend>
<asp:GridView ID="grvSolicitud" CssClass="gridview" runat="server" CellPadding="10" AutoGenerateColumns="False">
<Columns>

<asp:BoundField DataField="NombreCompleto" HeaderText="NOMBRE COMPLETO"/>
<asp:BoundField DataField="NombreUniEx" HeaderText="UNIVERSIDAD DE ORIGEN" />
<asp:BoundField DataField="ProgramaNombre" HeaderText="PROGRAMA" />
<asp:ButtonField ButtonType="Button" HeaderText="ENVIAR" Text="Enviar" />
</Columns>
</asp:GridView>
</fieldset>
</div>



        <div class="modal-container">
            <div class="modal modal-close">
<div class="modal-textos" style="font-weight: bold">
<asp:Label ID="lblMensaje" Text="La notificación se envió correctamente" runat="server"></asp:Label>
<div class="modal-button">
</div>
</div>
</div>
</div>
</form>

</asp:Content>
