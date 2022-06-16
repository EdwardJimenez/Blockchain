using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;
using WABlockchain.Class;

namespace WABlockchain.WebForm
{
    
    public partial class BFormularioBuscarTitulos : System.Web.UI.Page
    {
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            EBTittle tittle = new EBTittle();

            try
            {
                string nombreEst;
                if(txtSegundo.Text != "")
                {
                    nombreEst = (txtNombreEstudiante.Text).Trim() + " " + (txtPrimero.Text).Trim() + " " + (txtSegundo.Text).Trim();
                }
                else
                {
                    nombreEst = (txtNombreEstudiante.Text).Trim()+" "+(txtPrimero.Text).Trim();
                }
                List<EBTittle> lstTitle = new List<EBTittle>();
                lstTitle = swLNBlockchainClient.Search_BTitle(nombreEst, txtCarrera.Text, txtFacultad.Text).ToList();
                if (lstTitle.Count() == 0)
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
                lblMensaje.Text = "No se encontro el titulo verifica tus datos"+ ex.Message;
            }
        }
    }
}