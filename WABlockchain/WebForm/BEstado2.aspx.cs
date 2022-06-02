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
    public partial class BEstado2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTitulos();                
            }
        }
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        private static int s;
        
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.BTittle_O_State2().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;

        }
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);

            swLNBlockchainClient.BTittle_update_statusTittle_3(s.ToString());
            cargarTitulos();
        }
    }
}