using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;
using System.Globalization;


namespace WABlockchain.WebForm
{
    public partial class BMenuPrincipal : System.Web.UI.Page
    {
        /// <summary>
        /// Creación de la instancia swLNBlockchainCliente, perteneciente a al servicio de la 
        /// capa de negocio que nos permite conectar con la capa Acceso a Datos para conectarnos
        /// con la Base de Datos
        /// </summary>
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarTituladosGeneral();
            ////// Control de usuarios: Inicio de session de acuerdo a 4 roles de usuarios:
            ///ReadOnly
            ///Secretaria
            ///Admin
            /// VRA
            /// De acuerdo al usuario con un rol que ingrese al sistema, tiene restricción de visualización
            /// de ciertos elementos.
            ///
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
                            btnEntregaTitulo.Visible = false;
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
                            btnEntregaTitulo.Visible = true;
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
                            btnEntregaTitulo.Visible = false;
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
                            btnEntregaTitulo.Visible = false;
                            break;
                    }
                }
                else
                {
                    Response.Redirect("BLogin.aspx");
                }
            }
        }

        /// <summary>
        /// btnRegistrarUsuario_Click
        /// btnRegistrarTitulo_Click
        /// btnRegistrarUsuarioNetvalle_Click
        /// btnConfirmarTitulo_Click
        /// btnImprimirTitulo_Click
        /// btnSolicitarTitulo_Click
        /// btnEnviarTitulos_Click
        /// btnRecibirTitulo_Click
        /// btnEntregaTitulo_Click
        /// Los eventos de estos botones tienen la función de redireccionar al usuario
        /// de la página actual a otra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        protected void btnEntregaTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEntregaTitulos.aspx");
        }


        /// <summary>
        /// Boton de Búsqueda por: Facultad y Carrera
        /// Este evento realiza la busqueda de una facultad y carrera existente mediante un textbox
        /// El parametro searchFacultyCarreer es enviado al metodo Search_BTitle_Faculty_Carrer_Date 
        /// de la capa de negocio, una vez encontrado los datos, estos se desplegan en un grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Boton Buscar por Fecha : Este evento realiza una busqueda
        /// de los titulos de acuerdo al rango de fecha que se seleccione en el calendar, 
        /// enviando los parámetros fechaInicio y fechaFin al metodo Search_BTitle_Date que se encuentra
        /// en nuestra capa de negocio. Una vez enviando los parametros se lista en el grid los datos recuperados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Carga o lista de los titulados en general
        /// </summary>
        private void ListarTituladosGeneral()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.Obtener_Title_O_ListGraduates().ToList();
            GridView1.DataSource = lstTitle;
            GridView1.DataBind();
            GridView1.SelectedIndex = 0;
        }
    }
}