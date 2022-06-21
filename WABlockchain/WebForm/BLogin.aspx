<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BLogin.aspx.cs" Inherits="WABlockchain.WebForm.BLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Estilo/EstiloMasterPage/EstiloMPLogin.css" rel="stylesheet" />
    <link href="../Estilo/EstiloLogin.css" rel="stylesheet" />
    <title></title>
</head>
<body>
   <form id="form1" runat="server">

        <div id="wrapper">
            <div id="main_container">
                <div id="header">
                    <div id="logo">
                        <div class="footer">
                            <div class="footer_image_left">
                            </div>
                            <h5 class="home_footer" dir="ltr">
                                <span id="LBLAnio">2021</span> Netvalle - Universidad Privada del Valle - Bolivia
                            </h5>
                            <div class="footer_image_right">
                            </div>
                        </div>
                        <a href="#">
                            <div class="imgLogo">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/logo.png" Height="74px" Width="539px" />
                            </div>
                        </a>
                    </div>
                    <table class="info_Usuario">
                        <tbody>
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 800px">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <table style="width: 100%">
                                                        <tbody>
                                                            <tr>
                                                                <td colspan="3" style="width: 100%">
                                                                    <table style="width: 100%">
                                                                        <tbody>
                                                                            <tr>
                                                                                <td style="width: 50%; text-align: left">
                                                                                    <span id="LBLCarrera" class="LabelSesion" style="padding-left: 15px">ING. DE SISTEMAS INFORMATICOS</span>
                                                                                </td>
                                                                                <td style="width: 50%; text-align: right">
                                                                                    <span id="LBLSedeAcademica" class="LabelSesion" style="padding-left: 15px">SEDE ACADÉMICA COCHABAMBA</span>
                                                                                </td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>

                </div>
            </div>

            <div class="center_content">
                <table style="width: 750px; text-align: center">
                    <tbody>
                        <tr>
                            <td id="tdDE" runat="server">
                                <ul class="mainmenu">
                                    <li id="ContentPlaceHolder1_liSiu">
                                        <a id="ContentPlaceHolder1_LKBSiu" title="Gestiona tu información personal" style="display: inline-block; font-size: 13px; height: 50px; width: 440px; margin: 0 5px 0 0;" href="../DirectorEducacion/IMenuDirectorEducacion.aspx"><b style="font-size: 30px">B</b>LOCKCHAIN</a>
                                    </li>
                                    <li id="ContentPlaceHolder1_liTips">
                                        <a id="ContentPlaceHolder1_LKBTips" title="Tips para tomar en cuenta" style="display: inline-block; font-size: 13px; height: 50px; width: 100px; margin: 0 5px 0 0;"></a>
                                    </li>
                                    <b style="font-size: 35px">

                                        <li id="ContentPlaceHolder1_li1">
                                            <a id="ContentPlaceHolder1_LKBPerfil" title="Revisa tu perfil de usuario" style="display: inline-block; font-size: 13px; height: 50px; width: 110px; padding-left: 15px; padding-right: 15px">
                                                <asp:Image ID="Image2" runat="server" Style="height: 35px; width: 35px; border: 0 none; margin-top: 5px" ImageUrl="~/Imagenes/perfil.png"/>
                    <asp:Label ID="z0" runat="server"></asp:Label>
                                            </a>
                                        </li>
                                </ul>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <div class="IniarSesion">
                    BIENVENIDO<br />
                </div>
                <div class="botons">
                    <asp:TextBox CssClass="nombre" ID="txtNombre" placeholder="User Name" runat="server" Height="37px" Width="202px"></asp:TextBox>
                    <asp:Label ID="LC1" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar usuario" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <br />
                    <asp:TextBox CssClass="password" ID="txtPassword" TextMode="Password" placeholder="Password" runat="server" Height="37px" Width="202px"></asp:TextBox>
                    <asp:Label ID="LRol" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Debe ingresar contraseña" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Label ID="lblError" runat="server" ForeColor="#CC0000"></asp:Label>
                    <br />
                    <asp:Button CssClass="cargar" ID="btnCargar" runat="server" Text="Iniciar Sesion" Height="44px" Width="146px" OnClick="btnCargar_Click" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>
