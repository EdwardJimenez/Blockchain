<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BFormularioRegistroTitulos.aspx.cs" Inherits="WABlockchain.WebForm.BFormularioRegistroTitulos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="../Estilo/Estilos.css" rel="stylesheet" />
    <link href="../Estilo/EstilosUsuariosNetvalle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center_content">
        <div class="form-style-10">
            <h1>Registrar Títulos</h1>
            <div class="caja">
                <div style="width: 484px; height: 384px; margin-left: 94px;">
                    <div class="datos">
                        <div>
                            <label for="">Fecha de emisión:<input  runat="server" type="date" id="dateEm" name="fechaEmision"></label><br>
                            &nbsp;
                        </div>
                        <div>
                            <label for=""> Titulado:<input  runat="server" id="tit" name="titulado" type="text" ></label><br>
                            &nbsp;

                        </div>
                        <div>
                            <label for="">Sede:<input  runat="server" id="sede" name="sede" type="text" ></label><br>
                            &nbsp;

                        </div>
                        
                        
                        <div>
                             <label for="">Método de entrega:</label><br><asp:DropDownList ID="ddlMetEntrega" runat="server" OnTextChanged="ddlMetEntrega_TextChanged" style=" margin-left: 100px;"  AutoPostBack="true" Width="197px">
                                                                            <asp:ListItem Value="">--Método de entrega--</asp:ListItem>
                                                                            <asp:ListItem Value="."></asp:ListItem>
                                                                            <asp:ListItem Value=".."></asp:ListItem>
                                                                            <asp:ListItem Value="..."></asp:ListItem>
                                                                        </asp:DropDownList>
                             
                        </div>
                    </div>                           
                     <asp:Button  class="butt" id="btnRegistrar"  runat="server" Text="Registrar" OnClick="btnRegistrar_Click" Height="45px" style="margin-left: 21px; margin-right: 21px; margin-top: 80px" Width="200px" />
                     <asp:Button  class="butt" id="btnQr"  runat="server" Text="Generar QR" OnClick="btnGenerarQr_Click" Height="45px"  style="margin-left: 21px; margin-top: 25px" Width="200px"/>
                </div>
                <h2></h2>
        </div>
    </form>
</body>
</html>
