<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="BResgistroTitulo.aspx.cs" Inherits="WABlockchain.WebForm.BResgistroTitulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/EstiloRegistros/EstiloRegistroTitulo.css" rel="stylesheet" />   
    <link href="../Estilo/SGridView.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
                   <table>
                        <tr>
                            <td>
                                <div class="list">
                                   <asp:TextBox class="txt" ID="txbNombre" runat="server"></asp:TextBox><br>
                                   <asp:TextBox ID="txbCarrera" class="txt" runat="server"></asp:TextBox><br>
                                   <asp:TextBox ID="txbFacultad" class="txt" runat="server"></asp:TextBox><br />
                                   <asp:DropDownList ID="ddlEstado"  class="txt" runat="server" OnTextChanged="ddlSelectRol_TextChanged" AutoPostBack="true" Width="197px">
                                       <asp:ListItem Value="">--Seleccione una opción--</asp:ListItem>
                                   </asp:DropDownList>
                                </div>
                                <button class="bot" type="button" id="btnInsert">Insert</button>
                                <button class="bot" type="button" id="btnUpdate">Update</button>                                 
                            </td>
                            <td>  
                    <asp:GridView ID="grvListaTitulos" OnRowCommand="grvListaTitulos_RowCommand" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="NombreCompleto" HeaderText="NOMBRE TITULANTE" SortExpression="name" />                            
                            <asp:BoundField DataField="NombreCarrera" HeaderText="CARRERA" SortExpression="career" />
                            <asp:BoundField DataField="NombreFacultad" HeaderText="FACULTAD" SortExpression="faculty" />
                            <asp:BoundField DataField="Estado" HeaderText="ESTADO TÍTULO" SortExpression="status" />
                            <asp:ButtonField ButtonType="Button" ControlStyle-BackColor="White" CommandName="btnDelete" Text="Delete"  />
                        </Columns>
                    </asp:GridView>
                            </td>
                        </tr>                       
                    </table>
    </form>
</asp:Content>
