using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BEntregaTitulos : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();

        /// <summary>
        /// Confirma si esta con la credencial correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "Secretaria")
                    {
                        cargarTitulos();
                        CamposDeshabilitados();
                    }
                    else
                    {
                        Response.Redirect("BMenuPrincipal.aspx");
                    }
                }
                else
                {
                    Response.Redirect("BLogin.aspx");
                }
            }
        }

        /// <summary>
        /// Registra la entrega del titulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            string titulado = txtTitulado.Text;
            DateTime fecha = DateTime.Parse(txtFechaEmision.Text);
            if (titulado.Equals("") || fecha.Equals(""))
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Los campos no pueden estar vacios";
            }
            else
            {
                lblmsg.Visible = false;
                string modo = ddlMetodoEntrega.SelectedValue;
                swLNBlockchainClient.Actualizar_BTittle_ConfirmarEntrega(titulado, fecha, modo);
                cargarTitulos();
                CamposDeshabilitados();
            }
        }
        /// <summary>
        /// Selecciona el titulo que se va a cargar en los campos para despues ser registrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Subir_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            txtTitulado.Text = grvTitulos.Rows[id].Cells[1].Text;
            CamposHabilitados();
        }
        /// <summary>
        /// Lista los titulos
        /// </summary>
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.BTittle_O_State3().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;

        }
        /// <summary>
        /// Desabilita los campos de entrada de datos
        /// </summary>
        private void CamposDeshabilitados()
        {
            this.txtTitulado.Enabled = false;
            this.txtFechaEmision.Enabled = false;
            this.btnRegistrar.Enabled = false;
        }
        /// <summary>
        /// Habilita los campos de entrada de datos
        /// </summary>
        private void CamposHabilitados()
        {
            this.txtFechaEmision.Enabled = true;
            this.btnRegistrar.Enabled = true;
        }
    }
}