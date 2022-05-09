<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BFormularioRegistrosUsuariosLocales.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioRegistrosUsuariosLocales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <div>
            <div class="">
        <div class="center_content">
    <div class="">
        <div class="form-style-10">
            <h1>Registro de Usuarios Locales<span>Gestión de Usuarios para la Autenticación del Sistema.</span></h1>
            <div class="caja">
                <div style="width: 484px; height: 384px; margin-left: 94px;">
                    <div class="datos">
                        <div>
                            <%--<label for="">Estudiante :<input  runat="server" type="text" id="codigoCarta" name="codigoCarta"></label><br>--%>
                                             <label for="">Email :       <asp:TextBox runat="server" ID="txtEstudiante" /></label><br>
                            &nbsp;</div>
                        <div>
                            <%--<label for="">Apellidos :<input  runat="server" ID="fechaActual" name="fechaActual" type="text" onchange="handler(event);"></label><br>--%>
                            <label for="">Password :       <asp:TextBox runat="server" ID="txtApellidos" /></label><br>
                            &nbsp;</div>
                        <div>
                           <%-- <label for="">CI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<input  runat="server" ID="text" name="fechaActual" type="text" onchange="handler(event);" ></label><br>--%>
                            <label for="">Usuarios Netvalle :<asp:TextBox runat="server" ID="txtCi" /></label><br>
                            &nbsp;</div>
                        <div>
                           <%-- <label for="">Correo :<input  runat="server" ID="Date2" name="fechaActual" type="text" onchange="handler(event);" ></label><br>--%>
                            <label for="">Rol Usuario :<asp:DropDownList ID="ddlPlaza" runat="server" Height="16px" style="margin-left: 0px" Width="129px"></asp:DropDownList></label><br>
                            &nbsp;</div>
                        <div>
                           <%-- <label for="">Teléfonos :<input  runat="server" ID="Date3" name="fechaActual" type="text" onchange="handler(event);" ></label><br>--%>
                            <label for="">Código Título :<asp:TextBox runat="server" ID="txtTelefonos" /></label><br>
                            &nbsp;</div>
                        <div>
                            <%--<label for="">Fecha de Creación :<input runat="server" ID="fechaPlazo" name="fechaPlazo" type="date" value="2021-06-27"></label><br>--%>
                            <label for="">Fecha de Creación :<asp:TextBox runat="server" ID="txtDate" /></label><br>
                            &nbsp;</div>
                        <div>
                            <%--<label for="">Descripción :<input  runat="server" ID="Date5" name="fechaActual" type="text" onchange="handler(event);" ></label><br>--%>
                            <label for="">Descripción :<asp:TextBox runat="server" ID="txtDescripcion" /></label><br>
                            &nbsp;</div>
                    </div>
                            
                            <asp:Button  class="btn" ID="btnEnviar"  runat="server" Text="Registrar" OnClick="btnRegistrar_Click" Height="38px" style="margin-left: 21px; margin-top: 25px" Width="375px" />
               <asp:Label runat="server" CssClass="msj" ID="lblMensaje" Text="..." ></asp:Label>
        </div>
    </form>
</asp:Content>
