<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioRegistrosUsuariosLocales.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioRegistrosUsuariosLocales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
    <div class="">
        <div class="form-style-10">
            <h1>Registro de Usuarios Locales<span>Gestión de Usuarios para la Autenticación del Sistema.</span></h1>
            <div class="caja">
                <div style="width: 484px; height: 384px; margin-left: 94px;">
                    <div class="datos">
                        <div>
                            <label for="">Estudiante :<input  runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>
                            &nbsp;</div>
                        <div>
                            <label for="">Apellidos :<input  runat="server" ID="fechaActual" name="fechaActual" type="text" onchange="handler(event);"></label><br>
                            &nbsp;</div>
                        <div>
                            <label for="">CI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<input  runat="server" ID="text" name="fechaActual" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;</div>
                        <div>
                            <label for="">Correo :<input  runat="server" ID="Date2" name="fechaActual" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;</div>
                        <div>
                            <label for="">Teléfonos :<input  runat="server" ID="Date3" name="fechaActual" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;</div>
                        <div>
                            <label for="">Fecha de Creación :<input runat="server" ID="fechaPlazo" name="fechaPlazo" type="date" value="2021-06-27"></label><br>
                            &nbsp;</div>
                        <div>
                            <label for="">Descripción :<input  runat="server" ID="Date5" name="fechaActual" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;</div>
                    </div>
                            
                            <asp:Button  class="btn" ID="btnEnviar"  runat="server" Text="Registrar" OnClick="btnRegistrar_Click" Height="38px" style="margin-left: 21px; margin-top: 25px" Width="375px" />
                
</asp:Content>
