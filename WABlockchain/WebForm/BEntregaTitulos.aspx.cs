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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string titulado = txtTitulado.Text;
            DateTime fecha = DateTime.Parse(txtFechaEmision.Text);
            string modo = ddlMetodoEntrega.SelectedValue;
            swLNBlockchainClient.Actualizar_BTittle_ConfirmarEntrega(titulado, fecha, modo);
        }
    }
}