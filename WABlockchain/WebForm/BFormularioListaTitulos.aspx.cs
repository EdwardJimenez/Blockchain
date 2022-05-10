using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWADBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BFormularioListaTitulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarSolicitud();
            }
        }
        private void CargarSolicitud()
        {
            using (SWADBlockchainService.SWADNETBlockchainClient cliente = new SWADBlockchainService.SWADNETBlockchainClient())
            {
                grvSolicitud.DataSource = null;
                List<EBTittle> lstISolicitudCompleja = new List<EBTittle>();

                lstISolicitudCompleja = cliente.Obtener_BTitle_O_statusTitle().ToList();

                grvSolicitud.DataSource = lstISolicitudCompleja;
                grvSolicitud.DataBind();
            }
        }
    }
}