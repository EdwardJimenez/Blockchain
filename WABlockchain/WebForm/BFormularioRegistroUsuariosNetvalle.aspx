<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BFormularioRegistroUsuariosNetvalle.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioRegistroUsuariosNetvalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Estilo/Estilos.css" rel="stylesheet" />
    <link href="../Estilo/EstilosUsuariosNetvalle.css" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
        <div class="center_content">
        <div class="form-style-10">
            <h1>Autenticar Usuarios Netvalle</h1>
            <div class="caja">
                <div style="width: 484px; height: 384px; margin-left: 94px;">
                    <div class="datos">
                        <div>
                            <label for="">Nombres :<input  runat="server" type="text" id="pNombre" name="primerNombre"> <input  runat="server" type="text" id="sNombre" name="segundoNombre"></label><br>
                            &nbsp;
                        </div>
                        <div>
                            <label for=""> Apellidos :<input  runat="server" id="pApellido" name="primerApellido" type="text" onchange="handler(event);"> <input  runat="server" type="text" id="sApellido" name="segundoApellido"></label><br>
                            &nbsp;

                        </div>
                        <div>
                            <label for="">Teléfono :<input  runat="server" id="telf" name="telefono" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;

                        </div>
                        <div>
                            <label for="">CI :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input  runat="server" id="ci" name="CI" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;

                        </div>
                        <div>
                            <label for="">Extensión CI :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input  runat="server" id="extCi" name="extensionCi" type="text" onchange="handler(event);" ></label><br>
                            &nbsp;

                        </div>
                        
                        <div>
                             <label for="">Rol :<asp:DropDownList ID="ddlSelectRol" runat="server" OnTextChanged="ddlSelectRol_TextChanged" AutoPostBack="true" Width="197px">
                                                                            <asp:ListItem Value="">--Seleccione una opción--</asp:ListItem>
                                                                            <asp:ListItem Value="S">Secretaria</asp:ListItem>
                                                                            <asp:ListItem Value="RO">Read Only</asp:ListItem>
                                                                            <asp:ListItem Value="UN">Usuario Netvalle</asp:ListItem>
                                                                            <asp:ListItem Value="A">Administrador</asp:ListItem>
                                                                        </asp:DropDownList>
                             </label><br>
                        </div>
                    </div>
                            
                            <asp:Button  class="butt" id="btnAutenticar"  runat="server" Text="Autenticar" OnClick="btnAutenticar_Click" Height="38px" style="margin-left: 21px; margin-top: 50px" Width="433px" />
                </div>
                <h2></h2>
        </div>
    </form>
</body>
</html>
