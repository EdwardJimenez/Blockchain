using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.Class;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BFormularioBuscarTtulo : System.Web.UI.Page
    {
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            EBTittle tittle = new EBTittle();
            grvTitulos.DataSource = null;
            grvTitulos.DataBind();
            try
            {
                string nombreEst;
                if (txtSegundoApellido.Text != "") //revisa si hay un segundo apellido
                {
                    nombreEst = (txtNombrePersona.Text).Trim() + " " + (txtPrimerApellido.Text).Trim() + " " + (txtSegundoApellido.Text).Trim();
                }
                else
                {
                    nombreEst = (txtNombrePersona.Text).Trim() + " " + (txtPrimerApellido.Text).Trim();
                }
                List<EBTittle> lstTitle = new List<EBTittle>();
                lstTitle = swLNBlockchainClient.Search_BTitle(nombreEst, txtCarrera.Text, txtFacultad.Text).ToList();
                if (lstTitle.Count() == 0) //verifica si se encontro el titulo
                {
                    lblMensaje.Text = "No se encontro el titulo verifica tus datos";
                }
                else
                {
                    grvTitulos.DataSource = lstTitle;
                    grvTitulos.DataBind();
                    grvTitulos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "No se encontro el titulo verifica tus datos" + ex.Message;
            }
        }
    }
}