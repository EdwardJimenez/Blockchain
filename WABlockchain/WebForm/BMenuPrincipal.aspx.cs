using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.Class;
using WABlockchain.SWLNBlockchainService;
using System.Globalization;


namespace WABlockchain.WebForm
{
    public partial class BMenuPrincipal : System.Web.UI.Page
    {
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                if (Session["Rol"] != null)
                {
                    string Rol = Session["Rol"].ToString();
                    switch (Rol)
                    {
                        case "ReadOnly":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarUsuarioNetvalle.Visible = false;
                            btnRegistrarTitulo.Visible = false;
                            btnConfirmarTitulo.Visible = false;
                            btnSolicitarTitulo.Visible = false;
                            btnRecibirTitulo.Visible = false;
                            btnImprimirTitulo.Visible = false;
                            btnEnviarTitulos.Visible = false;
                            break;
                        case "Secretaria":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarUsuarioNetvalle.Visible = false;
                            btnRegistrarTitulo.Visible = true;
                            btnConfirmarTitulo.Visible = false;
                            btnSolicitarTitulo.Visible = false;
                            btnRecibirTitulo.Visible = false;
                            btnImprimirTitulo.Visible = true;
                            btnEnviarTitulos.Visible = true;
                            break;
                        case "Admin":
                            btnRegistrarUsuario.Visible = true;
                            btnRegistrarUsuarioNetvalle.Visible = true;
                            btnRegistrarTitulo.Visible = false;
                            btnConfirmarTitulo.Visible = false;
                            btnSolicitarTitulo.Visible = false;
                            btnRecibirTitulo.Visible = false;
                            btnImprimirTitulo.Visible = false;
                            btnEnviarTitulos.Visible = false;
                            break;
                        case "VRA":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarUsuarioNetvalle.Visible = false;
                            btnRegistrarTitulo.Visible = false;
                            btnConfirmarTitulo.Visible = true;
                            btnSolicitarTitulo.Visible = true;
                            btnRecibirTitulo.Visible = true;
                            btnImprimirTitulo.Visible = false;
                            btnEnviarTitulos.Visible = false;
                            break;
                    }
                }
                else
                {
                    Response.Redirect("BLogin.aspx");
                }
            }
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("BRegistroUsuarioNuevo.aspx");
        }

        protected void btnRegistrarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BResgistroTitulo.aspx");
        }

        protected void btnRegistrarUsuarioNetvalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("BVerUsuariosNetvalle.aspx");
        }

        protected void btnConfirmarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado2.aspx");
        }
        protected void btnImprimirTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado3.aspx");
        }
        protected void btnSolicitarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado5.aspx");
        }
        protected void btnEnviarTitulos_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado6.aspx");
        }
        protected void btnRecibirTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado7.aspx");
        }

        protected void btnSearch_Click1(object sender, EventArgs e)
        {
            string searchFacultyCarreer = txtBuscador.Text;

            GridView1.DataSource = null;
            GridView1.DataBind();

            try
            {
                if (searchFacultyCarreer.Equals(""))
                {
                    lblmensaje.Text = "Ingrese Facultad o Carrera !!!";
                }
                else
                {
                    List<EBTittle> lstTitle = new List<EBTittle>();

                    lstTitle = swLNBlockchainClient.Search_BTitle_Faculty_Carrer_Date(searchFacultyCarreer).ToList();
                    if (lstTitle.Count() == 0)
                    {
                        lblmensaje.Text = "No se encontro el título";
                    }
                    else
                    {
                        GridView1.DataSource = lstTitle;
                        GridView1.DataBind();
                        GridView1.SelectedIndex = 0;
                        lblmensaje.Text = "Título encontrado";
                    }
                }
            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }

        protected void btnSearchDate_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = FechaInicio.SelectedDate;
            DateTime fechaFin = FechaFin.SelectedDate;

            GridView1.DataSource = null;
            GridView1.DataBind();

            try
            {
                if (fechaFin > fechaInicio)
                {
                    List<EBTittle> lstTitle = new List<EBTittle>();
                    lstTitle = swLNBlockchainClient.Search_BTitle_Date(fechaInicio, fechaFin).ToList();

                    if (lstTitle.Count() == 0)
                    {
                        lblmensaje.Text = "No se encontro el título" + FechaInicio.SelectedDate;
                    }
                    else
                    {
                        GridView1.DataSource = lstTitle;
                        GridView1.DataBind();
                        GridView1.SelectedIndex = 0;
                        lblmensaje.Text = "Título encontrado";
                    }
                }
                else
                {
                    lblmensaje.Text = "La fecha final debe ser mayor a la fecha de inicio !!!";
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = ex.Message;
            }
        }
    }
}