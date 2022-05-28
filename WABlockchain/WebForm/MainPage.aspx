<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPInicio.Master" CodeBehind="MainPage.aspx.cs" Inherits="WABlockchain.WebForm.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SNotificacion.css" rel="stylesheet" />
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
                        <asp:Button ID="btnBuscar" runat="server" BackColor="#681E3C" ForeColor="White" Text="Buscar" Width="117px" OnClick="btnBuscar_Click" />
							<div> 
								<p>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="180px">
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="221px">
                                    </asp:DropDownList>
                        </div>
                        <asp:GridView ID="grvTitulados" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" HorizontalAlign="Center">
							<Columns>
								<asp:BoundField DataField="IdTittles" ItemStyle-CssClass="hidden">
								<HeaderStyle CssClass="hidden" />
								<ItemStyle CssClass="hidden" />
								<FooterStyle CssClass="hidden" />
								</asp:BoundField>
								<asp:BoundField DataField="fullNameTitulado" HeaderStyle-CssClass="name" HeaderText="NOMBRE COMPLETO" ItemStyle-CssClass="itName" SortExpression="name" />
								<asp:BoundField DataField="faculty" HeaderStyle-CssClass="college" HeaderText="FACULTAD" ItemStyle-CssClass="itCollege" SortExpression="college" />
								<asp:BoundField DataField="carreer" HeaderStyle-CssClass="program" HeaderText="CARRERA" ItemStyle-CssClass="itProgram" SortExpression="program" />

							</Columns>
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
