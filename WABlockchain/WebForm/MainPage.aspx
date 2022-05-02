<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPInicio.Master" CodeBehind="MainPage.aspx.cs" Inherits="WABlockchain.WebForm.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SNotificacion.css" rel="stylesheet" />
<style type="text/css">
    .auto-style1 {
        height: 25px;
    }
    .auto-style2 {
        /* font-family: Arial, Helvetica, sans-serif; */
    font-family: "BBAlpha Sans", "Prelude Medium", "S60 Sans", Tahoma, Verdana, Arial, "Sans-Serif";
        font-size: 11px; /* font-style: italic; */;
        padding: 6px;
        margin: 5px;
        height: 25px;
        width: 114px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
	 <table style="width: 100%" align="center" >
	  <tr>
	   <td>
	    <fieldset style="width: 800px" align="center">
			<legend style="text-align: left"></legend>
			<table width="800px">
				<tr id="ContentPlaceHolder1_CURecursosEstudiante_TRMenu">

					<td style="width: 70%; height: 100%; vertical-align: top">
                        <asp:TextBox ID="TextBox1" runat="server" Width="280px"></asp:TextBox>
                        <asp:Button ID="btnBuscar" runat="server" BackColor="#681E3C" ForeColor="White" Text="Buscar" Width="117px" />
                        <asp:GridView ID="GridView1" runat="server" Height="375px" Width="574px">
                        </asp:GridView>
                    </td>
				</tr>
				<tr>
					<td style="width: 100%; vertical-align: top" colspan="2"></td>
				</tr>
				<tr>
					<td colspan="2" style="text-align: center">
						<span id="ContentPlaceHolder1_CURecursosEstudiante_LBLError" class="LabelMensajeError"></span>
					</td>
				</tr>
			</table>
		</fieldset>
	   </td>
	  </tr>
	 </table>
	</div>
</form>
</asp:Content>
