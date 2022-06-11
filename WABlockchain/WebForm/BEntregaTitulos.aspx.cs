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
            if (!IsPostBack)
            {
                cargarTitulos();
                CamposDeshabilitados();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string titulado = txtTitulado.Text;
            DateTime fecha = DateTime.Parse(txtFechaEmision.Text);
            string modo = ddlMetodoEntrega.SelectedValue;
            swLNBlockchainClient.Actualizar_BTittle_ConfirmarEntrega(titulado, fecha, modo);
            cargarTitulos();
            CamposDeshabilitados();
        }
        protected void Subir_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            /*int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);

            swLNBlockchainClient.BTittle_update_statusTittle_7(s.ToString());
            cargarTitulos();
            */
            txtTitulado.Text = grvTitulos.Rows[id].Cells[1].Text;
            CamposHabilitados();
        }
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.BTittle_O_TO_Upload().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;

        }
        private void CamposDeshabilitados()
        {
            this.txtTitulado.Enabled = false;
            this.txtFechaEmision.Enabled = false;
            this.btnRegistrar.Enabled = false;
        }
        private void CamposHabilitados()
        {
            this.txtFechaEmision.Enabled = true;
            this.btnRegistrar.Enabled = true;
        }
        protected void grvTitulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}